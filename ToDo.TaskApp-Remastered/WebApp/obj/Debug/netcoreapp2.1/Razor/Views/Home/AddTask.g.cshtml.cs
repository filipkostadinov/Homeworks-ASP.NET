#pragma checksum "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Homeworks-ASP.NET\ToDo.TaskApp-Remastered\WebApp\Views\Home\AddTask.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "345b86a0ce009edb557a79beb9ff2065580e70b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AddTask), @"mvc.1.0.view", @"/Views/Home/AddTask.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/AddTask.cshtml", typeof(AspNetCore.Views_Home_AddTask))]
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
#line 1 "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Homeworks-ASP.NET\ToDo.TaskApp-Remastered\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"345b86a0ce009edb557a79beb9ff2065580e70b2", @"/Views/Home/AddTask.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0eb012e07f2e2a6d8bcab9f8c8fba5c920479a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AddTask : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TaskViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Homeworks-ASP.NET\ToDo.TaskApp-Remastered\WebApp\Views\Home\AddTask.cshtml"
  
    ViewBag.Title = "New ToDo Task ";

#line default
#line hidden
            BeginContext(70, 29, true);
            WriteLiteral("\r\n<h3>Add a new task</h3>\r\n\r\n");
            EndContext();
#line 9 "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Homeworks-ASP.NET\ToDo.TaskApp-Remastered\WebApp\Views\Home\AddTask.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(129, 78, true);
            WriteLiteral("    <div class=\"form-group row\">\r\n        <div class=\"col-md-4\">\r\n            ");
            EndContext();
            BeginContext(208, 27, false);
#line 13 "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Homeworks-ASP.NET\ToDo.TaskApp-Remastered\WebApp\Views\Home\AddTask.cshtml"
       Write(Html.LabelFor(x => x.Title));

#line default
#line hidden
            EndContext();
            BeginContext(235, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(250, 62, false);
#line 14 "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Homeworks-ASP.NET\ToDo.TaskApp-Remastered\WebApp\Views\Home\AddTask.cshtml"
       Write(Html.TextBoxFor(x => x.Title, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(312, 108, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group row\">\r\n        <div class=\"col-md-4\">\r\n            ");
            EndContext();
            BeginContext(421, 33, false);
#line 19 "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Homeworks-ASP.NET\ToDo.TaskApp-Remastered\WebApp\Views\Home\AddTask.cshtml"
       Write(Html.LabelFor(x => x.Description));

#line default
#line hidden
            EndContext();
            BeginContext(454, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(469, 68, false);
#line 20 "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Homeworks-ASP.NET\ToDo.TaskApp-Remastered\WebApp\Views\Home\AddTask.cshtml"
       Write(Html.TextBoxFor(x => x.Description, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(537, 108, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group row\">\r\n        <div class=\"col-md-4\">\r\n            ");
            EndContext();
            BeginContext(646, 30, false);
#line 25 "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Homeworks-ASP.NET\ToDo.TaskApp-Remastered\WebApp\Views\Home\AddTask.cshtml"
       Write(Html.LabelFor(x => x.Priority));

#line default
#line hidden
            EndContext();
            BeginContext(676, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(691, 120, false);
#line 26 "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Homeworks-ASP.NET\ToDo.TaskApp-Remastered\WebApp\Views\Home\AddTask.cshtml"
       Write(Html.DropDownListFor(x => x.Priority, Html.GetEnumSelectList(Model.Priority.GetType()), new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(811, 108, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group row\">\r\n        <div class=\"col-md-4\">\r\n            ");
            EndContext();
            BeginContext(920, 32, false);
#line 31 "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Homeworks-ASP.NET\ToDo.TaskApp-Remastered\WebApp\Views\Home\AddTask.cshtml"
       Write(Html.LabelFor(x => x.TypeOfTask));

#line default
#line hidden
            EndContext();
            BeginContext(952, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(967, 124, false);
#line 32 "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Homeworks-ASP.NET\ToDo.TaskApp-Remastered\WebApp\Views\Home\AddTask.cshtml"
       Write(Html.DropDownListFor(x => x.TypeOfTask, Html.GetEnumSelectList(Model.TypeOfTask.GetType()), new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1091, 122, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <br />\r\n    <br />\r\n    <button type=\"submit\" class=\"btn btn-danger\">Add Task</button>\r\n");
            EndContext();
#line 38 "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Homeworks-ASP.NET\ToDo.TaskApp-Remastered\WebApp\Views\Home\AddTask.cshtml"

}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TaskViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
