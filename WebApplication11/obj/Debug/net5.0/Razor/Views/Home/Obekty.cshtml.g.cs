#pragma checksum "C:\Users\123\source\repos\WebApplication11\WebApplication11\Views\Home\Obekty.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b9eace1ba276eb099a4610dfaba93441b67705c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Obekty), @"mvc.1.0.view", @"/Views/Home/Obekty.cshtml")]
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
#line 1 "C:\Users\123\source\repos\WebApplication11\WebApplication11\Views\_ViewImports.cshtml"
using WebApplication11;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\123\source\repos\WebApplication11\WebApplication11\Views\_ViewImports.cshtml"
using WebApplication11.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b9eace1ba276eb099a4610dfaba93441b67705c", @"/Views/Home/Obekty.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40d4615a478f022e670e186c1fe0812b887af102", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Obekty : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\123\source\repos\WebApplication11\WebApplication11\Views\Home\Obekty.cshtml"
  
    ViewData["Title"] = "Obekty";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .about object{
        height: calc(100vh - 0px);
    }

    .pagination > li > a,
    .pagination > li > span {
        position: relative;
        float: left;
        padding: 6px 12px;
        line-height: 1.6;
        text-decoration: none;
        color: #AB2FDA;
        background-color: #ffffff;
        border: 1px solid #dddddd;
        margin-left: -1px;
    }

        .pagination > li > a:hover,
        .pagination > li > span:hover,
        .pagination > li > a:focus,
        .pagination > li > span:focus {
            z-index: 2;
            color: #AB2FDA;
            background-color: #eeeeee;
            border-color: #dddddd;
        }

    .pagination > .active > a,
    .pagination > .active > span,
    .pagination > .active > a:hover,
    .pagination > .active > span:hover,
    .pagination > .active > a:focus,
    .pagination > .active > span:focus {
        z-index: 3;
        color: #ffffff;
        background-color: #AB2FDA;
        bord");
            WriteLiteral("er-color: #960DB6;\r\n        cursor: default;\r\n    }\r\n</style>\r\n\r\n<!-- Content -->\r\n<section id=\"layout-content\">\r\n    <div class=\"blogwrap\">\r\n\r\n\r\n        <div class=\"about object\">\r\n\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 1264, "\"", 1301, 1);
#nullable restore
#line 54 "C:\Users\123\source\repos\WebApplication11\WebApplication11\Views\Home\Obekty.cshtml"
WriteAttributeValue("", 1271, Url.Action("Kvartal", "Home"), 1271, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"about-item object-item\">\r\n                <div class=\"about-img\">\r\n\r\n                    <img data-src=\"\"\r\n                         src=\"https://apctrade.kz/storage/app/uploads/public/608/689/cba/608689cba8e15977653605.jpg\"");
            BeginWriteAttribute("alt", "\r\n                         alt=\"", 1533, "\"", 1565, 0);
            EndWriteAttribute();
            WriteLiteral(@"
                         style=""max-width: 100%"" />

                </div>

                <div class=""about-content"">
                    <div class=""about-name"">ЖК Зеленый квартал</div>
                    <div class=""object-сity"">Нур-Султан</div>
                </div>
            </a>
            <a");
            BeginWriteAttribute("href", " href=\"", 1883, "\"", 1922, 1);
#nullable restore
#line 69 "C:\Users\123\source\repos\WebApplication11\WebApplication11\Views\Home\Obekty.cshtml"
WriteAttributeValue("", 1890, Url.Action("Greenmall", "Home"), 1890, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"about-item object-item\">\r\n                <div class=\"about-img\">\r\n\r\n                    <img data-src=\"\"\r\n                         src=\"https://apctrade.kz/storage/app/uploads/public/608/68d/8b3/60868d8b38892533964850.jpg\"");
            BeginWriteAttribute("alt", "\r\n                         alt=\"", 2154, "\"", 2186, 0);
            EndWriteAttribute();
            WriteLiteral(@"
                         style=""max-width: 100%"" />

                </div>

                <div class=""about-content"">
                    <div class=""about-name"">ТРЦ Green Mall</div>
                    <div class=""object-сity"">Нур-Султан</div>
                </div>
            </a>
            <a");
            BeginWriteAttribute("href", " href=\"", 2500, "\"", 2539, 1);
#nullable restore
#line 84 "C:\Users\123\source\repos\WebApplication11\WebApplication11\Views\Home\Obekty.cshtml"
WriteAttributeValue("", 2507, Url.Action("Gostinica", "Home"), 2507, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"about-item object-item\">\r\n                <div class=\"about-img\">\r\n\r\n                    <img data-src=\"\"\r\n                         src=\"https://apctrade.kz/storage/app/uploads/public/608/68e/112/60868e1129e3f076403081.jpg\"");
            BeginWriteAttribute("alt", "\r\n                         alt=\"", 2771, "\"", 2803, 0);
            EndWriteAttribute();
            WriteLiteral(@"
                         style=""max-width: 100%"" />

                </div>

                <div class=""about-content"">
                    <div class=""about-name"">Гостиница Акжелкен</div>
                    <div class=""object-сity"">Бурабай</div>
                </div>
            </a>
            <a");
            BeginWriteAttribute("href", " href=\"", 3118, "\"", 3156, 1);
#nullable restore
#line 99 "C:\Users\123\source\repos\WebApplication11\WebApplication11\Views\Home\Obekty.cshtml"
WriteAttributeValue("", 3125, Url.Action("Gospital", "Home"), 3125, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"about-item object-item\">\r\n                <div class=\"about-img\">\r\n\r\n                    <img data-src=\"\"\r\n                         src=\"https://apctrade.kz/storage/app/uploads/public/608/68e/29b/60868e29b5758346153640.jpg\"");
            BeginWriteAttribute("alt", "\r\n                         alt=\"", 3388, "\"", 3420, 0);
            EndWriteAttribute();
            WriteLiteral(@"
                         style=""max-width: 100%"" />

                </div>

                <div class=""about-content"">
                    <div class=""about-name"">Инфекционный госпиталь</div>
                    <div class=""object-сity"">Петропавловск</div>
                </div>
            </a>
            <a");
            BeginWriteAttribute("href", " href=\"", 3745, "\"", 3781, 1);
#nullable restore
#line 114 "C:\Users\123\source\repos\WebApplication11\WebApplication11\Views\Home\Obekty.cshtml"
WriteAttributeValue("", 3752, Url.Action("Samruk", "Home"), 3752, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"about-item object-item\">\r\n                <div class=\"about-img\">\r\n\r\n                    <img data-src=\"\"\r\n                         src=\"https://apctrade.kz/storage/app/uploads/public/608/68e/552/60868e5521e24274162740.jpg\"");
            BeginWriteAttribute("alt", "\r\n                         alt=\"", 4013, "\"", 4045, 0);
            EndWriteAttribute();
            WriteLiteral(@"
                         style=""max-width: 100%"" />

                </div>

                <div class=""about-content"">
                    <div class=""about-name"">
                        АО Самрук-Казына
                        (ТОО QazCloud)
                    </div>
                    <div class=""object-сity"">Нур-Султан</div>
                </div>
            </a>
            <a");
            BeginWriteAttribute("href", " href=\"", 4449, "\"", 4487, 1);
#nullable restore
#line 132 "C:\Users\123\source\repos\WebApplication11\WebApplication11\Views\Home\Obekty.cshtml"
WriteAttributeValue("", 4456, Url.Action("Pavlodar", "Home"), 4456, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"about-item object-item\">\r\n                <div class=\"about-img\">\r\n\r\n                    <img data-src=\"\"\r\n                         src=\"https://apctrade.kz/storage/app/uploads/public/608/68e/7c5/60868e7c5882b488111144.jpg\"");
            BeginWriteAttribute("alt", "\r\n                         alt=\"", 4719, "\"", 4751, 0);
            EndWriteAttribute();
            WriteLiteral(@"
                         style=""max-width: 100%"" />

                </div>

                <div class=""about-content"">
                    <div class=""about-name"">Инфекционный госпиталь</div>
                    <div class=""object-сity"">Павлодар</div>
                </div>
            </a>
            <a");
            BeginWriteAttribute("href", " href=\"", 5071, "\"", 5110, 1);
#nullable restore
#line 147 "C:\Users\123\source\repos\WebApplication11\WebApplication11\Views\Home\Obekty.cshtml"
WriteAttributeValue("", 5078, Url.Action("Kokshetau", "Home"), 5078, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"about-item object-item\">\r\n                <div class=\"about-img\">\r\n\r\n                    <img data-src=\"\"\r\n                         src=\"https://apctrade.kz/storage/app/uploads/public/608/68e/c5d/60868ec5db46c605268643.jpg\"");
            BeginWriteAttribute("alt", "\r\n                         alt=\"", 5342, "\"", 5374, 0);
            EndWriteAttribute();
            WriteLiteral(@"
                         style=""max-width: 100%"" />

                </div>

                <div class=""about-content"">
                    <div class=""about-name"">Инфекционный госпиталь</div>
                    <div class=""object-сity"">Кокшетау</div>
                </div>
            </a>

        </div>

    </div>
</section>");
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
