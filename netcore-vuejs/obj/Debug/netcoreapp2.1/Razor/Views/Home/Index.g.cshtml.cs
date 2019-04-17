#pragma checksum "C:\sourceCode\netcore-vuejs\netcore-vuejs\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e52181c72b25ddd4ae091c6218e85886c320b68"
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
#line 1 "C:\sourceCode\netcore-vuejs\netcore-vuejs\Views\_ViewImports.cshtml"
using netcore_vuejs;

#line default
#line hidden
#line 2 "C:\sourceCode\netcore-vuejs\netcore-vuejs\Views\_ViewImports.cshtml"
using netcore_vuejs.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e52181c72b25ddd4ae091c6218e85886c320b68", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25a39e8eda779461505a488e105db0dd3addff99", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 880, true);
            WriteLiteral(@"<h1>Getting Started with Vue.js in .NET Core</h1>

<div id=""form"">
    <p>
        <label>Full Name</label>
        <input type=""text"" placeholder=""Enter your full name"" v-model=""FullName"" />
    </p>

    <p>
        <label>Email</label>
        <input type=""text"" placeholder=""Enter your email"" v-model=""Email"" v-on:blur=""CheckEmail""/>
        <span class=""invalid-input"" v-show=""InvalidEmail"">Invalid Email</span>
    </p>

    <p>
        <label>Comments</label>
        <textarea rows=""10"" placeholder=""Enter some positive comments"" v-model=""Comments""></textarea>
    </p>

    <div id=""form-buttons"">
        <button type=""button"" class=""danger"" v-on:click=""ResetForm"">Reset Form</button>
        <button type=""button"" class=""success"" ref=""SubmitButton"" v-bind:disabled=""isSubmitDisabled"" v-on:click=""SubmitForm"">Submit Form</button>
    </div>
</div>");
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
