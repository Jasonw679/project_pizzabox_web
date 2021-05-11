#pragma checksum "/home/jasonw/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/Order.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3c0b6cd93259051b03531ebefd772af11e2b0df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Order), @"mvc.1.0.view", @"/Views/Shared/Order.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3c0b6cd93259051b03531ebefd772af11e2b0df", @"/Views/Shared/Order.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8da125136513a4832232f265924f6601a2fd61f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Order : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PizzaBox.Client.Models.OrderViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/home"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<legend>Your Order History</legend>\n");
#nullable restore
#line 3 "/home/jasonw/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/Order.cshtml"
 foreach (var item in ViewBag.Orders)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <p>Store: ");
#nullable restore
#line 5 "/home/jasonw/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/Order.cshtml"
       Write(item.Store);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 6 "/home/jasonw/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/Order.cshtml"
   foreach (var pizza in item.Pizzas)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Pizza: ");
#nullable restore
#line 8 "/home/jasonw/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/Order.cshtml"
         Write(pizza);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <p>Crust: ");
#nullable restore
#line 9 "/home/jasonw/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/Order.cshtml"
         Write(pizza.Crust);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <p>Size: ");
#nullable restore
#line 10 "/home/jasonw/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/Order.cshtml"
        Write(pizza.Size);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <p>Toppings:</p>\n    <ul>\n");
#nullable restore
#line 13 "/home/jasonw/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/Order.cshtml"
   foreach (var topping in pizza.Toppings)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 15 "/home/jasonw/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/Order.cshtml"
       Write(topping);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 16 "/home/jasonw/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/Order.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\n");
#nullable restore
#line 18 "/home/jasonw/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/Order.cshtml"
  }

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "/home/jasonw/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/Order.cshtml"
   
}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3c0b6cd93259051b03531ebefd772af11e2b0df6039", async() => {
                WriteLiteral("\n  <fieldset>\n    <input");
                BeginWriteAttribute("id", " id=", 453, "", 480, 1);
#nullable restore
#line 22 "/home/jasonw/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/Order.cshtml"
WriteAttributeValue("", 457, Model.SelectedCustomer, 457, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"SelectedCustomer\"");
                BeginWriteAttribute("value", " value=", 504, "", 534, 1);
#nullable restore
#line 22 "/home/jasonw/revature/project_pizzabox_web/PizzaBox.Client/Views/Shared/Order.cshtml"
WriteAttributeValue("", 511, Model.SelectedCustomer, 511, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden>\n    <input type=\"submit\" value=\"Home\">\n  </fieldset>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PizzaBox.Client.Models.OrderViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
