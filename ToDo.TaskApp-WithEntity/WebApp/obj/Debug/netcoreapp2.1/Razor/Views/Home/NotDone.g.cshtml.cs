#pragma checksum "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Homeworks-ASP.NET\ToDo.TaskApp-WithEntity\WebApp\Views\Home\NotDone.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95e0202f68fbee75435cd38ef91ce798647a084c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_NotDone), @"mvc.1.0.view", @"/Views/Home/NotDone.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/NotDone.cshtml", typeof(AspNetCore.Views_Home_NotDone))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95e0202f68fbee75435cd38ef91ce798647a084c", @"/Views/Home/NotDone.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0eb012e07f2e2a6d8bcab9f8c8fba5c920479a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_NotDone : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TaskViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Homeworks-ASP.NET\ToDo.TaskApp-WithEntity\WebApp\Views\Home\NotDone.cshtml"
  
    ViewBag.Title = "Unfinished tasks";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(130, 29, true);
            WriteLiteral("\r\n<table class=\"table\">\r\n    ");
            EndContext();
            BeginContext(160, 50, false);
#line 8 "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Homeworks-ASP.NET\ToDo.TaskApp-WithEntity\WebApp\Views\Home\NotDone.cshtml"
Write(Html.Partial("~/Views/Shared/_HeaderTable.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(210, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 10 "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Homeworks-ASP.NET\ToDo.TaskApp-WithEntity\WebApp\Views\Home\NotDone.cshtml"
     foreach (var task in Model)
    {
        

#line default
#line hidden
            BeginContext(264, 55, false);
#line 12 "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Homeworks-ASP.NET\ToDo.TaskApp-WithEntity\WebApp\Views\Home\NotDone.cshtml"
   Write(Html.Partial("~/Views/Shared/_TableTasks.cshtml", task));

#line default
#line hidden
            EndContext();
#line 12 "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Homeworks-ASP.NET\ToDo.TaskApp-WithEntity\WebApp\Views\Home\NotDone.cshtml"
                                                                
    }

#line default
#line hidden
            BeginContext(328, 49, true);
            WriteLiteral("</table>\r\n<br />\r\n<button class=\"btn btn-danger\">");
            EndContext();
            BeginContext(378, 46, false);
#line 16 "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Homeworks-ASP.NET\ToDo.TaskApp-WithEntity\WebApp\Views\Home\NotDone.cshtml"
                          Write(Html.ActionLink("Add task", "AddTask", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(424, 9, true);
            WriteLiteral("</button>");
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
