#pragma checksum "C:\Users\Filip Kostadinov\source\repos\ToDo\ToDo\Views\Home\AllDoneTasks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "638a9150663a0ee6ecfc04848cec7e3a09c16d5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AllDoneTasks), @"mvc.1.0.view", @"/Views/Home/AllDoneTasks.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/AllDoneTasks.cshtml", typeof(AspNetCore.Views_Home_AllDoneTasks))]
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
#line 1 "C:\Users\Filip Kostadinov\source\repos\ToDo\ToDo\Views\_ViewImports.cshtml"
using ToDo.Models.DomainModels;

#line default
#line hidden
#line 2 "C:\Users\Filip Kostadinov\source\repos\ToDo\ToDo\Views\_ViewImports.cshtml"
using ToDo.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"638a9150663a0ee6ecfc04848cec7e3a09c16d5f", @"/Views/Home/AllDoneTasks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52726f6fed68f7ce930e8fa56b3f0be80ba0a919", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AllDoneTasks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TaskViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Filip Kostadinov\source\repos\ToDo\ToDo\Views\Home\AllDoneTasks.cshtml"
  
    ViewData["Title"] = "All Finished Tasks";

#line default
#line hidden
            BeginContext(91, 15, true);
            WriteLiteral("\r\n<table>\r\n    ");
            EndContext();
            BeginContext(107, 50, false);
#line 8 "C:\Users\Filip Kostadinov\source\repos\ToDo\ToDo\Views\Home\AllDoneTasks.cshtml"
Write(Html.Partial("~/Views/Shared/_HeaderTable.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(157, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 10 "C:\Users\Filip Kostadinov\source\repos\ToDo\ToDo\Views\Home\AllDoneTasks.cshtml"
     foreach (var task in Model)
    {
        

#line default
#line hidden
            BeginContext(211, 55, false);
#line 12 "C:\Users\Filip Kostadinov\source\repos\ToDo\ToDo\Views\Home\AllDoneTasks.cshtml"
   Write(Html.Partial("~/Views/Shared/_TableTasks.cshtml", task));

#line default
#line hidden
            EndContext();
#line 12 "C:\Users\Filip Kostadinov\source\repos\ToDo\ToDo\Views\Home\AllDoneTasks.cshtml"
                                                                
    }

#line default
#line hidden
            BeginContext(275, 10, true);
            WriteLiteral("\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TaskViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
