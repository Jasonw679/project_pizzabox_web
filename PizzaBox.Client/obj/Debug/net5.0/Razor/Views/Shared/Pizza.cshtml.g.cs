#pragma checksum "/home/jasonw/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/Pizza.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a94f93cd6dadb01b2d950aa7f552093481e91b85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Pizza), @"mvc.1.0.view", @"/Views/Shared/Pizza.cshtml")]
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
#line 1 "/home/jasonw/revature/project_pizzabox_web/PizzaBox.Client/Views/_ViewImports.cshtml"
using PizzaBox.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/jasonw/revature/project_pizzabox_web/PizzaBox.Client/Views/_ViewImports.cshtml"
using PizzaBox.Client.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a94f93cd6dadb01b2d950aa7f552093481e91b85", @"/Views/Shared/Pizza.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8da125136513a4832232f265924f6601a2fd61f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Pizza : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<legend>You Selected ");
#nullable restore
#line 1 "/home/jasonw/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/Pizza.cshtml"
                Write(ViewBag.Order.Store);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <a href=\"/home\"");
            BeginWriteAttribute("onclick", " onclick=\"", 57, "\"", 89, 3);
#nullable restore
#line 1 "/home/jasonw/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/Pizza.cshtml"
WriteAttributeValue("", 67, ViewBag.Store, 67, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 81, "==", 82, 3, true);
            WriteAttributeValue(" ", 84, "null", 85, 5, true);
            EndWriteAttribute();
            WriteLiteral(">Change Store</a></legend>\n<legend>Choose a Pizza</legend>\n<div class=\"row\">\n  <div class=\"col\">\n    <p>Create your own Pizza</p>\n    <button onclick=\"window.location.href=\'/order\';\">Create Pizza</button>\n  </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591