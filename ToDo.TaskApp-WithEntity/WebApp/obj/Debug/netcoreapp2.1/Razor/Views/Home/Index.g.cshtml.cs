#pragma checksum "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Homeworks-ASP.NET\ToDo.TaskApp-WithEntity\WebApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2655bf6913607abf281b8746241afa9f697e155c"
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
#line 1 "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Homeworks-ASP.NET\ToDo.TaskApp-WithEntity\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2655bf6913607abf281b8746241afa9f697e155c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0eb012e07f2e2a6d8bcab9f8c8fba5c920479a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TaskViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Homeworks-ASP.NET\ToDo.TaskApp-WithEntity\WebApp\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Home";

#line default
#line hidden
            BeginContext(73, 29, true);
            WriteLiteral("\r\n<table class=\"table\">\r\n    ");
            EndContext();
            BeginContext(103, 50, false);
#line 8 "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Homeworks-ASP.NET\ToDo.TaskApp-WithEntity\WebApp\Views\Home\Index.cshtml"
Write(Html.Partial("~/Views/Shared/_HeaderTable.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(153, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 10 "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Homeworks-ASP.NET\ToDo.TaskApp-WithEntity\WebApp\Views\Home\Index.cshtml"
     foreach (var task in Model)
    {
        

#line default
#line hidden
            BeginContext(207, 55, false);
#line 12 "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Homeworks-ASP.NET\ToDo.TaskApp-WithEntity\WebApp\Views\Home\Index.cshtml"
   Write(Html.Partial("~/Views/Shared/_TableTasks.cshtml", task));

#line default
#line hidden
            EndContext();
#line 12 "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Homeworks-ASP.NET\ToDo.TaskApp-WithEntity\WebApp\Views\Home\Index.cshtml"
                                                                
    }

#line default
#line hidden
            BeginContext(271, 49, true);
            WriteLiteral("</table>\r\n<br />\r\n<button class=\"btn btn-danger\">");
            EndContext();
            BeginContext(321, 46, false);
#line 16 "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Homeworks-ASP.NET\ToDo.TaskApp-WithEntity\WebApp\Views\Home\Index.cshtml"
                          Write(Html.ActionLink("Add task", "AddTask", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(367, 11, true);
            WriteLiteral("</button>\r\n");
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
