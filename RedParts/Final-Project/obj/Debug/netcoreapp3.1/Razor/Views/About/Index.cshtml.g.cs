#pragma checksum "C:\Users\ASUS\Desktop\asaproject\RedParts\Final-Project\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "024fb10bf333bea370399916d3ac0b53cbfe1b10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"024fb10bf333bea370399916d3ac0b53cbfe1b10", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0cf4ca5c7ab08cba79a42a0abc9927e646d3c50", @"/Views/_ViewImports.cshtml")]
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AboutVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("team"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<section id=\"about-first\">\r\n\r\n    <div class=\"all-about-first\">\r\n        <div class=\"about-img\">\r\n            <img src=\"assets/media/about-1903x1903 (1).jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 175, "\"", 181, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        </div>
        <div class=""about-box"">
            <div class=""box-head"">
                <h2>About Us</h2>
            </div>
            <div class=""box-main"">
                <p>RedParts is an international company with 30 years of history selling spare parts for cars, trucks and motorcycles. During our work we managed to create a unique service for the sale and delivery of spare parts around the world.</p>
                <span>Ryan Ford, CEO RedParts</span>

                <div class=""box-img"">
                    <img src=""assets/media/signature.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 766, "\"", 772, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                </div>
            </div>
        </div>
    </div>

</section>


<section id=""professional"">
    <div class=""my-second-container"">
        <div class=""all-professional"">
            <div class=""professional-head"">
                <h3>Professional Team</h3>
                <p>
                    Meet this is our professional team.
                </p>
            </div>

            <div class=""professional-main"">
                <div class=""swiper pro-slider"">
                    <div class=""swiper-wrapper"">


");
#nullable restore
#line 42 "C:\Users\ASUS\Desktop\asaproject\RedParts\Final-Project\Views\About\Index.cshtml"
                         foreach (var item in Model.Employees)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"swiper-slide\">\r\n                                <div class=\"pro-img\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "024fb10bf333bea370399916d3ac0b53cbfe1b106094", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1581, "~/Assets/Img/Employee/", 1581, 22, true);
#nullable restore
#line 46 "C:\Users\ASUS\Desktop\asaproject\RedParts\Final-Project\Views\About\Index.cshtml"
AddHtmlAttributeValue("", 1603, item.Image, 1603, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n\r\n                                <div class=\"pro-text\">\r\n                                    <h4>");
#nullable restore
#line 50 "C:\Users\ASUS\Desktop\asaproject\RedParts\Final-Project\Views\About\Index.cshtml"
                                   Write(item.FulLName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                    <p>");
#nullable restore
#line 51 "C:\Users\ASUS\Desktop\asaproject\RedParts\Final-Project\Views\About\Index.cshtml"
                                  Write(item.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 54 "C:\Users\ASUS\Desktop\asaproject\RedParts\Final-Project\Views\About\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AboutVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
