#pragma checksum "C:\Users\user\Desktop\cloudpro\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac5cd3ddf5ba315d9d2d0311f48e0f17940a7e09"
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
#line 1 "C:\Users\user\Desktop\cloudpro\Views\_ViewImports.cshtml"
using cloudpro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\cloudpro\Views\_ViewImports.cshtml"
using cloudpro.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac5cd3ddf5ba315d9d2d0311f48e0f17940a7e09", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0445acb06e332c3477b09621d58cd2118d576a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\user\Desktop\cloudpro\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    \r\n</div>\r\n<html>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac5cd3ddf5ba315d9d2d0311f48e0f17940a7e093367", async() => {
                WriteLiteral(@"
        <meta charset=""utf-8""/>
        <script type=""text/javascript"" src=""https://code.jquery.com/jquery-3.5.1.min.js""></script>
        <script>
        var html = [];
            $.getJSON('agencydb.json', function (data) {
                $.each(data, function (i,item) { // ???????????? json ???????????? ??? 8?????? ????????? ????????????.
                    html.push(Number(item.latitude)); // ??????: html[0]
                    html.push(Number(item.longitude)); // ??????: html[1]
                    html.push(item.address); // ??????: html[2]
                    html.push(item.phone_number); // ????????????: html[3]
                    html.push(item.agency_name); // ?????????: html[4]
                    html.push(item.weekday_oph); // ?????? ????????????: html[5]
                    html.push(item.saturday_oph); // ????????? ????????????: html[6]
                    html.push(item.holiday_oph); // ????????? ????????????: html[7]
                });
            });
    </script>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac5cd3ddf5ba315d9d2d0311f48e0f17940a7e095265", async() => {
                WriteLiteral(@"
        <div id=""map"" style=""width:100%;height:100vh;""></div>
        <script type=""text/javascript"" src=""//dapi.kakao.com/v2/maps/sdk.js?appkey=5c62ac48e750ab2a75bf3d70c5ff020f""></script>
        <script>
            var mapContainer = document.getElementById('map'), // ????????? ????????? div 
                mapOption = { 
                    center: new kakao.maps.LatLng(35.18372275855777, 129.07488466018773), // ????????? ????????????: ??????????????????
                    level: 9 // ????????? ?????? ??????
                };
            // ????????? ????????? div???  ?????? ????????????  ????????? ???????????????
            var map = new kakao.maps.Map(mapContainer, mapOption);

            // ????????? ??????????????? ??????????????? ??????????????? ???????????????
            map.addOverlayMapTypeId(kakao.maps.MapTypeId.TRAFFIC);

            // ????????? ??????????????? ??????????????? ??????????????? ???????????????
            map.addOverlayMapTypeId(kakao.maps.MapTypeId.TERRAIN);

            // ?????? ?????????????????? ????????????
            var clusterer = new kakao.maps.MarkerClusterer({
                map: map, // ???????????? ??????????????? ???????????? ????????? ?????? ??????
                averageCenter: ");
                WriteLiteral(@"true, // ??????????????? ????????? ???????????? ?????? ????????? ???????????? ?????? ????????? ??????
                minLevel: 10 // ???????????? ??? ?????? ?????? ??????
            });

            var markers = [];

            for(var i=0; i<html.length; i++){
                if(i%8==0){ // json ???????????? ????????? 8?????? ???????????? ??? ?????????????????? ????????? ????????? ?????????
                var markerPosition = new kakao.maps.LatLng(html[i], html[i+1]);

                // ????????? ????????????
                var marker = new kakao.maps.Marker({
                    position: markerPosition
                });

                // ????????? ?????? ?????? ??????????????? ????????????
                marker.setMap(map);
                var iwContent = (` ?????????: ` + html[i+4] + `\n ??????: ` + html[i+2] + `\n ????????????: ` + html[i+3] + `\n ?????? ????????????: ` + html[i+5] + `\n ????????? ????????????: ` + html[i+6] + `\n ????????? ????????????: ` + html[i+7]), // ?????????????????? ????????? ??????
                    iwPosition = new kakao.maps.LatLng(html[i], html[i+1]); // ??????????????? ?????? ??????

                // ?????????????????? ???????????????
                var infowindow = new kakao.maps.InfoWindow({
                    position: iwPositi");
                WriteLiteral(@"on,
                    content: iwContent
                    });
                markers.push(marker);            
                // ????????? ??????????????? ???????????? ????????? ??????????????? 
                kakao.maps.event.addListener(marker, 'mouseover', makeOverListener(map, marker, infowindow));
                kakao.maps.event.addListener(marker, 'mouseout', makeOutListener(infowindow));
                }
            };

            // ?????????????????? ???????????? ???????????????
            clusterer.addMarkers(markers);

            // ?????????????????? ???????????? ???????????? ????????? ??????????????? 
            function makeOverListener(map, marker, infowindow) {
                return function () {
                    infowindow.open(map, marker);
                };
            }

            // ?????????????????? ?????? ???????????? ????????? ??????????????? 
            function makeOutListener(infowindow) {
                return function () {
                    infowindow.close();
                };
            }
        </script>
        <div>
            <p>Learn about <a href=""https://docs.micros");
                WriteLiteral("oft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
