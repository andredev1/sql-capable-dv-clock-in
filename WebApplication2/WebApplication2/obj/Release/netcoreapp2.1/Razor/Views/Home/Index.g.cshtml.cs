#pragma checksum "C:\Users\andre\Documents\sql capable dv clock in\WebApplication2\WebApplication2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55736df31f82e356d9e9c135cbaa48f757cb49d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\andre\Documents\sql capable dv clock in\WebApplication2\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2;

#line default
#line hidden
#line 2 "C:\Users\andre\Documents\sql capable dv clock in\WebApplication2\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55736df31f82e356d9e9c135cbaa48f757cb49d8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b36aee4455a440795f240a74431c307640c545e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("login-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "About", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\andre\Documents\sql capable dv clock in\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Clock In";

#line default
#line hidden
            BeginContext(45, 19, false);
#line 4 "C:\Users\andre\Documents\sql capable dv clock in\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(64, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(68, 1261, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f7fbdbe1567402da26b6ae0b30a3f4a", async() => {
                BeginContext(148, 1174, true);
                WriteLiteral(@"
    <input type=""text"" name=""firstName""  placeholder=""first name"" />
    <input type=""text"" name=""lastName""  placeholder=""last name"">
    <input type=""text"" name=""personalIDnumber"" placeholder=""ID or passport number"">
    <input type=""hidden"" name=""latitude""  value=""fsdafasdfasdfasdfasfasfd"">
    <input type=""hidden"" name=""longitude""  value=""fsdafasdfasdfasdfasfasfd"">
    <input type=""hidden"" name=""osName""  value=""fsdafasdfasdfasdfasfasfd"">
    <input type=""hidden"" name=""osVersion""  value=""fsdafasdfasdfasdfasfasfd"">
    <input type=""hidden"" name=""browserName""  value=""fsdafasdfasdfasdfasfasfd"">
    <input type=""hidden"" name=""browserVersion""  value=""fsdafasdfasdfasdfasfasfd"">
    <input type=""hidden"" name=""navigatorUserAgent""  value=""fsdafasdfasdfasdfasfasfd"">
    <input type=""hidden"" name=""navigatorAppVersion""  value=""fsdafasdfasdfasdfasfasfd"">
    <input type=""hidden"" name=""navigatorPlatform""  value=""fsdafasdfasdfasdfasfasfd"">
    <input type=""hidden"" name=""navigatorVendor""  value=""fsdafasdfasdf");
                WriteLiteral("asdfasfasfd\">\r\n    <input type=\"hidden\" name=\"dateTime\"  value=\"fsdafasdfasdfasdfasfasfd\">\r\n\r\n    <input type=\"submit\" value=\"Clock In/Clock out\" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1329, 5928, true);
            WriteLiteral(@"





<p id=""demo""></p>

<script>
    var x = document.getElementById(""demo"");

    function getLocation() {
        if (navigator.geolocation) {
            navigator.geolocation.getCurrentPosition(showPosition);
        } else {
            x.innerHTML = ""Geolocation is not supported by this browser."";
        }
    }

    function showPosition(position) {
        var currentdate = new Date();
        var datetime = "" currentdate.getDate() + "" / ""
            + (currentdate.getMonth() + 1) + ""/""
            + currentdate.getFullYear() + "" ""
            + currentdate.getHours() + "":""
            + currentdate.getMinutes() + "":""
            + currentdate.getSeconds();
        x.innerHTML = ""Latitude: "" + position.coords.latitude +
            ""<br>Longitude: "" + position.coords.longitude + datetime;
    }


</script>

<div id=""log""></div>

<script>
    //(function () {
    //    'use strict';

    //    var module = {
    //        options: [],
    //        header: [");
            WriteLiteral(@"navigator.platform, navigator.userAgent, navigator.appVersion, navigator.vendor, window.opera],
    //        dataos: [
    //            { name: 'Windows Phone', value: 'Windows Phone', version: 'OS' },
    //            { name: 'Windows', value: 'Win', version: 'NT' },
    //            { name: 'iPhone', value: 'iPhone', version: 'OS' },
    //            { name: 'iPad', value: 'iPad', version: 'OS' },
    //            { name: 'Kindle', value: 'Silk', version: 'Silk' },
    //            { name: 'Android', value: 'Android', version: 'Android' },
    //            { name: 'PlayBook', value: 'PlayBook', version: 'OS' },
    //            { name: 'BlackBerry', value: 'BlackBerry', version: '/' },
    //            { name: 'Macintosh', value: 'Mac', version: 'OS X' },
    //            { name: 'Linux', value: 'Linux', version: 'rv' },
    //            { name: 'Palm', value: 'Palm', version: 'PalmOS' }
    //        ],
    //        databrowser: [
    //            { name: 'Chrome', value: 'Chro");
            WriteLiteral(@"me', version: 'Chrome' },
    //            { name: 'Firefox', value: 'Firefox', version: 'Firefox' },
    //            { name: 'Safari', value: 'Safari', version: 'Version' },
    //            { name: 'Internet Explorer', value: 'MSIE', version: 'MSIE' },
    //            { name: 'Opera', value: 'Opera', version: 'Opera' },
    //            { name: 'BlackBerry', value: 'CLDC', version: 'CLDC' },
    //            { name: 'Mozilla', value: 'Mozilla', version: 'Mozilla' }
    //        ],
    //        init: function () {
    //            var agent = this.header.join(' '),
    //                os = this.matchItem(agent, this.dataos),
    //                browser = this.matchItem(agent, this.databrowser);

    //            return { os: os, browser: browser };
    //        },
    //        matchItem: function (string, data) {
    //            var i = 0,
    //                j = 0,
    //                html = '',
    //                regex,
    //                regexv,
    //   ");
            WriteLiteral(@"             match,
    //                matches,
    //                version;

    //            for (i = 0; i < data.length; i += 1) {
    //                regex = new RegExp(data[i].value, 'i');
    //                match = regex.test(string);
    //                if (match) {
    //                    regexv = new RegExp(data[i].version + '[- /:;]([\\d._]+)', 'i');
    //                    matches = string.match(regexv);
    //                    version = '';
    //                    if (matches) { if (matches[1]) { matches = matches[1]; } }
    //                    if (matches) {
    //                        matches = matches.split(/[._]+/);
    //                        for (j = 0; j < matches.length; j += 1) {
    //                            if (j === 0) {
    //                                version += matches[j] + '.';
    //                            } else {
    //                                version += matches[j];
    //                            }
    //    ");
            WriteLiteral(@"                    }
    //                    } else {
    //                        version = '0';
    //                    }
    //                    return {
    //                        name: data[i].name,
    //                        version: parseFloat(version)
    //                    };
    //                }
    //            }
    //            return { name: 'unknown', version: 0 };
    //        }
    //    };

    //    var e = module.init(),
    //        debug = '';

    //    debug += 'os.name = ' + e.os.name + '<br/>';
    //    debug += 'os.version = ' + e.os.version + '<br/>';
    //    debug += 'browser.name = ' + e.browser.name + '<br/>';
    //    debug += 'browser.version = ' + e.browser.version + '<br/>';

    //    debug += '<br/>';
    //    debug += 'navigator.userAgent = ' + navigator.userAgent + '<br/>';
    //    debug += 'navigator.appVersion = ' + navigator.appVersion + '<br/>';
    //    debug += 'navigator.platform = ' + navigator.platform + '");
            WriteLiteral(@"<br/>';
    //    debug += 'navigator.vendor = ' + navigator.vendor + '<br/>';

    //    document.getElementById('log').innerHTML = debug;
    //    document.getElementById('log').innerHTML = """";

    //    var x = document.getElementById(""demo"");
        


    //    function getLocation() {
    //        if (navigator.geolocation) {
    //            navigator.geolocation.getCurrentPosition(showPosition);
    //        } else {
    //            x.innerHTML = ""Geolocation is not supported by this browser."";
    //        }
    //    }

    //    function showPosition(position) {
    //        x.innerHTML = ""Latitude: "" + position.coords.latitude +
    //            ""<br>Longitude: "" + position.coords.longitude;
    //    }
        
        
    //}());
</script>



");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
