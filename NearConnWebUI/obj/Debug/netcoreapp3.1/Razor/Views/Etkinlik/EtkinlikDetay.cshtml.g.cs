#pragma checksum "C:\Users\ademc\Desktop\NearConn\NearConnWebUI\Views\Etkinlik\EtkinlikDetay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "405796578490df55705377fcd97e77e5730e14b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Etkinlik_EtkinlikDetay), @"mvc.1.0.view", @"/Views/Etkinlik/EtkinlikDetay.cshtml")]
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
#line 1 "C:\Users\ademc\Desktop\NearConn\NearConnWebUI\Views\_ViewImports.cshtml"
using NearConnWebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ademc\Desktop\NearConn\NearConnWebUI\Views\_ViewImports.cshtml"
using NearConnWebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ademc\Desktop\NearConn\NearConnWebUI\Views\_ViewImports.cshtml"
using NearConnEL;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"405796578490df55705377fcd97e77e5730e14b5", @"/Views/Etkinlik/EtkinlikDetay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb25bd87aea43900002f45f23593fa65516bf047", @"/Views/_ViewImports.cshtml")]
    public class Views_Etkinlik_EtkinlikDetay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EtkinlikDetayModel>
    {
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
#nullable restore
#line 1 "C:\Users\ademc\Desktop\NearConn\NearConnWebUI\Views\Etkinlik\EtkinlikDetay.cshtml"
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""panel"">
    <header class=""panel-heading"">
        <div class=""panel-actions"">
            <a href=""#"" class=""fa fa-caret-down""></a>
            <a href=""#"" class=""fa fa-times""></a>
        </div>

        <h2 class=""panel-title"">Etkinliğe Katılanlar</h2>
    </header>
    <div class=""panel-body"">
");
#nullable restore
#line 13 "C:\Users\ademc\Desktop\NearConn\NearConnWebUI\Views\Etkinlik\EtkinlikDetay.cshtml"
         foreach (var item in Model.Kullanicilar)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row col-md-3 mt-md\">\r\n                <div class=\"panel panel-default\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "405796578490df55705377fcd97e77e5730e14b54217", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 565, "~/images/", 565, 9, true);
#nullable restore
#line 17 "C:\Users\ademc\Desktop\NearConn\NearConnWebUI\Views\Etkinlik\EtkinlikDetay.cshtml"
AddHtmlAttributeValue("", 574, item.KullaniciResim, 574, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 17 "C:\Users\ademc\Desktop\NearConn\NearConnWebUI\Views\Etkinlik\EtkinlikDetay.cshtml"
AddHtmlAttributeValue("", 601, Model.Etkinlik.EtkinlikAdi, 601, 27, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <div class=\"panel-body col-md-9\">");
#nullable restore
#line 18 "C:\Users\ademc\Desktop\NearConn\NearConnWebUI\Views\Etkinlik\EtkinlikDetay.cshtml"
                                                Write(item.KullaniciAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 18 "C:\Users\ademc\Desktop\NearConn\NearConnWebUI\Views\Etkinlik\EtkinlikDetay.cshtml"
                                                                   Write(item.KullaniciSoyadi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 21 "C:\Users\ademc\Desktop\NearConn\NearConnWebUI\Views\Etkinlik\EtkinlikDetay.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n </section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EtkinlikDetayModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
