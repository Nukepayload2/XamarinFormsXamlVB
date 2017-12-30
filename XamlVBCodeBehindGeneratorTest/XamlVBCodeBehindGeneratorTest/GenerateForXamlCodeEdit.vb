﻿Option Strict On

Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions

Public Class GenerateForXamlCodeEdit
    Sub Run(projDir$)
        Const X2009Uri = "http://schemas.microsoft.com/winfx/2009/xaml",
              XFUri = "http://xamarin.com/schemas/2014/forms"
        Dim tryGetClrNamespace =
            Function(xmlns As String) As String
                If xmlns.StartsWith("using") OrElse xmlns.StartsWith("clr-namespace") Then
                    Dim endPos = xmlns.LastIndexOf(";"c)
                    Dim start = xmlns.IndexOf(":"c) + 1
                    If endPos <= 0 Then
                        Return xmlns.Substring(start)
                    Else
                        Return xmlns.Substring(start, endPos - start)
                    End If
                ElseIf xmlns = XFUri Then
                    Return "Xamarin.Forms"
                Else
                    Return String.Empty
                End If
            End Function
        Dim common = "Option Strict On
Imports Xamarin.Forms
Imports Xamarin.Forms.Xaml
"
        Dim appXaml = ""
        Dim pageXaml = ""
        Dim getXamlXClass As New Regex("(?<=x:Class\="").+?(?="")")
        Dim pageXamlBuilder As New StringBuilder
        Dim appXamlBuilder As New StringBuilder
        Dim getFiles As Func(Of String, Integer, IEnumerable(Of String)) =
            Iterator Function(dir, iterCount)
                Directory.SetCurrentDirectory(dir)
                If iterCount > 3 Then Return ' Special handling for recursive directory junction, to avoid infinite loop.
                Dim innerDirs = Directory.GetDirectories(dir)
                For Each f In Directory.GetFiles(dir)
                    Yield f
                Next
                For Each innerDir In innerDirs
                    For Each f In getFiles(innerDir, iterCount + 1)
                        Yield f
                    Next
                Next
            End Function
        For Each fp In From f In getFiles(projDir, 0)
                       Where f.EndsWith(".xaml", StringComparison.OrdinalIgnoreCase)
            Dim fn = Path.GetFileName(fp)
            Dim isAppXaml As Boolean = fn.Equals("App.xaml", StringComparison.OrdinalIgnoreCase)
            Dim curBuilder = If(isAppXaml, appXamlBuilder, pageXamlBuilder)
            Dim className = Path.GetFileNameWithoutExtension(fn)
            Dim xamlText As String = File.ReadAllText(fn)
            Dim definedXClass As Boolean = getXamlXClass.IsMatch(xamlText)
            If definedXClass Then
                Dim matched = getXamlXClass.Match(xamlText).Value
                Dim dotIndex = matched.LastIndexOf("."c)
                className = matched.Substring(dotIndex + 1)
                If dotIndex > 0 Then
                    curBuilder.
                        Append("Namespace Global.").
                        Append(matched, 0, dotIndex).AppendLine()
                Else
                    Throw New InvalidOperationException("Invalid x:Class value in App.xaml.")
                End If
            End If
            curBuilder.AppendLine($"<Global.Xamarin.Forms.Xaml.XamlFilePath(""{fp}"")>")
            If isAppXaml Then
                curBuilder.AppendLine($"Partial Public Class {className}
    Inherits Application

    Private Sub InitializeComponent()
        Extensions.LoadFromXaml(Me, GetType({className}))
    End Sub
End Class
")
            Else
                ' WithEvents code generation.
                Dim parsedXaml = XElement.Parse(xamlText)
                ' TODO: Do not add named elements that can't be found with Content.FindByName.
                Dim xmlXName As XName = XName.Get("Name", X2009Uri)
                Dim baseClass = parsedXaml.Name.LocalName
                Dim namedElements = From node In parsedXaml.Descendants
                                    Let nameAttr = node.Attribute(xmlXName)
                                    Where nameAttr IsNot Nothing
                                    Let ctlName = nameAttr.Value ' We can't use node.@Value until VB has method scope Imports directive.
                                    Let ctlNamespace = tryGetClrNamespace(node.Name.Namespace.NamespaceName)
                                    Where Not (String.IsNullOrEmpty(ctlNamespace) OrElse String.IsNullOrEmpty(ctlName))
                                    Select ControlName = ctlName, TypeName = "Global." + ctlNamespace + "." + node.Name.LocalName
                Dim withEventsBlock = String.Join(vbCrLf, From e In namedElements
                                                          Select $"WithEvents {e.ControlName} As {e.TypeName}")
                Dim withEventsInitBlock = String.Join(vbCrLf, From e In namedElements
                                                              Select $"{e.ControlName} = Content.FindByName(Of {e.TypeName})(NameOf({e.ControlName}))")
                curBuilder.AppendLine($"Partial Public Class {className}
    Inherits {baseClass}
{withEventsBlock}
    Sub New()
        InitializeComponent()
        OnComponentInitialized()
    End Sub

    Partial Private Sub OnComponentInitialized()

    End Sub

    Private Sub InitializeComponent()
        Extensions.LoadFromXaml(Me, GetType({className}))
{withEventsInitBlock}
    End Sub
End Class")
            End If
            If definedXClass Then
                curBuilder.AppendLine("End Namespace")
            End If
        Next
        appXaml = appXamlBuilder.ToString
        pageXaml = pageXamlBuilder.ToString
    End Sub

End Class
