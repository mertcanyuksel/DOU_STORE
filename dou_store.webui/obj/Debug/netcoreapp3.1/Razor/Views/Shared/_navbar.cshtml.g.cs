#pragma checksum "D:\dou_store vers1\dou_store.webui\Views\Shared\_navbar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3895a30d4d87159a8ca631a3e6b5b038cf9c1bf9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__navbar), @"mvc.1.0.view", @"/Views/Shared/_navbar.cshtml")]
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
#line 2 "D:\dou_store vers1\dou_store.webui\Views\_ViewImports.cshtml"
using dou_store.webui.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3895a30d4d87159a8ca631a3e6b5b038cf9c1bf9", @"/Views/Shared/_navbar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5489e6ee9cb54605e5111d4fa6561a90c1f3ca0a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__navbar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"	<nav class=""navbar navbar-expand-md navbar-dark bg-dark"">
  <div class=""container"">
    <a class=""navbar-brand d-md-none d-xs-block py-3"" href=""#"">
      <img src=""dou_store.webui\wwwroot\img\1.jpg"" height=""40"" alt=""Company Logo"">
    </a>
    <button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbarNavDropdown"" aria-controls=""navbarNavDropdown"" aria-expanded=""false"" aria-label=""Toggle navigation"">
      <span class=""navbar-toggler-icon""></span>
    </button>
 
    <div class=""collapse navbar-collapse"" id=""navbarNavDropdown"">
      <ul class=""navbar-nav mx-auto"">
        <li class=""nav-item"">
          <a class=""nav-link mx-2 active"" aria-current=""page"" href=""/home"">Home</a>
        </li>
        <li class=""nav-item"">
          <a class=""nav-link mx-2"" href=""/product/list"">Products</a>
        </li>
        <li class=""nav-item"">
          <a class=""nav-link mx-2"" href=""/product/create"">Add Product</a>
        </li>
        <li class=""nav-item"">
      ");
            WriteLiteral("    <a class=\"nav-link mx-2 btn rounded-0 btn-danger\" href=\"#\">Order Online</a>\r\n        </li>\r\n      </ul>\r\n    </div>\r\n  </div>\r\n</nav>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
