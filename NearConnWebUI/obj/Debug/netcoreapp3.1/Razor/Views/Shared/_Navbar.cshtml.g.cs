#pragma checksum "C:\Users\ademc\Desktop\NearConn\NearConnWebUI\Views\Shared\_Navbar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee3a49d884f0b41ec7e54404e194c64c2af7749a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Navbar), @"mvc.1.0.view", @"/Views/Shared/_Navbar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee3a49d884f0b41ec7e54404e194c64c2af7749a", @"/Views/Shared/_Navbar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb25bd87aea43900002f45f23593fa65516bf047", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Navbar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<aside id=""sidebar-left"" class=""sidebar-left"">

    <div class=""sidebar-header"">
        <div class=""sidebar-title"">
            Menü
        </div>
        <div class=""sidebar-toggle hidden-xs"" data-toggle-class=""sidebar-left-collapsed"" data-target=""html"" data-fire-event=""sidebar-left-toggle"">
            <i class=""fa fa-bars"" aria-label=""Toggle sidebar""></i>
        </div>
    </div>

    <div class=""nano has-scrollbar"">
        <div class=""nano-content"" tabindex=""0"" style=""right: -17px;"">
            <nav id=""menu"" class=""nav-main"" role=""navigation"">
                <ul class=""nav nav-main"">
                    <li class=""nav-active"">
                        <a>
                            <i class=""fa fa-home"" aria-hidden=""true""></i>
                            <span>Anasayfa</span>
                        </a>
                    </li>

                    <li class=""nav-parent"">
                        <a>
                            <i class=""fa fa-table"" aria-hidden=""true""></i>");
            WriteLiteral(@"
                            <span>Etkinlik</span>
                        </a>
                        <ul class=""nav nav-children"">
                            <li>
                                <a>
                                    Etkinlik Oluştur
                                </a>
                            </li>
                            <li>
                                <a>
                                    Oluşturduğum Etkinlikler
                                </a>
                            </li>
                            <li>
                                <a>
                                    Katıldığım Etkinlikler
                                </a>
                            </li>
                        </ul>
                    </li> 
                    <li class=""nav-parent"">
                        <a>
                            <i class=""fa fa-table"" aria-hidden=""true""></i>
                            <span>Profil</span>
                    ");
            WriteLiteral(@"    </a>
                        <ul class=""nav nav-children"">
                            <li>
                                <a>
                                   Kullanıcı Bilgilerini Güncelle
                                </a>
                            </li>
                            <li>
                                <a>
                                    Çıkış Yap
                                </a>
                            </li>
                           
                        </ul>
                    </li>
               

                </ul>
            </nav>

        </div>
    </div>


</aside>");
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
