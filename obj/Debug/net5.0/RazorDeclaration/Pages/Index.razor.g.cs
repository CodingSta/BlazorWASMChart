// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FirstWeb.Pages
{
    #line hidden
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 3 "/Users/codingstar/Documents/workspaces_Blazor/FirstWeb/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/codingstar/Documents/workspaces_Blazor/FirstWeb/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/codingstar/Documents/workspaces_Blazor/FirstWeb/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/codingstar/Documents/workspaces_Blazor/FirstWeb/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/codingstar/Documents/workspaces_Blazor/FirstWeb/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/codingstar/Documents/workspaces_Blazor/FirstWeb/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/codingstar/Documents/workspaces_Blazor/FirstWeb/_Imports.razor"
using FirstWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/codingstar/Documents/workspaces_Blazor/FirstWeb/_Imports.razor"
using FirstWeb.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/codingstar/Documents/workspaces_Blazor/FirstWeb/Pages/Index.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/codingstar/Documents/workspaces_Blazor/FirstWeb/Pages/Index.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/codingstar/Documents/workspaces_Blazor/FirstWeb/Pages/Index.razor"
using System.Net.NetworkInformation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/codingstar/Documents/workspaces_Blazor/FirstWeb/Pages/Index.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/codingstar/Documents/workspaces_Blazor/FirstWeb/Pages/Index.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/codingstar/Documents/workspaces_Blazor/FirstWeb/Pages/Index.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/codingstar/Documents/workspaces_Blazor/FirstWeb/Pages/Index.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/codingstar/Documents/workspaces_Blazor/FirstWeb/Pages/Index.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/codingstar/Documents/workspaces_Blazor/FirstWeb/Pages/Index.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/codingstar/Documents/workspaces_Blazor/FirstWeb/Pages/Index.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/codingstar/Documents/workspaces_Blazor/FirstWeb/Pages/Index.razor"
using System.Collections;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/codingstar/Documents/workspaces_Blazor/FirstWeb/Pages/Index.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "/Users/codingstar/Documents/workspaces_Blazor/FirstWeb/Pages/Index.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "/Users/codingstar/Documents/workspaces_Blazor/FirstWeb/Pages/Index.razor"
using System.Reflection;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "/Users/codingstar/Documents/workspaces_Blazor/FirstWeb/Pages/Index.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "/Users/codingstar/Documents/workspaces_Blazor/FirstWeb/Pages/Index.razor"
using System.IO.Compression;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "/Users/codingstar/Documents/workspaces_Blazor/FirstWeb/Pages/Index.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "/Users/codingstar/Documents/workspaces_Blazor/FirstWeb/Pages/Index.razor"
using WebAssemblyMan;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "/Users/codingstar/Documents/workspaces_Blazor/FirstWeb/Pages/Index.razor"
       
    string Data01 = "90,80,70,60,50,40,30,20,10";
    string Data02 = "10,20,30,40,50,60,70,80,90";
    string AlarmData = "";
    TempHumi[] responseBody;
    HttpResponseMessage responseBodyB;

    Task getData()
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "/Users/codingstar/Documents/workspaces_Blazor/FirstWeb/Pages/Index.razor"
                                                    
        return Task.CompletedTask;
    }

    private async Task PostRequest()
    {
        responseBody = await Http.GetFromJsonAsync<TempHumi[]>("https://busanbridge.azurewebsites.net/api/ReadBridgeData?code=fTosNwh80TYRjnlOW/MeIiuuRM/4ecaziGK1xP8oqVsVOOkK6UXz3w==");
        Data01 = "";
        Data02 = "";
        int i = 0;
        foreach (var itemA in responseBody)
        {
            Data01 = Data01 + itemA.temp + ",";
            Data02 = Data02 + itemA.humi + ",";
            i++;
            if (i == 30) break;
        }
        Data01.Remove(Data01.Length - 1, 1);
        Data02.Remove(Data02.Length - 1, 1);
    }

    private async Task PostJsonWithReq()
    {
        var postJSON = new ReadAlarm { Period = "total", Ship = "lp01" };
        var jsonA = JsonConvert.SerializeObject(postJSON);
        var dataZ = new StringContent(content: jsonA, encoding: Encoding.UTF8, mediaType: "application/json");
        responseBodyB = await Http.PostAsync("https://hsdfun.azurewebsites.net/api/ReadAlarmData?code=OAfmLwMZgtfHRsT3Rti1nhfnftJiz1zMZ8D1afZuZKuQczSh1slJRw==", dataZ);
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "/Users/codingstar/Documents/workspaces_Blazor/FirstWeb/Pages/Index.razor"
                                                                          

        var contentA = await responseBodyB.Content.ReadFromJsonAsync<Alarm>();
        AlarmData = string.Join(string.Empty, contentA.EMO);

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "/Users/codingstar/Documents/workspaces_Blazor/FirstWeb/Pages/Index.razor"
                                                                                                                       
    }

    public class ReadAlarm
    {
        public string Period { get; set; }
        public string Ship { get; set; }
    }

    public class TempHumi
    {
        public string time { get; set; }
        public string temp { get; set; }
        public string humi { get; set; }
        public string pressure { get; set; }
        public float height { get; set; }
    }

    public class Alarm
    {
        public int[] EMO { get; set; }
        public int[] ENG { get; set; }
        public int[] AMU3395 { get; set; }
        public int[] AP3386 { get; set; }
        public int[] TE3301 { get; set; }
        public int[] PT8601 { get; set; }
        public int[] TE3305 { get; set; }
        public int[] TC3201 { get; set; }
        public int[] TC1101 { get; set; }
        public int[] TC1111 { get; set; }
        public int[] PDT1121 { get; set; }
        public int[] CPV3271 { get; set; }
        public int[] CPV3272 { get; set; }
        public int[] CPV3273 { get; set; }
        public int[] CPV3275 { get; set; }
        public int[] CSV3276 { get; set; }
        public int[] BL2500_01 { get; set; }
        public int[] BL2772_01 { get; set; }
        public int[] BL2772_02 { get; set; }
        public int[] BU2700 { get; set; }
        public int[] CSV2775_01 { get; set; }
        public int[] CSV2775_02 { get; set; }
        public int[] TC2301 { get; set; }
        public int[] TC2401 { get; set; }
        public int[] FT2241 { get; set; }
        public int[] FT2742 { get; set; }
        public int[] PT2125 { get; set; }
        public int[] FT2141 { get; set; }
        public int[] FS2140 { get; set; }
        public int[] FS2142 { get; set; }
        public int[] PM2175 { get; set; }
        public int[] PM2176 { get; set; }
        public int[] PP2770_01 { get; set; }
        public int[] PP2770_02 { get; set; }
        public int[] TE9901 { get; set; }
        public int[] LM9981 { get; set; }
        public int[] LM9985 { get; set; }
        public int[] PS2121 { get; set; }
        public int[] PT2121 { get; set; }
        public int[] PS2123 { get; set; }
        public int[] PS2521 { get; set; }
        public int[] FS2541 { get; set; }
        public int[] PS2525 { get; set; }
        public int[] PS1321 { get; set; }
        public int[] PS1322 { get; set; }
        public int[] PS1323 { get; set; }
        public int[] PT1323 { get; set; }
        public int[] PS2721 { get; set; }
        public int[] PS2725 { get; set; }
        public int[] PS2730 { get; set; }
        public int[] NOxS3242 { get; set; }
        public int[] INFO { get; set; }
        public int[] PWR { get; set; }
        public int[] COMM { get; set; }
        public int[] INFO_2 { get; set; }
        public int[] CSV3271 { get; set; }
        public int[] CSV3272 { get; set; }
        public string update_time { get; set; }
    }



    protected override async Task OnInitializedAsync()
    {
        await getData();
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 193 "/Users/codingstar/Documents/workspaces_Blazor/FirstWeb/Pages/Index.razor"
                                  
        await PostJsonWithReq();
    }

    protected override void OnAfterRender(bool firstRender)
    {
        if (firstRender)
        {

        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
