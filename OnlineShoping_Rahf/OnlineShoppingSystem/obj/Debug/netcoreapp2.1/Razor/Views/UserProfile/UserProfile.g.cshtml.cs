#pragma checksum "C:\Users\rahaf\Source\Workspaces\OnlineShoping_Rahf\OnlineShoppingSystem\Views\UserProfile\UserProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4633932c602560ab3a6324f3abc48b74e0bb1fbe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserProfile_UserProfile), @"mvc.1.0.view", @"/Views/UserProfile/UserProfile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserProfile/UserProfile.cshtml", typeof(AspNetCore.Views_UserProfile_UserProfile))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4633932c602560ab3a6324f3abc48b74e0bb1fbe", @"/Views/UserProfile/UserProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_UserProfile_UserProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineShoppingSystem.Models.DTOOnlineShopping.EditProfileSellerDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditProfileUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "UserProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditCardPayment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteCard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(75, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\rahaf\Source\Workspaces\OnlineShoping_Rahf\OnlineShoppingSystem\Views\UserProfile\UserProfile.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewBag.Title = "Seller Profile";

#line default
#line hidden
            BeginContext(172, 79, true);
            WriteLiteral("\r\n<h1 style=\"text-align: center\">User Profile</h1>\r\n\r\n<div class=\"card mb-3\">\r\n");
            EndContext();
#line 15 "C:\Users\rahaf\Source\Workspaces\OnlineShoping_Rahf\OnlineShoppingSystem\Views\UserProfile\UserProfile.cshtml"
     if (Model.Image != null)
    {

#line default
#line hidden
            BeginContext(362, 12, true);
            WriteLiteral("        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 374, "\"", 438, 2);
            WriteAttributeValue("", 380, "data:image/jpg;base64,", 380, 22, true);
#line 17 "C:\Users\rahaf\Source\Workspaces\OnlineShoping_Rahf\OnlineShoppingSystem\Views\UserProfile\UserProfile.cshtml"
WriteAttributeValue("", 402, Convert.ToBase64String(Model.Image), 402, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(439, 30, true);
            WriteLiteral(" width=\"150\" height=\"100\" />\r\n");
            EndContext();
#line 18 "C:\Users\rahaf\Source\Workspaces\OnlineShoping_Rahf\OnlineShoppingSystem\Views\UserProfile\UserProfile.cshtml"

    }

#line default
#line hidden
            BeginContext(478, 120, true);
            WriteLiteral("\r\n</div>\r\n<div class=\"card-body\">\r\n    User Name:   <h5 class=\"card-title\" style=\"margin-left: 100px;margin-top: -22px\">");
            EndContext();
            BeginContext(599, 14, false);
#line 23 "C:\Users\rahaf\Source\Workspaces\OnlineShoping_Rahf\OnlineShoppingSystem\Views\UserProfile\UserProfile.cshtml"
                                                                                Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(613, 100, true);
            WriteLiteral("</h5>\r\n    <br />\r\n    Phone:   <h5 class=\"card-title\" style=\"margin-left: 100px;margin-top: -22px\">");
            EndContext();
            BeginContext(714, 11, false);
#line 25 "C:\Users\rahaf\Source\Workspaces\OnlineShoping_Rahf\OnlineShoppingSystem\Views\UserProfile\UserProfile.cshtml"
                                                                            Write(Model.phone);

#line default
#line hidden
            EndContext();
            BeginContext(725, 100, true);
            WriteLiteral("</h5>\r\n    <br />\r\n    Email:   <h5 class=\"card-title\" style=\"margin-left: 100px;margin-top: -22px\">");
            EndContext();
            BeginContext(826, 11, false);
#line 27 "C:\Users\rahaf\Source\Workspaces\OnlineShoping_Rahf\OnlineShoppingSystem\Views\UserProfile\UserProfile.cshtml"
                                                                            Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(837, 46, true);
            WriteLiteral("</h5>\r\n</div>\r\n<div class=\"card-footer\">\r\n    ");
            EndContext();
            BeginContext(883, 126, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab1ce8f882ed469d97e04d5a8d6e5cd5", async() => {
                BeginContext(1001, 4, true);
                WriteLiteral("Edit");
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
#line 31 "C:\Users\rahaf\Source\Workspaces\OnlineShoping_Rahf\OnlineShoppingSystem\Views\UserProfile\UserProfile.cshtml"
         WriteLiteral(Model.Id);

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
            BeginContext(1009, 115, true);
            WriteLiteral("\r\n\r\n</div>\r\n<br />\r\n<br />\r\n<h1 style=\"text-align: center\">Information Card Payment</h1>\r\n<div class=\"card-body\">\r\n");
            EndContext();
#line 38 "C:\Users\rahaf\Source\Workspaces\OnlineShoping_Rahf\OnlineShoppingSystem\Views\UserProfile\UserProfile.cshtml"
     if (Model.CardPayment != null)
    {
        

#line default
#line hidden
#line 40 "C:\Users\rahaf\Source\Workspaces\OnlineShoping_Rahf\OnlineShoppingSystem\Views\UserProfile\UserProfile.cshtml"
         foreach (var item in Model.CardPayment)
        {

#line default
#line hidden
            BeginContext(1229, 135, true);
            WriteLiteral("            <div class=\"form-group\">\r\n                Expire Date: <h5 class=\"card-title\" style=\"margin-left: 100px;margin-top: -22px\">");
            EndContext();
            BeginContext(1365, 15, false);
#line 43 "C:\Users\rahaf\Source\Workspaces\OnlineShoping_Rahf\OnlineShoppingSystem\Views\UserProfile\UserProfile.cshtml"
                                                                                            Write(item.ExpireDate);

#line default
#line hidden
            EndContext();
            BeginContext(1380, 111, true);
            WriteLiteral("</h5>\r\n                Total Credit Amount:<h5 class=\"card-title\" style=\"margin-left: 155px;margin-top: -22px\">");
            EndContext();
            BeginContext(1492, 22, false);
#line 44 "C:\Users\rahaf\Source\Workspaces\OnlineShoping_Rahf\OnlineShoppingSystem\Views\UserProfile\UserProfile.cshtml"
                                                                                                   Write(item.TotalCreditAmount);

#line default
#line hidden
            EndContext();
            BeginContext(1514, 108, true);
            WriteLiteral("</h5>\r\n                Availabel Credit:<h5 class=\"card-title\" style=\"margin-left: 155px;margin-top: -22px\">");
            EndContext();
            BeginContext(1623, 20, false);
#line 45 "C:\Users\rahaf\Source\Workspaces\OnlineShoping_Rahf\OnlineShoppingSystem\Views\UserProfile\UserProfile.cshtml"
                                                                                                Write(item.AvailableCredit);

#line default
#line hidden
            EndContext();
            BeginContext(1643, 108, true);
            WriteLiteral("</h5>\r\n                Celling Of Order:<h5 class=\"card-title\" style=\"margin-left: 155px;margin-top: -22px\">");
            EndContext();
            BeginContext(1752, 19, false);
#line 46 "C:\Users\rahaf\Source\Workspaces\OnlineShoping_Rahf\OnlineShoppingSystem\Views\UserProfile\UserProfile.cshtml"
                                                                                                Write(item.CellingOfOrder);

#line default
#line hidden
            EndContext();
            BeginContext(1771, 27, true);
            WriteLiteral("</h5>\r\n            </div>\r\n");
            EndContext();
            BeginContext(1800, 55, true);
            WriteLiteral("            <div class=\"card-footer\">\r\n                ");
            EndContext();
            BeginContext(1855, 137, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "706123716d474f7bb2450985d60a681a", async() => {
                BeginContext(1984, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 51 "C:\Users\rahaf\Source\Workspaces\OnlineShoping_Rahf\OnlineShoppingSystem\Views\UserProfile\UserProfile.cshtml"
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
            BeginContext(1992, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(2010, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "758142d881e946c6b3683b431a5281e3", async() => {
                BeginContext(2084, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "C:\Users\rahaf\Source\Workspaces\OnlineShoping_Rahf\OnlineShoppingSystem\Views\UserProfile\UserProfile.cshtml"
                                             WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2094, 26, true);
            WriteLiteral("\r\n\r\n\r\n            </div>\r\n");
            EndContext();
#line 56 "C:\Users\rahaf\Source\Workspaces\OnlineShoping_Rahf\OnlineShoppingSystem\Views\UserProfile\UserProfile.cshtml"

        }

#line default
#line hidden
#line 57 "C:\Users\rahaf\Source\Workspaces\OnlineShoping_Rahf\OnlineShoppingSystem\Views\UserProfile\UserProfile.cshtml"
         
    }

#line default
#line hidden
            BeginContext(2140, 14, true);
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineShoppingSystem.Models.DTOOnlineShopping.EditProfileSellerDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
