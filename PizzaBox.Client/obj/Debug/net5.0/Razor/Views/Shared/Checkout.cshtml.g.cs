#pragma checksum "/home/jasonw/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9c60239d96db739c637c6bbd13c629ce028f4f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Checkout), @"mvc.1.0.view", @"/Views/Shared/Checkout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9c60239d96db739c637c6bbd13c629ce028f4f1", @"/Views/Shared/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8da125136513a4832232f265924f6601a2fd61f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>Thank you for a Order</h2>\n<p>Store: ");
#nullable restore
#line 2 "/home/jasonw/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/Checkout.cshtml"
     Write(ViewBag.Order.Store);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 3 "/home/jasonw/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/Checkout.cshtml"
 foreach (var pizza in ViewBag.Order.Pizzas)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <p>Pizza: ");
#nullable restore
#line 5 "/home/jasonw/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/Checkout.cshtml"
       Write(pizza);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n  <p>Crust: ");
#nullable restore
#line 6 "/home/jasonw/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/Checkout.cshtml"
       Write(pizza.Crust);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n  <p>Size: ");
#nullable restore
#line 7 "/home/jasonw/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/Checkout.cshtml"
      Write(pizza.Size);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n  <p>Toppings:</p>\n  <ul>\n");
#nullable restore
#line 10 "/home/jasonw/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/Checkout.cshtml"
   foreach (var topping in pizza.Toppings)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <li>");
#nullable restore
#line 12 "/home/jasonw/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/Checkout.cshtml"
     Write(topping);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 13 "/home/jasonw/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/Checkout.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </ul>\n");
#nullable restore
#line 15 "/home/jasonw/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/Checkout.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<a href=\"/home\">Home</a>");
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
