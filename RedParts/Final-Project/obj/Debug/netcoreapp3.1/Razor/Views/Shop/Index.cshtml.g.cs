#pragma checksum "C:\Users\ASUS\Desktop\asaproject\RedParts\Final-Project\Views\Shop\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "730ebe4199c5035b49638b78ace64c5b2a0b948b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Index), @"mvc.1.0.view", @"/Views/Shop/Index.cshtml")]
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
#line 1 "C:\Users\ASUS\Desktop\asaproject\RedParts\Final-Project\Views\_ViewImports.cshtml"
using Final_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\asaproject\RedParts\Final-Project\Views\_ViewImports.cshtml"
using Final_Project.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\asaproject\RedParts\Final-Project\Views\_ViewImports.cshtml"
using Final_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ASUS\Desktop\asaproject\RedParts\Final-Project\Views\_ViewImports.cshtml"
using Final_Project.ViewModels.Page;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ASUS\Desktop\asaproject\RedParts\Final-Project\Views\_ViewImports.cshtml"
using Final_Project.ViewModels.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"730ebe4199c5035b49638b78ace64c5b2a0b948b", @"/Views/Shop/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0cf4ca5c7ab08cba79a42a0abc9927e646d3c50", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Paginate<ShopVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("product"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "shopdetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<section id=""shop-page"">
    <div class=""container"">
        <div class=""all-shop-page"">
            <div class=""shop-head"">
                <h2> Products</h2>
            </div>

            <div class=""shop-page-main"">
                <div class=""left-shop-page"">
                    <div class=""bordered-head"">
                        <h3>Filters</h3>
                    </div>

                    <div class=""left-main"">
                        <div class=""categories-box filter-box"">
                            <div class=""box-head"">
                                <button>
                                    <h5>Brand</h5>
                                    <i class=""fa-solid fa-chevron-up up-ico""></i>
                                </button>
                            </div>


                            <div class=""box-main"">
                                <ul>

");
#nullable restore
#line 29 "C:\Users\ASUS\Desktop\asaproject\RedParts\Final-Project\Views\Shop\Index.cshtml"
                                     foreach (var item in Model.Datas)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\ASUS\Desktop\asaproject\RedParts\Final-Project\Views\Shop\Index.cshtml"
                                         foreach (var brand in item.Brands)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "730ebe4199c5035b49638b78ace64c5b2a0b948b6998", async() => {
#nullable restore
#line 33 "C:\Users\ASUS\Desktop\asaproject\RedParts\Final-Project\Views\Shop\Index.cshtml"
                                                                                                                     Write(Html.Raw(brand.Name));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-brandId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\ASUS\Desktop\asaproject\RedParts\Final-Project\Views\Shop\Index.cshtml"
                                                                                                   WriteLiteral(brand.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["brandId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-brandId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["brandId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 34 "C:\Users\ASUS\Desktop\asaproject\RedParts\Final-Project\Views\Shop\Index.cshtml"

                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\ASUS\Desktop\asaproject\RedParts\Final-Project\Views\Shop\Index.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </ul>
                            </div>
                        </div>

                        <div class=""categories-box filter-box"">
                            <div class=""box-head"">
                                <button>
                                    <h5>Category</h5>
                                    <i class=""fa-solid fa-chevron-up up-ico""></i>
                                </button>
                            </div>


                            <div class=""box-main"">
                                <ul>

");
#nullable restore
#line 53 "C:\Users\ASUS\Desktop\asaproject\RedParts\Final-Project\Views\Shop\Index.cshtml"
                                     foreach (var item in Model.Datas)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\ASUS\Desktop\asaproject\RedParts\Final-Project\Views\Shop\Index.cshtml"
                                         foreach (var category in item.ProductCategories)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "730ebe4199c5035b49638b78ace64c5b2a0b948b11464", async() => {
#nullable restore
#line 57 "C:\Users\ASUS\Desktop\asaproject\RedParts\Final-Project\Views\Shop\Index.cshtml"
                                                                                                                      Write(Html.Raw(category.Name));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-catId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "C:\Users\ASUS\Desktop\asaproject\RedParts\Final-Project\Views\Shop\Index.cshtml"
                                                                                                 WriteLiteral(category.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["catId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-catId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["catId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 58 "C:\Users\ASUS\Desktop\asaproject\RedParts\Final-Project\Views\Shop\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\ASUS\Desktop\asaproject\RedParts\Final-Project\Views\Shop\Index.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </ul>
                            </div>
                        </div>

                        <div class=""categories-box filter-box"">
                            <div class=""box-head"">
                                <button>
                                    <h5>Made In</h5>
                                    <i class=""fa-solid fa-chevron-up up-ico""></i>
                                </button>
                            </div>


                            <div class=""box-main"">
                                <ul>
");
#nullable restore
#line 76 "C:\Users\ASUS\Desktop\asaproject\RedParts\Final-Project\Views\Shop\Index.cshtml"
                                     foreach (var item in Model.Datas)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "C:\Users\ASUS\Desktop\asaproject\RedParts\Final-Project\Views\Shop\Index.cshtml"
                                         foreach (var country in item.Countries)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "730ebe4199c5035b49638b78ace64c5b2a0b948b15916", async() => {
#nullable restore
#line 80 "C:\Users\ASUS\Desktop\asaproject\RedParts\Final-Project\Views\Shop\Index.cshtml"
                                                                                                                    Write(Html.Raw(country.Name));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-caId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 80 "C:\Users\ASUS\Desktop\asaproject\RedParts\Final-Project\Views\Shop\Index.cshtml"
                                                                                                WriteLiteral(country.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["caId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-caId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["caId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 81 "C:\Users\ASUS\Desktop\asaproject\RedParts\Final-Project\Views\Shop\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "C:\Users\ASUS\Desktop\asaproject\RedParts\Final-Project\Views\Shop\Index.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </ul>
                            </div>
                        </div>


                        <div class=""filter-button"">
                            <button type=""button"" class=""filter"">
                                Filter
                            </button>
                            <button type=""button"" class=""reset"">
                                Reset
                            </button>

                        </div>
                    </div>
                </div>

                <div class=""right-shop-page"">
                    <div class=""right-main"">

");
#nullable restore
#line 103 "C:\Users\ASUS\Desktop\asaproject\RedParts\Final-Project\Views\Shop\Index.cshtml"
                         foreach (var item in Model.Datas)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 105 "C:\Users\ASUS\Desktop\asaproject\RedParts\Final-Project\Views\Shop\Index.cshtml"
                             foreach (var product in item.Products)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""shop-box"">

                                    <div class=""heart-ico"">
                                        <button><i class=""fa-solid fa-heart""></i></button>
                                    </div>
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "730ebe4199c5035b49638b78ace64c5b2a0b948b20613", async() => {
                WriteLiteral("\r\n                                        <div class=\"box-img\">\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "730ebe4199c5035b49638b78ace64c5b2a0b948b20980", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 4836, "~/Assets/Img/Product/", 4836, 21, true);
#nullable restore
#line 114 "C:\Users\ASUS\Desktop\asaproject\RedParts\Final-Project\Views\Shop\Index.cshtml"
AddHtmlAttributeValue("", 4857, product.ProductImage.FirstOrDefault(m=>m.IsMain)?.Image, 4857, 56, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        </div>\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 112 "C:\Users\ASUS\Desktop\asaproject\RedParts\Final-Project\Views\Shop\Index.cshtml"
                                                                                        WriteLiteral(product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                    <div class=\"box-text\">\r\n                                        <div class=\"product-title\">\r\n                                            <a href=\"shopdetail.html\">");
#nullable restore
#line 120 "C:\Users\ASUS\Desktop\asaproject\RedParts\Final-Project\Views\Shop\Index.cshtml"
                                                                 Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                        </div>

                                        <div class=""product-rating"">
                                            <span>☆</span><span>☆</span><span>☆</span><span>☆</span><span>☆</span>
                                        </div>

                                        <div class=""product-bottom"">
                                            <div class=""product-price"">
                                                <p>$");
#nullable restore
#line 129 "C:\Users\ASUS\Desktop\asaproject\RedParts\Final-Project\Views\Shop\Index.cshtml"
                                               Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                            </div>

                                            <div class=""product-cart"">
                                                <a href=""card.html"">
                                                    <i class=""fa-solid fa-cart-shopping""></i>
                                                </a>
                                            </div>
                                        </div>
                                    </div>
                                </div>
");
#nullable restore
#line 140 "C:\Users\ASUS\Desktop\asaproject\RedParts\Final-Project\Views\Shop\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 140 "C:\Users\ASUS\Desktop\asaproject\RedParts\Final-Project\Views\Shop\Index.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Paginate<ShopVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591