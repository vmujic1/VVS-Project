#pragma checksum "C:\Users\Aida\OneDrive - Faculty of Electrical Engineering Sarajevo\Desktop\Project-Flowershop-\Ayana\Views\Home\AboutUs.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "89fa97b58b9949c614b6c4c30ea0b8a4be92b95ff0ab412e7e5845e129c73fcc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AboutUs), @"mvc.1.0.view", @"/Views/Home/AboutUs.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Aida\OneDrive - Faculty of Electrical Engineering Sarajevo\Desktop\Project-Flowershop-\Ayana\Views\_ViewImports.cshtml"
using Ayana;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Aida\OneDrive - Faculty of Electrical Engineering Sarajevo\Desktop\Project-Flowershop-\Ayana\Views\_ViewImports.cshtml"
using Ayana.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"89fa97b58b9949c614b6c4c30ea0b8a4be92b95ff0ab412e7e5845e129c73fcc", @"/Views/Home/AboutUs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"caa10efeac2221a7a753ce0f7f52a6e4fbec97fb486ec0ee825c6397d351e6e9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_AboutUs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("continue-shopping"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("-webkit-text-fill-color:black;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("﻿﻿\r\n");
#nullable restore
#line 2 "C:\Users\Aida\OneDrive - Faculty of Electrical Engineering Sarajevo\Desktop\Project-Flowershop-\Ayana\Views\Home\AboutUs.cshtml"
  
    ViewData["Title"] = "AboutUs";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .average-rating {
        position: relative;
        appearance: none;
        color: transparent;
        display: inline-block;
        vertical-align: baseline;
        margin-left: 1000px;
    }

        .average-rating::before {
            --percent: calc(");
#nullable restore
#line 17 "C:\Users\Aida\OneDrive - Faculty of Electrical Engineering Sarajevo\Desktop\Project-Flowershop-\Ayana\Views\Home\AboutUs.cshtml"
                       Write(ViewBag.rating);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"/5*100%);
            content: '★★★★★';
            position: absolute;
            top: 0;
            left: 0;
            color: rgba(0,0,0,0.2);
            background: linear-gradient(90deg, gold var(--percent), rgba(0,0,0,0.2) var(--percent));
            -webkit-background-clip: text;
            -webkit-text-fill-color: transparent;
        }

    meter.average-rating {
        transform: scale(3);
    }

    .continue-shopping {
        display: inline-block;
        font-size: medium;
        text-decoration: underline;
        position: relative;
        padding-left: 30px;
        margin-bottom:20px;
        margin-top: 26px;
    }

        .continue-shopping::before {
            content: '\2190';
            position: absolute;
            left: 0;
        }
</style>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89fa97b58b9949c614b6c4c30ea0b8a4be92b95ff0ab412e7e5845e129c73fcc6687", async() => {
                WriteLiteral("Continue shopping");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<div style=""margin-bottom:100px;"">
    <div style=""background-color:#f7ede5; margin-left:-30px; margin-right:-30px; margin-bottom:50px; margin-top:10px; height:300px; font-family:'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;"">
        <br>
        <div style=""display:flex;align-items:center;"">
            <div style=""flex-basis: 60%; margin-left:30px; margin-right:10px;"">
                <p style=""margin-top:-10px; font-size: 30px; font-weight: bold;"">Flowers, plants and gifts make everything so much brighter!</p>
                <br>
                <p style=""margin-top:-10px; margin-right:100px;"">
                    We deliver florist-crafted arrangements, dropship bundles, fresh plants
                    and we are partners with trending gifting brands to ensure everyone gets
                    the gift they will love.
                </p>
            </div>
            <div style=""flex-basis: 40%; text-align: right;align-items:");
            WriteLiteral(@"center;"">
                <img src=""https://img.freepik.com/free-photo/top-view-fresh-flowers-isolated-white-wall_181624-38053.jpg?w=996&t=st=1686335052~exp=1686335652~hmac=52cb992e97c21198ba670b0b984d5795cf3d2b83410221e3a7e0ca6402e8a4d5"" style=""width: auto; height:260px;margin-right:30px;"">
            </div>
        </div>
    </div>

    <div style=""background-color:#e9f0d7; margin-left:30px; width:200px; height:200px; margin-bottom:140px;"">
        <br>
        <p style=""text-align:center; margin-top:20px; font-weight:600;"">greener outside & in</p>
        <p style=""text-align:left; margin-top:20px; font-size:small; padding:10px"">
            We are commited to
            sustainable pratice
            beginning at the farms and
            how it arrives at your door
        </p>
    </div>
    <div style=""background-color:#d8e5f1; margin-left:430px; width:200px; height:200px;margin-top:-340px;"">
        <br>
        <p style=""text-align:center; margin-top:20px;font-weight:600; "">fres");
            WriteLiteral(@"hness guarantee</p>
        <p style=""text-align:left; margin-top:20px; font-size:small;padding:10px"">
            Our priority is for you to
            get the most beautiful
            flowers, so we offer you
            a 7-day freshness
            guarantee
        </p>
    </div>
    <div style=""background-color:#e2ddeb; margin-left:840px; width:200px; height:200px; margin-top:-200px;"">
        <br>
        <p style=""text-align:center; margin-top:20px; font-weight:600;"">flower power</p>
        <p style=""text-align:left; margin-top:20px; font-size:small;padding:10px"">
            Experience the power  of
            bold colors in our
            collections of fresh blooms
        </p>
    </div>
    <div style=""background-color:#ecebeb; margin-left:-30px; margin-right:-30px; margin-bottom:50px; margin-top:50px; height:200px; font-family:'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;"">
        <div style=""display: flex; j");
            WriteLiteral(@"ustify-content: space-between;"">
            <div>
                <br>
                <p style=""margin-top:-10px; margin-left:30px; "">
                    Customer happiness is number one for us!
                </p>
                <br>

                <p style=""margin-top:-10px; margin-left:30px; margin-right:10px;"">
                    Here at Ayana, we take great pride with every bouquet we create. From our farms to your doorstep.
                    Every step we take has the health of our planet, the quality of our flowers and our customers happiness at heart.
                </p>
            </div>

            <br>
            <p style=""margin-top:40px; margin-right:50px; font-size:26px; font-weight:bold;"">
                OUR OVERALL RATING:
            </p>
            <br>
        </div>
        <meter class=""average-rating"" min=""0"" max=""5""");
            BeginWriteAttribute("value", " value=", 5273, "", 5295, 1);
#nullable restore
#line 119 "C:\Users\Aida\OneDrive - Faculty of Electrical Engineering Sarajevo\Desktop\Project-Flowershop-\Ayana\Views\Home\AboutUs.cshtml"
WriteAttributeValue("", 5280, ViewBag.rating, 5280, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 5295, "\"", 5333, 5);
#nullable restore
#line 119 "C:\Users\Aida\OneDrive - Faculty of Electrical Engineering Sarajevo\Desktop\Project-Flowershop-\Ayana\Views\Home\AboutUs.cshtml"
WriteAttributeValue("", 5303, ViewBag.rating, 5303, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 5318, "out", 5319, 4, true);
            WriteAttributeValue(" ", 5322, "of", 5323, 3, true);
            WriteAttributeValue(" ", 5325, "5", 5326, 2, true);
            WriteAttributeValue(" ", 5327, "stars", 5328, 6, true);
            EndWriteAttribute();
            WriteLiteral("></meter>\r\n\r\n    </div>\r\n    <br>\r\n    <br>\r\n    <br>\r\n    <div style=\"height:20px;\"></div>\r\n</div>\r\n\r\n");
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
