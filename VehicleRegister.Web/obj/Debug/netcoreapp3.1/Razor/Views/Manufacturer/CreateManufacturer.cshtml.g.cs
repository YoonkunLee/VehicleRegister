#pragma checksum "C:\Users\Yoonkun Lee\Desktop\projects\New Delhi\VehicleRegister\VehicleRegister.Web\Views\Manufacturer\CreateManufacturer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b62b1fab9345550e9030c1b6540bfc4792e9d446"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manufacturer_CreateManufacturer), @"mvc.1.0.view", @"/Views/Manufacturer/CreateManufacturer.cshtml")]
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
#line 1 "C:\Users\Yoonkun Lee\Desktop\projects\New Delhi\VehicleRegister\VehicleRegister.Web\Views\_ViewImports.cshtml"
using VehicleRegister.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Yoonkun Lee\Desktop\projects\New Delhi\VehicleRegister\VehicleRegister.Web\Views\_ViewImports.cshtml"
using VehicleRegister.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b62b1fab9345550e9030c1b6540bfc4792e9d446", @"/Views/Manufacturer/CreateManufacturer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e18ea022ea74717d0ff7aea4c8e512d2c8ab29a", @"/Views/_ViewImports.cshtml")]
    public class Views_Manufacturer_CreateManufacturer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VehicleRegister.Model.Manufacturer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Yoonkun Lee\Desktop\projects\New Delhi\VehicleRegister\VehicleRegister.Web\Views\Manufacturer\CreateManufacturer.cshtml"
  
    ViewData["Title"] = "CreateManufacturer";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3 class=\"titleMargin\">Create Manufacturer</h3>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\Yoonkun Lee\Desktop\projects\New Delhi\VehicleRegister\VehicleRegister.Web\Views\Manufacturer\CreateManufacturer.cshtml"
 using (Html.BeginForm("Create", "Manufacturer", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Yoonkun Lee\Desktop\projects\New Delhi\VehicleRegister\VehicleRegister.Web\Views\Manufacturer\CreateManufacturer.cshtml"
Write(Html.LabelFor(m => m.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Yoonkun Lee\Desktop\projects\New Delhi\VehicleRegister\VehicleRegister.Web\Views\Manufacturer\CreateManufacturer.cshtml"
Write(Html.TextBoxFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input class=\"waves-effect waves-light btn-large blue submitButton\" type=\"submit\" value=\"Submit\" />\r\n");
#nullable restore
#line 14 "C:\Users\Yoonkun Lee\Desktop\projects\New Delhi\VehicleRegister\VehicleRegister.Web\Views\Manufacturer\CreateManufacturer.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VehicleRegister.Model.Manufacturer> Html { get; private set; }
    }
}
#pragma warning restore 1591
