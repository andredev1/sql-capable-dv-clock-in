#pragma checksum "C:\Users\andre\Documents\sql capable dv clock in\WebApplication2\WebApplication2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00439ef0ea36c29c2c07ede18465b8edb87a0a00"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00439ef0ea36c29c2c07ede18465b8edb87a0a00", @"/Views/Home/Index.cshtml")]
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
            BeginContext(68, 1266, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a35892350b79426690582be57979e5b2", async() => {
                BeginContext(148, 139, true);
                WriteLiteral("\r\n    <input type=\"hidden\" id=\"firstName\"  value=\"asdfsdfasdfasfasdfasdfsdafasdfasdfasdfasfasfd\" />\r\n    <input type=\"hidden\" id=\"lastName\"");
                EndContext();
                BeginWriteAttribute("value", "  value=", 287, "", 316, 1);
#line 8 "C:\Users\andre\Documents\sql capable dv clock in\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
WriteAttributeValue("", 295, ViewData["lastName"], 295, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(316, 49, true);
                WriteLiteral(">\r\n    <input type=\"hidden\" id=\"personalIDnumber\"");
                EndContext();
                BeginWriteAttribute("value", "  value=", 365, "", 402, 1);
#line 9 "C:\Users\andre\Documents\sql capable dv clock in\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
WriteAttributeValue("", 373, ViewData["personalIDnumber"], 373, 29, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(402, 41, true);
                WriteLiteral(">\r\n    <input type=\"hidden\" id=\"latitude\"");
                EndContext();
                BeginWriteAttribute("value", "  value=", 443, "", 472, 1);
#line 10 "C:\Users\andre\Documents\sql capable dv clock in\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
WriteAttributeValue("", 451, ViewData["latitude"], 451, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(472, 42, true);
                WriteLiteral(">\r\n    <input type=\"hidden\" id=\"longitude\"");
                EndContext();
                BeginWriteAttribute("value", "  value=", 514, "", 544, 1);
#line 11 "C:\Users\andre\Documents\sql capable dv clock in\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
WriteAttributeValue("", 522, ViewData["longitude"], 522, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(544, 39, true);
                WriteLiteral(">\r\n    <input type=\"hidden\" id=\"osName\"");
                EndContext();
                BeginWriteAttribute("value", "  value=", 583, "", 610, 1);
#line 12 "C:\Users\andre\Documents\sql capable dv clock in\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
WriteAttributeValue("", 591, ViewData["osName"], 591, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(610, 42, true);
                WriteLiteral(">\r\n    <input type=\"hidden\" id=\"osVersion\"");
                EndContext();
                BeginWriteAttribute("value", "  value=", 652, "", 682, 1);
#line 13 "C:\Users\andre\Documents\sql capable dv clock in\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
WriteAttributeValue("", 660, ViewData["osVersion"], 660, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(682, 44, true);
                WriteLiteral(">\r\n    <input type=\"hidden\" id=\"browserName\"");
                EndContext();
                BeginWriteAttribute("value", "  value=", 726, "", 758, 1);
#line 14 "C:\Users\andre\Documents\sql capable dv clock in\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
WriteAttributeValue("", 734, ViewData["browserName"], 734, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(758, 47, true);
                WriteLiteral(">\r\n    <input type=\"hidden\" id=\"browserVersion\"");
                EndContext();
                BeginWriteAttribute("value", "  value=", 805, "", 840, 1);
#line 15 "C:\Users\andre\Documents\sql capable dv clock in\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
WriteAttributeValue("", 813, ViewData["browserVersion"], 813, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(840, 51, true);
                WriteLiteral(">\r\n    <input type=\"hidden\" id=\"navigatorUserAgent\"");
                EndContext();
                BeginWriteAttribute("value", "  value=", 891, "", 930, 1);
#line 16 "C:\Users\andre\Documents\sql capable dv clock in\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
WriteAttributeValue("", 899, ViewData["navigatorUserAgent"], 899, 31, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(930, 52, true);
                WriteLiteral(">\r\n    <input type=\"hidden\" id=\"navigatorAppVersion\"");
                EndContext();
                BeginWriteAttribute("value", "  value=", 982, "", 1022, 1);
#line 17 "C:\Users\andre\Documents\sql capable dv clock in\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
WriteAttributeValue("", 990, ViewData["navigatorAppVersion"], 990, 32, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1022, 50, true);
                WriteLiteral(">\r\n    <input type=\"hidden\" id=\"navigatorPlatform\"");
                EndContext();
                BeginWriteAttribute("value", "  value=", 1072, "", 1110, 1);
#line 18 "C:\Users\andre\Documents\sql capable dv clock in\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
WriteAttributeValue("", 1080, ViewData["navigatorPlatform"], 1080, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1110, 48, true);
                WriteLiteral(">\r\n    <input type=\"hidden\" id=\"navigatorVendor\"");
                EndContext();
                BeginWriteAttribute("value", "  value=", 1158, "", 1194, 1);
#line 19 "C:\Users\andre\Documents\sql capable dv clock in\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
WriteAttributeValue("", 1166, ViewData["navigatorVendor"], 1166, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1194, 41, true);
                WriteLiteral(">\r\n    <input type=\"hidden\" id=\"dateTime\"");
                EndContext();
                BeginWriteAttribute("value", "  value=\"", 1235, "\"", 1265, 1);
#line 20 "C:\Users\andre\Documents\sql capable dv clock in\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
WriteAttributeValue("", 1244, ViewData["dateTime"], 1244, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1266, 61, true);
                WriteLiteral(">\r\n\r\n    <input type=\"submit\" value=\"Clock In/Clock out\" />\r\n");
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
            BeginContext(1334, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(1339, 21, false);
#line 25 "C:\Users\andre\Documents\sql capable dv clock in\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
Write(ViewData["firstName"]);

#line default
#line hidden
            EndContext();
            BeginContext(1360, 13, true);
            WriteLiteral(" = \"Penis\";\r\n");
            EndContext();
            BeginContext(1374, 20, false);
#line 26 "C:\Users\andre\Documents\sql capable dv clock in\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
Write(ViewData["lastName"]);

#line default
#line hidden
            EndContext();
            BeginContext(1394, 13, true);
            WriteLiteral(" = \"Penis\";\r\n");
            EndContext();
            BeginContext(1408, 28, false);
#line 27 "C:\Users\andre\Documents\sql capable dv clock in\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
Write(ViewData["personalIDnumber"]);

#line default
#line hidden
            EndContext();
            BeginContext(1436, 13, true);
            WriteLiteral(" = \"Penis\";\r\n");
            EndContext();
            BeginContext(1450, 20, false);
#line 28 "C:\Users\andre\Documents\sql capable dv clock in\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
Write(ViewData["latitude"]);

#line default
#line hidden
            EndContext();
            BeginContext(1470, 13, true);
            WriteLiteral(" = \"Penis\";\r\n");
            EndContext();
            BeginContext(1484, 21, false);
#line 29 "C:\Users\andre\Documents\sql capable dv clock in\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
Write(ViewData["longitude"]);

#line default
#line hidden
            EndContext();
            BeginContext(1505, 13, true);
            WriteLiteral(" = \"Penis\";\r\n");
            EndContext();
            BeginContext(1519, 18, false);
#line 30 "C:\Users\andre\Documents\sql capable dv clock in\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
Write(ViewData["osName"]);

#line default
#line hidden
            EndContext();
            BeginContext(1537, 13, true);
            WriteLiteral(" = \"Penis\";\r\n");
            EndContext();
            BeginContext(1551, 21, false);
#line 31 "C:\Users\andre\Documents\sql capable dv clock in\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
Write(ViewData["osVersion"]);

#line default
#line hidden
            EndContext();
            BeginContext(1572, 13, true);
            WriteLiteral(" = \"Penis\";\r\n");
            EndContext();
            BeginContext(1586, 23, false);
#line 32 "C:\Users\andre\Documents\sql capable dv clock in\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
Write(ViewData["browserName"]);

#line default
#line hidden
            EndContext();
            BeginContext(1609, 13, true);
            WriteLiteral(" = \"Penis\";\r\n");
            EndContext();
            BeginContext(1623, 26, false);
#line 33 "C:\Users\andre\Documents\sql capable dv clock in\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
Write(ViewData["browserVersion"]);

#line default
#line hidden
            EndContext();
            BeginContext(1649, 13, true);
            WriteLiteral(" = \"Penis\";\r\n");
            EndContext();
            BeginContext(1663, 30, false);
#line 34 "C:\Users\andre\Documents\sql capable dv clock in\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
Write(ViewData["navigatorUserAgent"]);

#line default
#line hidden
            EndContext();
            BeginContext(1693, 13, true);
            WriteLiteral(" = \"Penis\";\r\n");
            EndContext();
            BeginContext(1707, 31, false);
#line 35 "C:\Users\andre\Documents\sql capable dv clock in\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
Write(ViewData["navigatorAppVersion"]);

#line default
#line hidden
            EndContext();
            BeginContext(1738, 13, true);
            WriteLiteral(" = \"Penis\";\r\n");
            EndContext();
            BeginContext(1752, 29, false);
#line 36 "C:\Users\andre\Documents\sql capable dv clock in\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
Write(ViewData["navigatorPlatform"]);

#line default
#line hidden
            EndContext();
            BeginContext(1781, 13, true);
            WriteLiteral(" = \"Penis\";\r\n");
            EndContext();
            BeginContext(1795, 27, false);
#line 37 "C:\Users\andre\Documents\sql capable dv clock in\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
Write(ViewData["navigatorVendor"]);

#line default
#line hidden
            EndContext();
            BeginContext(1822, 13, true);
            WriteLiteral(" = \"Penis\";\r\n");
            EndContext();
            BeginContext(1836, 20, false);
#line 38 "C:\Users\andre\Documents\sql capable dv clock in\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
Write(ViewData["dateTime"]);

#line default
#line hidden
            EndContext();
            BeginContext(1856, 356, true);
            WriteLiteral(@" = ""Penis"";

<script>
    function myFunction() {



        getLocation();
        if (document.getElementById(""Validation1"").value == ""Clock In"") {
            document.getElementById(""Validation1"").value = ""Clock Out"";
        }
        else {
            document.getElementById(""Validation1"").value = ""Clock In"";
        }

        if (");
            EndContext();
            BeginContext(2213, 19, false);
#line 53 "C:\Users\andre\Documents\sql capable dv clock in\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
       Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(2232, 181, true);
            WriteLiteral("> 0 & document.getElementById(\"Validation1\").value == \"Welcome Back :)\") {\r\n            document.getElementById(\"Validation1\").value = \"See you later\";\r\n        }\r\n        else if (");
            EndContext();
            BeginContext(2414, 19, false);
#line 56 "C:\Users\andre\Documents\sql capable dv clock in\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
            Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(2433, 6404, true);
            WriteLiteral(@"> 0) {
            document.getElementById(""Validation1"").value = ""Welcome Back :)"";
        }

        var x = document.getElementById(""demo"");

        function getLocation() {
            if (navigator.geolocation) {
                navigator.geolocation.getCurrentPosition(showPosition);
            } else {
                x.innerHTML = ""Geolocation is not supported by this browser."";
            }
        }

        function showPosition(position) {
            x.innerHTML = ""Latitude: "" + position.coords.latitude +
                ""<br>Longitude: "" + position.coords.longitude;
        }




    }
</script>

<button onclick=""myFunction()"">CLICK ME</button>

<p id=""demo""></p>

<script>
    var x = document.getElementById(""demo"");

    function getLocation() {
        if (navigator.geolocation) {
            navigator.geolocation.getCurrentPosition(showPosition);
        } else {
            x.innerHTML = ""Geolocation is not supported by this browser."";
        }
    }");
            WriteLiteral(@"

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
    (function () {
        'use strict';

        var module = {
            options: [],
            header: [navigator.platform, navigator.userAgent, navigator.appVersion, navigator.vendor, window.opera],
            dataos: [
                { name: 'Windows Phone', value: 'Windows Phone', version: 'OS' },
                { name: 'Windows', value: 'Win', version: 'NT' },
                { name: 'iPhone', value: 'iPhone', version: 'OS' },
         ");
            WriteLiteral(@"       { name: 'iPad', value: 'iPad', version: 'OS' },
                { name: 'Kindle', value: 'Silk', version: 'Silk' },
                { name: 'Android', value: 'Android', version: 'Android' },
                { name: 'PlayBook', value: 'PlayBook', version: 'OS' },
                { name: 'BlackBerry', value: 'BlackBerry', version: '/' },
                { name: 'Macintosh', value: 'Mac', version: 'OS X' },
                { name: 'Linux', value: 'Linux', version: 'rv' },
                { name: 'Palm', value: 'Palm', version: 'PalmOS' }
            ],
            databrowser: [
                { name: 'Chrome', value: 'Chrome', version: 'Chrome' },
                { name: 'Firefox', value: 'Firefox', version: 'Firefox' },
                { name: 'Safari', value: 'Safari', version: 'Version' },
                { name: 'Internet Explorer', value: 'MSIE', version: 'MSIE' },
                { name: 'Opera', value: 'Opera', version: 'Opera' },
                { name: 'BlackBerry', value: 'CLDC'");
            WriteLiteral(@", version: 'CLDC' },
                { name: 'Mozilla', value: 'Mozilla', version: 'Mozilla' }
            ],
            init: function () {
                var agent = this.header.join(' '),
                    os = this.matchItem(agent, this.dataos),
                    browser = this.matchItem(agent, this.databrowser);

                return { os: os, browser: browser };
            },
            matchItem: function (string, data) {
                var i = 0,
                    j = 0,
                    html = '',
                    regex,
                    regexv,
                    match,
                    matches,
                    version;

                for (i = 0; i < data.length; i += 1) {
                    regex = new RegExp(data[i].value, 'i');
                    match = regex.test(string);
                    if (match) {
                        regexv = new RegExp(data[i].version + '[- /:;]([\\d._]+)', 'i');
                        matches = string.matc");
            WriteLiteral(@"h(regexv);
                        version = '';
                        if (matches) { if (matches[1]) { matches = matches[1]; } }
                        if (matches) {
                            matches = matches.split(/[._]+/);
                            for (j = 0; j < matches.length; j += 1) {
                                if (j === 0) {
                                    version += matches[j] + '.';
                                } else {
                                    version += matches[j];
                                }
                            }
                        } else {
                            version = '0';
                        }
                        return {
                            name: data[i].name,
                            version: parseFloat(version)
                        };
                    }
                }
                return { name: 'unknown', version: 0 };
            }
        };

        var e = module.init(),");
            WriteLiteral(@"
            debug = '';

        debug += 'os.name = ' + e.os.name + '<br/>';
        debug += 'os.version = ' + e.os.version + '<br/>';
        debug += 'browser.name = ' + e.browser.name + '<br/>';
        debug += 'browser.version = ' + e.browser.version + '<br/>';

        debug += '<br/>';
        debug += 'navigator.userAgent = ' + navigator.userAgent + '<br/>';
        debug += 'navigator.appVersion = ' + navigator.appVersion + '<br/>';
        debug += 'navigator.platform = ' + navigator.platform + '<br/>';
        debug += 'navigator.vendor = ' + navigator.vendor + '<br/>';

        document.getElementById('log').innerHTML = debug;


        var x = document.getElementById(""demo"");
        getLocation();
        document.getElementsById(""FirstName"").value = ""moo"";


        function getLocation() {
            if (navigator.geolocation) {
                navigator.geolocation.getCurrentPosition(showPosition);
            } else {
                x.innerHTML = ""Geolocation is");
            WriteLiteral(@" not supported by this browser."";
            }
        }

        function showPosition(position) {
            x.innerHTML = ""Latitude: "" + position.coords.latitude +
                ""<br>Longitude: "" + position.coords.longitude;
        }

        ");
            EndContext();
            BeginContext(8838, 21, false);
#line 224 "C:\Users\andre\Documents\sql capable dv clock in\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
   Write(ViewData["firstName"]);

#line default
#line hidden
            EndContext();
            BeginContext(8859, 13, true);
            WriteLiteral(" = \"Penis\";\r\n");
            EndContext();
            BeginContext(8873, 20, false);
#line 225 "C:\Users\andre\Documents\sql capable dv clock in\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
Write(ViewData["lastName"]);

#line default
#line hidden
            EndContext();
            BeginContext(8893, 13, true);
            WriteLiteral(" = \"Penis\";\r\n");
            EndContext();
            BeginContext(8907, 28, false);
#line 226 "C:\Users\andre\Documents\sql capable dv clock in\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
Write(ViewData["personalIDnumber"]);

#line default
#line hidden
            EndContext();
            BeginContext(8935, 13, true);
            WriteLiteral(" = \"Penis\";\r\n");
            EndContext();
            BeginContext(8949, 20, false);
#line 227 "C:\Users\andre\Documents\sql capable dv clock in\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
Write(ViewData["latitude"]);

#line default
#line hidden
            EndContext();
            BeginContext(8969, 13, true);
            WriteLiteral(" = \"Penis\";\r\n");
            EndContext();
            BeginContext(8983, 21, false);
#line 228 "C:\Users\andre\Documents\sql capable dv clock in\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
Write(ViewData["longitude"]);

#line default
#line hidden
            EndContext();
            BeginContext(9004, 13, true);
            WriteLiteral(" = \"Penis\";\r\n");
            EndContext();
            BeginContext(9018, 18, false);
#line 229 "C:\Users\andre\Documents\sql capable dv clock in\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
Write(ViewData["osName"]);

#line default
#line hidden
            EndContext();
            BeginContext(9036, 13, true);
            WriteLiteral(" = \"Penis\";\r\n");
            EndContext();
            BeginContext(9050, 21, false);
#line 230 "C:\Users\andre\Documents\sql capable dv clock in\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
Write(ViewData["osVersion"]);

#line default
#line hidden
            EndContext();
            BeginContext(9071, 13, true);
            WriteLiteral(" = \"Penis\";\r\n");
            EndContext();
            BeginContext(9085, 23, false);
#line 231 "C:\Users\andre\Documents\sql capable dv clock in\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
Write(ViewData["browserName"]);

#line default
#line hidden
            EndContext();
            BeginContext(9108, 13, true);
            WriteLiteral(" = \"Penis\";\r\n");
            EndContext();
            BeginContext(9122, 26, false);
#line 232 "C:\Users\andre\Documents\sql capable dv clock in\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
Write(ViewData["browserVersion"]);

#line default
#line hidden
            EndContext();
            BeginContext(9148, 13, true);
            WriteLiteral(" = \"Penis\";\r\n");
            EndContext();
            BeginContext(9162, 30, false);
#line 233 "C:\Users\andre\Documents\sql capable dv clock in\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
Write(ViewData["navigatorUserAgent"]);

#line default
#line hidden
            EndContext();
            BeginContext(9192, 13, true);
            WriteLiteral(" = \"Penis\";\r\n");
            EndContext();
            BeginContext(9206, 31, false);
#line 234 "C:\Users\andre\Documents\sql capable dv clock in\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
Write(ViewData["navigatorAppVersion"]);

#line default
#line hidden
            EndContext();
            BeginContext(9237, 13, true);
            WriteLiteral(" = \"Penis\";\r\n");
            EndContext();
            BeginContext(9251, 29, false);
#line 235 "C:\Users\andre\Documents\sql capable dv clock in\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
Write(ViewData["navigatorPlatform"]);

#line default
#line hidden
            EndContext();
            BeginContext(9280, 13, true);
            WriteLiteral(" = \"Penis\";\r\n");
            EndContext();
            BeginContext(9294, 27, false);
#line 236 "C:\Users\andre\Documents\sql capable dv clock in\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
Write(ViewData["navigatorVendor"]);

#line default
#line hidden
            EndContext();
            BeginContext(9321, 13, true);
            WriteLiteral(" = \"Penis\";\r\n");
            EndContext();
            BeginContext(9335, 20, false);
#line 237 "C:\Users\andre\Documents\sql capable dv clock in\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
Write(ViewData["dateTime"]);

#line default
#line hidden
            EndContext();
            BeginContext(9355, 43, true);
            WriteLiteral(" = \"Penis\";\r\n\r\n    }());\r\n</script>\r\n\r\n\r\n\r\n");
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
