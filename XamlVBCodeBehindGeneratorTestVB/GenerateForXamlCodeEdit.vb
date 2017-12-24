Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions

Public Class GenerateForXamlCodeEdit
    Sub Run(projDir$)
        Const xmlNameSpaceX As String = "http://schemas.microsoft.com/winfx/2009/xaml"
        Dim common = "Imports Xamarin.Forms
Imports Xamarin.Forms.Xaml
"
        Dim appXaml = ""
        Dim pageXaml = ""
        Dim fn$
        Dim getXamlXClass As New Regex("(?<=x:Class\="").+?(?="")")
        Dim pageXamlBuilder As New StringBuilder
        Dim appXamlBuilder As New StringBuilder
        Directory.SetCurrentDirectory(projDir)
        For Each fn In From f In Directory.GetFiles(projDir)
                       Where f.EndsWith(".xaml", StringComparison.OrdinalIgnoreCase)
                       Select Path.GetFileName(f)
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
                Dim xmlXName As XName = XName.Get("Name", xmlNameSpaceX)
                Dim namedElements = From node In parsedXaml.Descendants
                                    Let name = node.Attribute(xmlXName)?.Value
                                    Where Not String.IsNullOrEmpty(name)
                                    Select ControlName = name, ElementName = node.Name.LocalName
                Dim withEventsBlock = String.Join(vbCrLf, From e In namedElements
                                                          Select $"WithEvents {e.ControlName} As {e.ElementName}")
                Dim withEventsInitBlock = String.Join(vbCrLf, From e In namedElements
                                                              Select $"{e.ControlName} = Content.FindByName(Of {e.ElementName})(NameOf({e.ControlName}))")
                curBuilder.AppendLine($"Partial Public Class {className}
    Inherits ContentPage
{withEventsBlock}
    Sub New()
        InitializeComponent()
{withEventsInitBlock}
    End Sub

    Private Sub InitializeComponent()
        Extensions.LoadFromXaml(Me, GetType({className}))
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
