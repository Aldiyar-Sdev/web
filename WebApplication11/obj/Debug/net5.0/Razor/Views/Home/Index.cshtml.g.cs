#pragma checksum "C:\Users\123\source\repos\WebApplication11\WebApplication11\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bab774341de9b3d77e072a9867c929a4600c6d25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bab774341de9b3d77e072a9867c929a4600c6d25", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40d4615a478f022e670e186c1fe0812b887af102", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\123\source\repos\WebApplication11\WebApplication11\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>

    .letters_slider a {
        margin-right: 120px; /* Регулируйте значение, чтобы достичь нужного отступа */
    }


    .lined .white {
        color: white;
    }

    .slick-slider .slick-track, .slick-slider .slick-list {
        -webkit-transform: translate3d(0, 0, 0);
        -moz-transform: translate3d(0, 0, 0);
        -ms-transform: translate3d(0, 0, 0);
        -o-transform: translate3d(0, 0, 0);
        transform: translate3d(0, 0, 0);
    }

    .slick-track {
        position: relative;
        top: 0;
        left: 0;
        display: block;
        margin-left: auto;
        margin-right: auto;
    }

    .slick-next {
        right: -55px;
    }

    .slick-arrow {
        border: 1.07043px solid #DCDCDC;
        width: 32px;
        height: 32px;
        border-radius: 50%;
        display: flex !important;
        align-items: center;
        justify-content: center;
    }

    .slick-next {
        right: -25px;
    }

    .slick-pr");
            WriteLiteral(@"ev, .slick-next {
        font-size: 0;
        line-height: 0;
        position: absolute;
        top: 50%;
        display: block;
        width: 20px;
        height: 20px;
        padding: 0;
        -webkit-transform: translate(0, -50%);
        -ms-transform: translate(0, -50%);
        transform: translate(0, -50%);
        cursor: pointer;
        color: transparent;
        border: none;
        outline: none;
        background: transparent;
    }

    button {
        transition: .5s;
    }

    input, button, select, textarea {
        outline: none !important;
    }

    input, button, select, textarea {
        font-family: inherit;
        font-size: inherit;
        line-height: inherit;
    }

        button, html input[type=""button""], input[type=""reset""], input[type=""submit""] {
            -webkit-appearance: button;
            cursor: pointer;
        }

    button, select {
        text-transform: none;
    }

    button {
        overflow: visi");
            WriteLiteral(@"ble;
    }

    button, input, optgroup, select, textarea {
        color: inherit;
        font: inherit;
        margin: 0;
    }

    .letters_slider .slick-list {
        margin: 0 -16px;
    }

    .slick-slider .slick-track, .slick-slider .slick-list {
        -webkit-transform: translate3d(0, 0, 0);
        -moz-transform: translate3d(0, 0, 0);
        -ms-transform: translate3d(0, 0, 0);
        -o-transform: translate3d(0, 0, 0);
        transform: translate3d(0, 0, 0);
    }

    .slick-list {
        position: relative;
        display: block;
        overflow: hidden;
        margin: 0;
        padding: 0;
    }


    .slick-slider {
        position: relative;
        display: block;
        box-sizing: border-box;
        -webkit-user-select: none;
        -moz-user-select: none;
        -ms-user-select: none;
        user-select: none;
        -webkit-touch-callout: none;
        -ms-touch-action: pan-y;
        touch-action: pan-y;
        -webkit-tap-h");
            WriteLiteral(@"ighlight-color: transparent;
    }

    .slick-prev {
        left: -55px;
    }

    .slick-arrow {
        border: 1.07043px solid #DCDCDC;
        width: 32px;
        height: 32px;
        border-radius: 50%;
        display: flex !important;
        align-items: center;
        justify-content: center;
    }

    .slick-prev {
        left: -25px;
    }

    .slick-prev, .slick-next {
        font-size: 0;
        line-height: 0;
        position: absolute;
        top: 50%;
        display: block;
        width: 20px;
        height: 20px;
        padding: 0;
        -webkit-transform: translate(0, -50%);
        -ms-transform: translate(0, -50%);
        transform: translate(0, -50%);
        cursor: pointer;
        color: transparent;
        border: none;
        outline: none;
        background: transparent;
    }

    button {
        transition: .5s;
    }

    input, button, select, textarea {
        outline: none !important;
    }

    input, bu");
            WriteLiteral(@"tton, select, textarea {
        font-family: inherit;
        font-size: inherit;
        line-height: inherit;
    }

        button, html input[type=""button""], input[type=""reset""], input[type=""submit""] {
            -webkit-appearance: button;
            cursor: pointer;
        }

    button, select {
        text-transform: none;
    }

    button {
        overflow: visible;
    }

    button, input, optgroup, select, textarea {
        color: inherit;
        font: inherit;
        margin: 0;
    }

    * {
        -webkit-box-sizing: border-box;
        -moz-box-sizing: border-box;
        box-sizing: border-box;
    }

    .pt85 .clients_slider {
        padding-bottom: 85px; /* Нижний отступ в 85 пикселей */
    }

    .pt85 .letters_slider {
        padding-bottom: 85px; /* Нижний отступ в 85 пикселей */
    }

    .serv_title.lined:before {
        bottom: auto;
        top: 0;
    }


    .pt85 .sert_block {
        padding-bottom: 85px; /* Нижний от");
            WriteLiteral(@"ступ в 85 пикселей */
    }

    .pt85 {
        padding-top: 85px;
        background-color: white;
    }

    .mb50 {
        margin-bottom: 50px;
    }

    .lined {
        position: relative;
        padding-bottom: 27px;
    }

    .title {
        text-transform: uppercase;
        color: #151515;
        font-weight: 700;
        font-size: 34px;
        font-family: 'ddt';
        line-height: 1.1;
    }

    .services_list {
        display: grid;
        grid-template-columns: repeat(3, 1fr);
        gap: 32px;
    }

    .service_item {
        border: 1px solid #E4E4E4;
        border-radius: 15px;
        padding: 45px 50px;
        display: flex !important;
        flex-direction: column;
    }

    .serv_icon {
        margin-bottom: 28px;
    }

    img {
        vertical-align: middle;
    }

    img {
        border: 0;
    }

    .serv_title.lined {
        padding-top: 21px;
        padding-bottom: 0;
    }

    .serv_title {
     ");
            WriteLiteral(@"   margin-bottom: 17px;
        text-transform: uppercase;
        color: #151515;
        font-weight: 700;
        font-family: 'ddt';
    }

    .serv_prev {
        color: #888888;
        font-weight: 500;
        font-size: 14px;
        line-height: 1.4;
        margin-bottom: 24px;
    }

        .serv_prev p:last-child {
            margin-bottom: 0;
        }

    p {
        margin: 0 0 12.5px;
    }

    .service_item .gray_link {
        margin-top: auto;
    }

    .gray_link {
        display: flex;
        align-items: center;
        gap: 14px;
        text-decoration-line: underline;
        color: #777777;
    }

    a {
        transition: .5s;
    }

    a {
        outline: none !important;
    }

    a {
        color: white;
        text-decoration: none;
    }

    a {
        background-color: transparent;
    }

    svg:not(:root) {
        overflow: hidden;
    }

    .sert_block {
        display: flex;
        gap: 50px;
");
            WriteLiteral(@"    }

    .sert_slider_side {
        width: calc(66.66% - 64px);
    }

    .slick-slider {
        position: relative;
        display: block;
        box-sizing: border-box;
        -webkit-user-select: none;
        -moz-user-select: none;
        -ms-user-select: none;
        user-select: none;
        -webkit-touch-callout: none;
        -ms-touch-action: pan-y;
        touch-action: pan-y;
        -webkit-tap-highlight-color: transparent;
    }

    .sert_slider .slick-list {
        margin: 0 -25px;
    }

    .slick-slider .slick-track, .slick-slider .slick-list {
        -webkit-transform: translate3d(0, 0, 0);
        -moz-transform: translate3d(0, 0, 0);
        -ms-transform: translate3d(0, 0, 0);
        -o-transform: translate3d(0, 0, 0);
        transform: translate3d(0, 0, 0);
    }

    .slick-list {
        position: relative;
        display: block;
        overflow: hidden;
        margin: 0;
        padding: 0;
    }

    .slick-slider .slick-tra");
            WriteLiteral(@"ck, .slick-slider .slick-list {
        -webkit-transform: translate3d(0, 0, 0);
        -moz-transform: translate3d(0, 0, 0);
        -ms-transform: translate3d(0, 0, 0);
        -o-transform: translate3d(0, 0, 0);
        transform: translate3d(0, 0, 0);
    }

    .slick-track {
        position: relative;
        top: 0;
        left: 0;
        display: block;
        margin-left: auto;
        margin-right: auto;
    }

    .sert_slider .slick-slide {
        margin: 0 25px;
        border: 5px solid #000000;
        border-radius: 15px;
        overflow: hidden;
    }

    .slick-initialized .slick-slide {
        display: block;
    }

    .slick-slide {
        display: none;
        float: left;
        height: 100%;
        min-height: 1px;
    }

    .sert_slider .slick-slide img {
        width: 100%;
    }

    .slick-slide img {
        display: block;
    }

    img {
        vertical-align: middle;
    }

    img {
        border: 0;
    }

 ");
            WriteLiteral(@"   .sert_text_side {
        width: calc(37.33% - 35px);
        background: #f2f2ed;
        border-radius: 15px;
        padding: 34px 40px;
        line-height: 1.2;
        display: flex;
        flex-direction: column;
        color: #777777;
        font-size: 19px;
    }

    p {
        margin: 0 0 12.5px;
    }

    .arr_flex {
        display: flex;
        align-items: center;
        gap: 10px;
        margin-top: auto;
        padding-top: 20px;
    }

        .arr_flex .slick-arrow {
            position: unset;
            transform: translate(0, 0);
        }

    .slick-prev {
        left: -55px;
    }

    .slick-arrow {
        border: 1.07043px solid #DCDCDC;
        width: 32px;
        height: 32px;
        border-radius: 50%;
        display: flex !important;
        align-items: center;
        justify-content: center;
    }

    .slick-prev {
        left: -25px;
    }

    .slick-prev, .slick-next {
        font-size: 0;
        line-");
            WriteLiteral(@"height: 0;
        position: absolute;
        top: 50%;
        display: block;
        width: 20px;
        height: 20px;
        padding: 0;
        -webkit-transform: translate(0, -50%);
        -ms-transform: translate(0, -50%);
        transform: translate(0, -50%);
        cursor: pointer;
        color: transparent;
        border: none;
        outline: none;
        background: transparent;
    }

    button {
        transition: .5s;
    }

    input, button, select, textarea {
        outline: none !important;
    }

    input, button, select, textarea {
        font-family: inherit;
        font-size: inherit;
        line-height: inherit;
    }

        button, html input[type=""button""], input[type=""reset""], input[type=""submit""] {
            -webkit-appearance: button;
            cursor: pointer;
        }

    button, select {
        text-transform: none;
    }

    button {
        overflow: visible;
    }

    button, input, optgroup, select, tex");
            WriteLiteral(@"tarea {
        color: inherit;
        font: inherit;
        margin: 0;
    }

    .about_block {
        position: relative;
        padding: 135px 0 150px;
    }

        .about_block::after {
            content: """";
            position: absolute;
            top: 0;
            left: 0;
            width: 100%;
            height: 100%;
            background-image: url(/images/slider1.jpg);
            background-size: cover;
            background-position: center;
            opacity: 0.3; /* Прозрачность фона */
            z-index: -1; /* Чтобы фон был под текстом */
        }


    .container {
        margin-right: auto;
        margin-left: auto;
        padding-left: 15px;
        padding-right: 15px;
    }

    .about_info {
        position: relative;
        z-index: 1;
        display: flex;
        align-items: center;
        justify-content: space-between;
    }

    .about_img {
        width: 42%;
    }

        .about_img img {
          ");
            WriteLiteral(@"  max-width: 100%;
        }

    img {
        vertical-align: middle;
    }

    img {
        border: 0;
    }

    .about_text {
        width: calc(58% - 135px);
        color: #AEAEAE;
        font-size: 20px;
        line-height: 1.3;
    }

    .mb35 {
        margin-bottom: 35px;
    }

    .white {
        color: #fff;
    }

    .lined {
        position: relative;
        padding-bottom: 27px;
    }

    .title {
        text-transform: uppercase;
        color: black;
        font-weight: 700;
        font-size: 34px;
        font-family: 'ddt';
        line-height: 1.1;
    }

    p {
        margin: 0 0 12.5px;
    }

    .numbers_list {
        display: flex;
        margin-top: 40px;
        gap: 60px;
        width: 78%;
    }

    .number {
        text-transform: uppercase;
        color: #FFFFFF;
        font-size: 28px;
        font-family: 'ddt';
        line-height: 1;
        margin-bottom: 10px;
    }

    .num_text {
     ");
            WriteLiteral(@"   color: #777777;
        font-size: 16px;
    }

    .mainbanner {
        position: relative;
        height: calc(100vh - 116px);
    }

    .banner {
        width: 100%;
        height: 100%;
        object-fit: cover;
        opacity: 0.3; /* Прозрачность видео */
        background-color: #000; /* Цвет видео (темный) */
    }

    .banner_wrap {
        position: absolute;
        top: 50%;
        width: 100%;
        transform: translateY(-50%);
        z-index: 1;
    }

    .container {
        margin-right: auto;
        margin-left: auto;
        padding-left: 15px;
        padding-right: 15px;
    }

    .banner_content {
        width: 50%;
    }

    .maintitle {
        color: #FFFFFF;
        font-weight: 700;
        font-size: 54px;
        margin-bottom: 15px;
        line-height: 1.1;
        font-family: 'ddt';
        text-transform: uppercase;
    }

    .maintext {
        color: #E9E9E9;
        font-size: 24px;
        line-height: ");
            WriteLiteral("1.1;\r\n    }\r\n\r\n        .maintext p:last-child {\r\n            margin-bottom: 0;\r\n        }\r\n\r\n    p {\r\n        margin: 0 0 12.5px;\r\n    }\r\n</style>\r\n\r\n<div class=\"mainbanner\">\r\n    <video class=\"banner\" autoplay=\"autoplay\"");
            BeginWriteAttribute("loop", " loop=\"", 14602, "\"", 14609, 0);
            EndWriteAttribute();
            BeginWriteAttribute("muted", " muted=\"", 14610, "\"", 14618, 0);
            EndWriteAttribute();
            BeginWriteAttribute("poster", " poster=\"", 14619, "\"", 14628, 0);
            EndWriteAttribute();
            WriteLiteral(@" playsinline>
        <source src=""/media/index.mp4"" type='video/mp4; codecs=""avc1.42E01E, mp4a.40.2""'>
    </video>
    <div class=""banner_wrap"">
        <div class=""container"">
            <div class=""banner_content"">
                <div class=""maintitle"">ТОО «INFINITY PROJECT»</div>
                <div class=""maintext""><p>Архитектурно-строительное проектирование</p></div>
            </div>
        </div>
    </div>
</div>


<div class=""pt85"">
    <div class=""container"">
        <div class=""title lined mb50"" style=""color: black;"">наши услуги</div>
        <div class=""services_list"">
            <div class=""service_item"">
                <div class=""serv_icon""><img src=""/images/icon1.png""");
            BeginWriteAttribute("alt", " alt=\"", 15349, "\"", 15355, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""width: 80px;""></div>
                <div class=""serv_title lined"">Узаконение недвижимости</div>
                <div class=""serv_prev""><p>Узаконение &nbsp;перепланировки, Акт ввода в эксплуатацию, Акт сноса объекта, Постутилизация объектов ...</p></div>
                <a");
            BeginWriteAttribute("href", " href=\"", 15640, "\"", 15676, 1);
#nullable restore
#line 721 "C:\Users\123\source\repos\WebApplication11\WebApplication11\Views\Home\Index.cshtml"
WriteAttributeValue("", 15647, Url.Action("Uslugi", "Home"), 15647, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""gray_link"">
                    <span>Подробнее</span><svg width=""50"" height=""29""  viewBox=""0 0 24 24"" fill=""none"" xmlns=""http://www.w3.org/2000/svg""><g id=""SVGRepo_bgCarrier"" stroke-width=""0""></g><g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""></g><g id=""SVGRepo_iconCarrier""> <path d=""M6 12H18M18 12L13 7M18 12L13 17"" stroke=""#000000"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round""></path> </g></svg>
                </a>
            </div>
            <div class=""service_item"">
                <div class=""serv_icon""><img src=""/images/icon2.png""");
            BeginWriteAttribute("alt", " alt=\"", 16285, "\"", 16291, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""width: 80px;""></div>
                <div class=""serv_title lined"">Проектирование</div>
                <div class=""serv_prev""><p>Это обязательный документ, который должен быть разработан, чтобы здание было безопасным, надежным в эксплуатации</p></div>
                <a");
            BeginWriteAttribute("href", " href=\"", 16574, "\"", 16610, 1);
#nullable restore
#line 729 "C:\Users\123\source\repos\WebApplication11\WebApplication11\Views\Home\Index.cshtml"
WriteAttributeValue("", 16581, Url.Action("Obekty", "Home"), 16581, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""gray_link"">
                    <span>Подробнее</span><svg width=""50"" height=""29"" viewBox=""0 0 24 24"" fill=""none"" xmlns=""http://www.w3.org/2000/svg""><g id=""SVGRepo_bgCarrier"" stroke-width=""0""></g><g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""></g><g id=""SVGRepo_iconCarrier""> <path d=""M6 12H18M18 12L13 7M18 12L13 17"" stroke=""#000000"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round""></path> </g></svg>
                </a>
            </div>
            <div class=""service_item"">
                <div class=""serv_icon""><img src=""/images/icon3.png""");
            BeginWriteAttribute("alt", " alt=\"", 17218, "\"", 17224, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""width: 80px;""></div>
                <div class=""serv_title lined"">Экспертиза</div>
                <div class=""serv_prev""><p>Экспертная деятельность, заключающаяся в проведении анализа и оценки качества проектов путем установления соответствия (несоответствия) проектных решений условиям исходных документов</p></div>
                <a");
            BeginWriteAttribute("href", " href=\"", 17573, "\"", 17611, 1);
#nullable restore
#line 737 "C:\Users\123\source\repos\WebApplication11\WebApplication11\Views\Home\Index.cshtml"
WriteAttributeValue("", 17580, Url.Action("Partnery", "Home"), 17580, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""gray_link"">
                    <span>Подробнее</span><svg width=""50"" height=""29"" viewBox=""0 0 24 24"" fill=""none"" xmlns=""http://www.w3.org/2000/svg""><g id=""SVGRepo_bgCarrier"" stroke-width=""0""></g><g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""></g><g id=""SVGRepo_iconCarrier""> <path d=""M6 12H18M18 12L13 7M18 12L13 17"" stroke=""#000000"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round""></path> </g></svg>
                </a>
            </div>
        </div>
    </div>
</div>


<div class=""pt85"">
    <div class=""container"">
        <div class=""title lined mb50"" style=""color: black;"">сертификаты и лицензии</div>
        <div class=""sert_block"">
            <div class=""sert_slider_side"">
                <div class=""sert_slider"">
                    <a href=""/storage/app/media/sert/Rectangle%202081.jpg"" data-fancybox=""sertificates""><img src=""https://premium-stroy.kz/storage/app/uploads/public/d55/cf4/a2f/thumb__350_500_0_0_crop.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 18618, "\"", 18624, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                    <a href=\"/storage/app/media/sert/Rectangle%202082.jpg\" data-fancybox=\"sertificates\"><img src=\"https://premium-stroy.kz/storage/app/uploads/public/756/a12/926/thumb__350_500_0_0_crop.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 18838, "\"", 18844, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
                </div>
            </div>
            <div class=""sert_text_side"">
                <p>Мы проектируем:</p>

                <p>• жилые здания (многоквартирные дома, коттеджи, дачи), гаражи;</p>

                <p>• общественные здания (офисы, магазины и пр.);</p>

                <p>• промышленные объекты (цеха, склады, котельные, насосные и пр.);</p>

                <p>• инженерные сети и системы (внутренние и наружные сети — водопровод, канализация, отопление, вентиляция, электроснабжение, электроосвещение, слаботочные сети и пр).</p>
                <div class=""arr_flex sert_arrs""></div>
            </div>
        </div>
    </div>
</div>


<div class=""pt86"">
    <div class=""about_block"">
        <div class=""container"">
            <div class=""about_info"">
                <div class=""about_text"">
                    <div class=""title lined white mb35"" style=""color: white;"">о компании</div>
                    <p>ТОО «INFINITY PROJECT» образована в июне 2010 ");
            WriteLiteral(@"года. С тех пор она динамично развивается и уверенно смотрит в будущее, также компания открыта для взаимовыгодного сотрудничества с отечественными и международными компаниями, что способствует развитию гибкости отношений и технических «ноу-хау». &nbsp;</p>
                    <div class=""numbers_list"">
                        <div class=""num_item"">
                            <div class=""number""><span>100</span> +</div>
                            <div class=""num_text"">Завершенных проектов</div>
                        </div>
                        <div class=""num_item"">
                            <div class=""number""><span>10</span> ЛЕТ</div>
                            <div class=""num_text"">Опыта работы на рынке</div>
                        </div>
                        <div class=""num_item"">
                            <div class=""number""><span>15</span> чел.</div>
                            <div class=""num_text"">Наша команда экспертов</div>
                        </div>
                ");
            WriteLiteral(@"    </div>
                </div>
            </div>
        </div>
    </div>
</div>


<div class=""pt85"">
    <div class=""container"">
        <div class=""title lined mb50"">благодарственные письма</div>
        <div class=""letters_slider"">
            <a href=""/storage/app/media/letters/Rectangle%202085.jpg"" data-fancybox=""sertificates""><img src=""https://premium-stroy.kz/storage/app/uploads/public/a8a/b15/a99/thumb__280_400_0_0_crop.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 21346, "\"", 21352, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n            <a href=\"/storage/app/media/letters/Rectangle%202086.jpg\" data-fancybox=\"sertificates\"><img src=\"https://premium-stroy.kz/storage/app/uploads/public/248/554/a13/thumb__280_400_0_0_crop.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 21561, "\"", 21567, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n            <a href=\"/storage/app/media/letters/Rectangle%202085.jpg\" data-fancybox=\"sertificates\"><img src=\"https://premium-stroy.kz/storage/app/uploads/public/a8a/b15/a99/thumb__280_400_0_0_crop.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 21776, "\"", 21782, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n        </div>\r\n    </div>\r\n</div> ");
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
