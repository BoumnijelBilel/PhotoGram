#pragma checksum "E:\autre\HEXAGONE\API\PROJECT EVALUATION\PROJECT_BILEL_BOUMNIJEL_PHOTGRAM\PhotoGram\Pages\Account\ConfirmEmail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e5fb472ad546ebb1f18bffcfc76664f77182393"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CorePhotoGram.Pages.Account.Pages_Account_ConfirmEmail), @"mvc.1.0.razor-page", @"/Pages/Account/ConfirmEmail.cshtml")]
namespace CorePhotoGram.Pages.Account
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
#line 1 "E:\autre\HEXAGONE\API\PROJECT EVALUATION\PROJECT_BILEL_BOUMNIJEL_PHOTGRAM\PhotoGram\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\autre\HEXAGONE\API\PROJECT EVALUATION\PROJECT_BILEL_BOUMNIJEL_PHOTGRAM\PhotoGram\Pages\_ViewImports.cshtml"
using CorePhotoGram;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\autre\HEXAGONE\API\PROJECT EVALUATION\PROJECT_BILEL_BOUMNIJEL_PHOTGRAM\PhotoGram\Pages\_ViewImports.cshtml"
using CorePhotoGram.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\autre\HEXAGONE\API\PROJECT EVALUATION\PROJECT_BILEL_BOUMNIJEL_PHOTGRAM\PhotoGram\Pages\Account\_ViewImports.cshtml"
using CorePhotoGram.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e5fb472ad546ebb1f18bffcfc76664f77182393", @"/Pages/Account/ConfirmEmail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4424299950075789fe38274e79a70cea4d23b34", @"/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2e1c7c17b68b47e02653f18baec501ef05e513c", @"/Pages/Account/_ViewImports.cshtml")]
    public class Pages_Account_ConfirmEmail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\autre\HEXAGONE\API\PROJECT EVALUATION\PROJECT_BILEL_BOUMNIJEL_PHOTGRAM\PhotoGram\Pages\Account\ConfirmEmail.cshtml"
  
    ViewData["Title"] = "Confirm email";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>");
#nullable restore
#line 7 "E:\autre\HEXAGONE\API\PROJECT EVALUATION\PROJECT_BILEL_BOUMNIJEL_PHOTGRAM\PhotoGram\Pages\Account\ConfirmEmail.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n<div>\n    <p>\n        Merci d\'avoir confirm� votre email.\n    </p>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConfirmEmailModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ConfirmEmailModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ConfirmEmailModel>)PageContext?.ViewData;
        public ConfirmEmailModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
