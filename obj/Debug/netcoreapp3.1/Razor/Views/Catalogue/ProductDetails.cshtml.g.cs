#pragma checksum "C:\Users\black\OneDrive\Uni\YR3 S2\COIT12204 Web Site Development\Assignment 2\submission folder\Foenander-Kieren\Views\Catalogue\ProductDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c9cc33433e2e48fa2dceba3d7536d9b1e6b5513"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalogue_ProductDetails), @"mvc.1.0.view", @"/Views/Catalogue/ProductDetails.cshtml")]
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
#line 1 "C:\Users\black\OneDrive\Uni\YR3 S2\COIT12204 Web Site Development\Assignment 2\submission folder\Foenander-Kieren\Views\_ViewImports.cshtml"
using Assignment_1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c9cc33433e2e48fa2dceba3d7536d9b1e6b5513", @"/Views/Catalogue/ProductDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea5583bed5c572ea3970d4ce69e6703d57be1bb4", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalogue_ProductDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"product_image_area\">\r\n    <div class=\"container\">\r\n        <div class=\"row s_product_inner\">\r\n            <div class=\"col-lg-6\">\r\n                <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 328, "\"", 359, 2);
            WriteAttributeValue("", 334, "/img/product/", 334, 13, true);
#nullable restore
#line 12 "C:\Users\black\OneDrive\Uni\YR3 S2\COIT12204 Web Site Development\Assignment 2\submission folder\Foenander-Kieren\Views\Catalogue\ProductDetails.cshtml"
WriteAttributeValue("", 347, Model.Image, 347, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 360, "\"", 366, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n            <div class=\"col-lg-5 offset-lg-1\">\r\n                <div class=\"s_product_text\">\r\n                    <h3>Faded SkyBlu Denim Jeans ");
#nullable restore
#line 16 "C:\Users\black\OneDrive\Uni\YR3 S2\COIT12204 Web Site Development\Assignment 2\submission folder\Foenander-Kieren\Views\Catalogue\ProductDetails.cshtml"
                                            Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <h2>");
#nullable restore
#line 17 "C:\Users\black\OneDrive\Uni\YR3 S2\COIT12204 Web Site Development\Assignment 2\submission folder\Foenander-Kieren\Views\Catalogue\ProductDetails.cshtml"
                   Write(Model.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <ul class=\"list\">\r\n                        <li><a class=\"active\" href=\"#\"><span>Category</span> : ");
#nullable restore
#line 19 "C:\Users\black\OneDrive\Uni\YR3 S2\COIT12204 Web Site Development\Assignment 2\submission folder\Foenander-Kieren\Views\Catalogue\ProductDetails.cshtml"
                                                                          Write(Model.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                    </ul>\r\n                    <p>");
#nullable restore
#line 21 "C:\Users\black\OneDrive\Uni\YR3 S2\COIT12204 Web Site Development\Assignment 2\submission folder\Foenander-Kieren\Views\Catalogue\ProductDetails.cshtml"
                  Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c9cc33433e2e48fa2dceba3d7536d9b1e6b55136380", async() => {
                WriteLiteral("\r\n                        <input type=\"hidden\" name=\"productId\"");
                BeginWriteAttribute("value", " value=\"", 946, "\"", 970, 1);
#nullable restore
#line 23 "C:\Users\black\OneDrive\Uni\YR3 S2\COIT12204 Web Site Development\Assignment 2\submission folder\Foenander-Kieren\Views\Catalogue\ProductDetails.cshtml"
WriteAttributeValue("", 954, Model.ProductID, 954, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                        <div class=""product_count"">
                            <label for=""quantity"">Quantity:</label>

                            <input type=""text"" name=""quantity"" id=""sst"" size=""2"" maxlength=""12"" value=""1"" title=""Quantity:"" class=""input-text qty"">

                            <button onclick=""var result = document.getElementById('sst'); var sst = result.value; if( !isNaN( sst )) result.value++;return false;""
                                    class=""increase items-count"" type=""button"">
                                <i class=""fa fa-angle-up""></i>
                            </button>

                            <button onclick=""var result = document.getElementById('sst'); var sst = result.value; if( !isNaN( sst ) &amp;&amp; sst > 0 ) result.value--;return false;""
                                    class=""reduced items-count"" type=""button"">
                                <i class=""fa fa-angle-down""></i>
                            </button>
                        <");
                WriteLiteral("/div>\r\n\r\n                        <button type=\"submit\" class=\"btn btn-primary\"> Add To Cart </button>\r\n                        <input type=\"hidden\" name=\"returnUrl\" value=\"/Catalogue\" />\r\n\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
