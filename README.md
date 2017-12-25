# XamarinFormsXamlVB
Provides Xamarin.Forms Xaml support for Visual Basic.

Our target is allow you to write cross-platform app with Xamarin.Forms, Visual Basic and Xaml.

The only truly useful file in this project is [a T4 template which generates a VB source file that equivalent to *.xaml.g.vb files](https://github.com/Nukepayload2/XamarinFormsXamlVB/blob/master/XamlVBCodeBehindGeneratorTest/XamlVBCodeBehindGeneratorTest/GeneratedForXaml.tt).

The custom tool which is named "MSBuild:UpdateDesignTimeXaml" is unable to generate .xaml.g.vb and .xaml.g.i.vb files.
It blocks the way we use Xamarin.Forms with Xaml in Visual Basic .NET Standard class libraries.
That's why I'm working on a T4 template that generates those missing codes.

中文版介绍在英文版后面

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

# 简介
支持 Visual Basic 在 Xamarin.Forms 用 Xaml。

我们的目标是让您同时使用 Xamarin.Forms, Visual Basic 和 Xaml 开发跨平台应用。

这个项目真正有用的文件是 [一个生成与 .xaml.g.vb 等效代码文件的 T4 模板](https://github.com/Nukepayload2/XamarinFormsXamlVB/blob/master/XamlVBCodeBehindGeneratorTest/XamlVBCodeBehindGeneratorTest/GeneratedForXaml.tt).

名为 "MSBuild:UpdateDesignTimeXaml" 的自定义工具不能生成 .xaml.g.vb 和 .xaml.g.i.vb 文件。
这会阻碍我们在 Visual Basic .NET Standard 类库使用 Xamarin.Forms 的 Xaml 。
这就是为什么我在写一个 T4 代码生成器产生那些缺失的文件。

## 怎么用
- 克隆这个仓库
- 用 Visual Studio (>= 15.5.2) 打开
- 从 XamlVBCodeBehindGeneratorTest.vbproj 创建项目模板
- 文件 -> 新建工程 -> C# -> Cross-platform -> Cross platform App -> 选择 .NET Standard 而不是 Shared Project -> Create
- 复制那个 C# .NET Standard 项目的名称，将它排除在解决方案外，然后把它挪走
- 创建一个同名的 VB .NET Standard 项目
- 每个平台特定的项目要引用那个 VB 项目
- 修改 .xaml 文件后要运行 T4 模板

## 依赖项
- Microsoft Visual Studio (>= 15.5.2)
- Visual Studio 的 Xamarin 和 跨平台开发工作负载
- Windows 10 (>= 10.0.16299.0)

## 已知问题
- Xaml 预编译不受支持。
- Xamarin.Forms UI 程序集不能简化或链接。
- 所有带 x:Name 的元素会产生相应的 `WithEvent` 成员。
- XML 命名空间尚未完全支持，所有控件都没有加命名空间修饰。

## 贡献
- 我们需要帮助来改进英文内容和修复 Bug。
- 我们欢迎反馈。请通过 Issues 告诉我们哪里或者怎样改进。