#pragma checksum "M:\#1 PORTAFOLIO DE PROYECTOS\ASP.NET PROJECTS\MVC\MVC\Views\Shared\ObjetoEscuelaSimple.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd243fa340907a3fd1267c2d931dc7bc1819aee3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ObjetoEscuelaSimple), @"mvc.1.0.view", @"/Views/Shared/ObjetoEscuelaSimple.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "M:\#1 PORTAFOLIO DE PROYECTOS\ASP.NET PROJECTS\MVC\MVC\Views\_ViewImports.cshtml"
using MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "M:\#1 PORTAFOLIO DE PROYECTOS\ASP.NET PROJECTS\MVC\MVC\Views\_ViewImports.cshtml"
using MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd243fa340907a3fd1267c2d931dc7bc1819aee3", @"/Views/Shared/ObjetoEscuelaSimple.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d7a8f56340c239c091cff637a00cc2fdf252300", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ObjetoEscuelaSimple : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ObjetoEscuelaBase>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "M:\#1 PORTAFOLIO DE PROYECTOS\ASP.NET PROJECTS\MVC\MVC\Views\Shared\ObjetoEscuelaSimple.cshtml"
  
    ViewData["Title"] = "Información Asignaturas";
    Layout = "Simple";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<p>\r\n    Id: ");
#nullable restore
#line 11 "M:\#1 PORTAFOLIO DE PROYECTOS\ASP.NET PROJECTS\MVC\MVC\Views\Shared\ObjetoEscuelaSimple.cshtml"
   Write(Model.UniqueId);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n    Nombre: ");
#nullable restore
#line 12 "M:\#1 PORTAFOLIO DE PROYECTOS\ASP.NET PROJECTS\MVC\MVC\Views\Shared\ObjetoEscuelaSimple.cshtml"
       Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n</p>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ObjetoEscuelaBase> Html { get; private set; }
    }
}
#pragma warning restore 1591
