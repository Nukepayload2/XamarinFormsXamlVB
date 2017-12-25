# XamarinFormsXamlVB
Provides Xamarin.Forms Xaml support for Visual Basic.

Our target is allow you to write cross-platform app with Xamarin.Forms, Visual Basic and Xaml.

The only truly useful file in this project is [a T4 template which generates a VB source file that equivalent to *.xaml.g.vb files](https://github.com/Nukepayload2/XamarinFormsXamlVB/blob/master/XamlVBCodeBehindGeneratorTest/XamlVBCodeBehindGeneratorTest/GeneratedForXaml.tt).

The custom tool which is named "MSBuild:UpdateDesignTimeXaml" is unable to generate .xaml.g.vb and .xaml.g.i.vb files.
It blocks the way we use Xamarin.Forms with Xaml in Visual Basic .NET Standard class libraries.
That's why I'm working on a T4 template that generates those missing codes.

���İ������Ӣ�İ����

## How to Use it
- Clone this repository.
- Open it with Visual Studio (>= 15.5.2).
- Create a project template from XamlVBCodeBehindGeneratorTest.vbproj.
- File -> New Project -> C# -> Cross-platform -> Cross platform App -> Select .NET Standard instead of Shared Project -> Create
- Copy the name of the C# .NET Standard project and exclude the project from solution.
- Move the excluded project to another directory.
- Create a new VB project with the template you have just created.
- For each platform specific projects, add reference to the VB project.
- Run all T4 templates when you have modified .xaml files.

## Dependencies
- Microsoft Visual Studio (>= 15.5.2)
- Xamarin workload and cross platform development workload in Visual Studio
- Windows 10 (>= 10.0.16299.0)

## Known Issues
- Xaml pre-compile is not supported.
- The Xamarin.Forms UI assembly can not be simplified (or linked).
- All elements that have specified x:Name will generate corresponding `WithEvent` members.
- XML namespace is not fully supported. All controls are not qualified with Namespace.

## Contribute
- We need your help to improve English contents or fix bugs.
- We welcome feedback. Please post Issues to tell us where or how can we improve.

# ���
֧�� Visual Basic �� Xamarin.Forms �� Xaml��

���ǵ�Ŀ��������ͬʱʹ�� Xamarin.Forms, Visual Basic �� Xaml ������ƽ̨Ӧ�á�

�����Ŀ�������õ��ļ��� [һ�������� .xaml.g.vb ��Ч�����ļ��� T4 ģ��](https://github.com/Nukepayload2/XamarinFormsXamlVB/blob/master/XamlVBCodeBehindGeneratorTest/XamlVBCodeBehindGeneratorTest/GeneratedForXaml.tt).

��Ϊ "MSBuild:UpdateDesignTimeXaml" ���Զ��幤�߲������� .xaml.g.vb �� .xaml.g.i.vb �ļ���
����谭������ Visual Basic .NET Standard ���ʹ�� Xamarin.Forms �� Xaml ��
�����Ϊʲô����дһ�� T4 ����������������Щȱʧ���ļ���

## ��ô��
- ��¡����ֿ�
- �� Visual Studio (>= 15.5.2) ��
- �� XamlVBCodeBehindGeneratorTest.vbproj ������Ŀģ��
- �ļ� -> �½����� -> C# -> Cross-platform -> Cross platform App -> ѡ�� .NET Standard ������ Shared Project -> Create
- �����Ǹ� C# .NET Standard ��Ŀ�����ƣ������ų��ڽ�������⣬Ȼ�����Ų��
- ����һ��ͬ���� VB .NET Standard ��Ŀ
- ÿ��ƽ̨�ض�����ĿҪ�����Ǹ� VB ��Ŀ
- �޸� .xaml �ļ���Ҫ���� T4 ģ��

## ������
- Microsoft Visual Studio (>= 15.5.2)
- Visual Studio �� Xamarin �� ��ƽ̨������������
- Windows 10 (>= 10.0.16299.0)

## ��֪����
- Xaml Ԥ���벻��֧�֡�
- Xamarin.Forms UI ���򼯲��ܼ򻯻����ӡ�
- ���д� x:Name ��Ԫ�ػ������Ӧ�� `WithEvent` ��Ա��
- XML �����ռ���δ��ȫ֧�֣����пؼ���û�м������ռ����Ρ�

## ����
- ������Ҫ�������Ľ�Ӣ�����ݺ��޸� Bug��
- ���ǻ�ӭ��������ͨ�� Issues ��������������������Ľ���