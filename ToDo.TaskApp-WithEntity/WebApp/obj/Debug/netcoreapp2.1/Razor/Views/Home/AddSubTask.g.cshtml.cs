#pragma checksum "C:\Users\Filip Kostadinov\Desktop\ToDo.TaskApp-Remastered\WebApp\Views\Home\AddSubTask.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bbc6334af8369a92e757b038cd8c0c34d3576fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AddSubTask), @"mvc.1.0.view", @"/Views/Home/AddSubTask.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/AddSubTask.cshtml", typeof(AspNetCore.Views_Home_AddSubTask))]
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
#line 1 "C:\Users\Filip Kostadinov\Desktop\ToDo.TaskApp-Remastered\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bbc6334af8369a92e757b038cd8c0c34d3576fd", @"/Views/Home/AddSubTask.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0eb012e07f2e2a6d8bcab9f8c8fba5c920479a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AddSubTask : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SubTaskViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(25, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Filip Kostadinov\Desktop\ToDo.TaskApp-Remastered\WebApp\Views\Home\AddSubTask.cshtml"
  
    ViewBag.Title = "Add Sub Task";

#line default
#line hidden
            BeginContext(71, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\Filip Kostadinov\Desktop\ToDo.TaskApp-Remastered\WebApp\Views\Home\AddSubTask.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(103, 78, true);
            WriteLiteral("    <div class=\"form-group row\">\r\n        <div class=\"col-md-4\">\r\n            ");
            EndContext();
            BeginContext(182, 33, false);
#line 11 "C:\Users\Filip Kostadinov\Desktop\ToDo.TaskApp-Remastered\WebApp\Views\Home\AddSubTask.cshtml"
       Write(Html.HiddenFor(x => x.ToDoTaskId));

#line default
#line hidden
            EndContext();
            BeginContext(215, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(230, 27, false);
#line 12 "C:\Users\Filip Kostadinov\Desktop\ToDo.TaskApp-Remastered\WebApp\Views\Home\AddSubTask.cshtml"
       Write(Html.LabelFor(x => x.Title));

#line default
#line hidden
            EndContext();
            BeginContext(257, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(272, 62, false);
#line 13 "C:\Users\Filip Kostadinov\Desktop\ToDo.TaskApp-Remastered\WebApp\Views\Home\AddSubTask.cshtml"
       Write(Html.TextBoxFor(x => x.Title, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(334, 108, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group row\">\r\n        <div class=\"col-md-4\">\r\n            ");
            EndContext();
            BeginContext(443, 33, false);
#line 18 "C:\Users\Filip Kostadinov\Desktop\ToDo.TaskApp-Remastered\WebApp\Views\Home\AddSubTask.cshtml"
       Write(Html.LabelFor(x => x.Description));

#line default
#line hidden
            EndContext();
            BeginContext(476, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(491, 68, false);
#line 19 "C:\Users\Filip Kostadinov\Desktop\ToDo.TaskApp-Remastered\WebApp\Views\Home\AddSubTask.cshtml"
       Write(Html.TextBoxFor(x => x.Description, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(559, 101, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <button type=\"submit\" class=\"btn btn-danger\">Add SubTask</button>\r\n");
            EndContext();
#line 23 "C:\Users\Filip Kostadinov\Desktop\ToDo.TaskApp-Remastered\WebApp\Views\Home\AddSubTask.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SubTaskViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591