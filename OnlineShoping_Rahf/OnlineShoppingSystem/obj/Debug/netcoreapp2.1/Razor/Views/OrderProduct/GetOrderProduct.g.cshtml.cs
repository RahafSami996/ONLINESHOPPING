#pragma checksum "C:\Users\rahaf\Source\Workspaces\OnlineShoping_Rahf\OnlineShoppingSystem\Views\OrderProduct\GetOrderProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84b823dc79c230611d5bc00941091eea9e53eaa2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrderProduct_GetOrderProduct), @"mvc.1.0.view", @"/Views/OrderProduct/GetOrderProduct.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/OrderProduct/GetOrderProduct.cshtml", typeof(AspNetCore.Views_OrderProduct_GetOrderProduct))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84b823dc79c230611d5bc00941091eea9e53eaa2", @"/Views/OrderProduct/GetOrderProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_OrderProduct_GetOrderProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OnlineShoppingSystem.Models.DTOOnlineShopping.CartDTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validate/jquery.validate.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/twitter-bootstrap/js/bootstrap.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\rahaf\Source\Workspaces\OnlineShoping_Rahf\OnlineShoppingSystem\Views\OrderProduct\GetOrderProduct.cshtml"
  
    ViewData["Title"] = "GetOrderProduct";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(166, 34, true);
            WriteLiteral("\r\n<h2>Get Order Product</h2>\r\n\r\n\r\n");
            EndContext();
#line 41 "C:\Users\rahaf\Source\Workspaces\OnlineShoping_Rahf\OnlineShoppingSystem\Views\OrderProduct\GetOrderProduct.cshtml"
             if (Model != null)
            {

#line default
#line hidden
            BeginContext(1430, 82, true);
            WriteLiteral("                <div class=\"form-group \">\r\n                    <div class=\"row\">\r\n");
            EndContext();
#line 45 "C:\Users\rahaf\Source\Workspaces\OnlineShoping_Rahf\OnlineShoppingSystem\Views\OrderProduct\GetOrderProduct.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(1593, 276, true);
            WriteLiteral(@"                            <div class=""col-md-4"" style=""margin-bottom: 83px;margin-top: 50px"">
                                <div class=""card"">

                                    <div class=""card-header"">
                                        <input type=""checkbox""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1869, "\"", 1885, 1);
#line 51 "C:\Users\rahaf\Source\Workspaces\OnlineShoping_Rahf\OnlineShoppingSystem\Views\OrderProduct\GetOrderProduct.cshtml"
WriteAttributeValue("", 1877, item.Id, 1877, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1886, 63, true);
            WriteLiteral(" class=\"check\" />\r\n                                        <h3>");
            EndContext();
            BeginContext(1950, 46, false);
#line 52 "C:\Users\rahaf\Source\Workspaces\OnlineShoping_Rahf\OnlineShoppingSystem\Views\OrderProduct\GetOrderProduct.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(1996, 51, true);
            WriteLiteral("</h3>\r\n                                    </div>\r\n");
            EndContext();
#line 54 "C:\Users\rahaf\Source\Workspaces\OnlineShoping_Rahf\OnlineShoppingSystem\Views\OrderProduct\GetOrderProduct.cshtml"
                                     if (item.Images != null)
                                    {
                                        

#line default
#line hidden
#line 56 "C:\Users\rahaf\Source\Workspaces\OnlineShoping_Rahf\OnlineShoppingSystem\Views\OrderProduct\GetOrderProduct.cshtml"
                                         foreach (var item2 in item.Images)
                                        {

#line default
#line hidden
            BeginContext(2269, 48, true);
            WriteLiteral("                                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2317, "\"", 2391, 4);
            WriteAttributeValue("", 2323, "data:\'", 2323, 6, true);
#line 58 "C:\Users\rahaf\Source\Workspaces\OnlineShoping_Rahf\OnlineShoppingSystem\Views\OrderProduct\GetOrderProduct.cshtml"
WriteAttributeValue("", 2329, item2.ContentType, 2329, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 2347, "\';base64,", 2347, 9, true);
#line 58 "C:\Users\rahaf\Source\Workspaces\OnlineShoping_Rahf\OnlineShoppingSystem\Views\OrderProduct\GetOrderProduct.cshtml"
WriteAttributeValue("", 2356, Convert.ToBase64String(item2.Data), 2356, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 2392, "\"", 2428, 3);
            WriteAttributeValue("", 2402, "imagebtn(", 2402, 9, true);
#line 58 "C:\Users\rahaf\Source\Workspaces\OnlineShoping_Rahf\OnlineShoppingSystem\Views\OrderProduct\GetOrderProduct.cshtml"
WriteAttributeValue("", 2411, item2.ProductId, 2411, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 2427, ")", 2427, 1, true);
            EndWriteAttribute();
            BeginContext(2429, 59, true);
            WriteLiteral(" class=\"card-img-top\" style=\"width:348px;height:348px\" />\r\n");
            EndContext();
#line 59 "C:\Users\rahaf\Source\Workspaces\OnlineShoping_Rahf\OnlineShoppingSystem\Views\OrderProduct\GetOrderProduct.cshtml"

                                        }

#line default
#line hidden
#line 60 "C:\Users\rahaf\Source\Workspaces\OnlineShoping_Rahf\OnlineShoppingSystem\Views\OrderProduct\GetOrderProduct.cshtml"
                                         
                                    }

#line default
#line hidden
            BeginContext(2572, 149, true);
            WriteLiteral("                                    <div class=\"card-header form-group\">\r\n                                        <h3 style=\"background:red\">Price:$ ");
            EndContext();
            BeginContext(2722, 40, false);
#line 63 "C:\Users\rahaf\Source\Workspaces\OnlineShoping_Rahf\OnlineShoppingSystem\Views\OrderProduct\GetOrderProduct.cshtml"
                                                                      Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(2762, 47, true);
            WriteLiteral("</h3>\r\n                                        ");
            EndContext();
            BeginContext(2809, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7814da01db804fb7b86793aa81a8166e", async() => {
                BeginContext(2908, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 64 "C:\Users\rahaf\Source\Workspaces\OnlineShoping_Rahf\OnlineShoppingSystem\Views\OrderProduct\GetOrderProduct.cshtml"
                                                                                              WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2918, 122, true);
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
            EndContext();
#line 68 "C:\Users\rahaf\Source\Workspaces\OnlineShoping_Rahf\OnlineShoppingSystem\Views\OrderProduct\GetOrderProduct.cshtml"

                        }

#line default
#line hidden
            BeginContext(3069, 56, true);
            WriteLiteral("                    </div>\r\n\r\n\r\n                </div>\r\n");
            EndContext();
#line 74 "C:\Users\rahaf\Source\Workspaces\OnlineShoping_Rahf\OnlineShoppingSystem\Views\OrderProduct\GetOrderProduct.cshtml"
            }
            

#line default
#line hidden
            BeginContext(3762, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd1134322bef43518a08ce3cad140be0", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3808, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3810, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35d5ac2fbf4b456681c5e9da6034fa65", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3874, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3876, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab4e412f5b254f78bb7dbe608d5e8a87", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3939, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(4547, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OnlineShoppingSystem.Models.DTOOnlineShopping.CartDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
