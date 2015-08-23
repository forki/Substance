namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Substance")>]
[<assembly: AssemblyProductAttribute("Substance")>]
[<assembly: AssemblyDescriptionAttribute("...")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"
