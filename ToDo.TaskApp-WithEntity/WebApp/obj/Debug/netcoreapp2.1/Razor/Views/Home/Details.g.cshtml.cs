#pragma checksum "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Homeworks-ASP.NET\ToDo.TaskApp-WithEntity\WebApp\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "267160b6426f6c5ef4556af31687a146c524a4d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Details.cshtml", typeof(AspNetCore.Views_Home_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"267160b6426f6c5ef4556af31687a146c524a4d9", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0eb012e07f2e2a6d8bcab9f8c8fba5c920479a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TaskViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Homeworks-ASP.NET\ToDo.TaskApp-WithEntity\WebApp\Views\Home\Details.cshtml"
  
    ViewBag.Title = "Details";

#line default
#line hidden
            BeginContext(63, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Homeworks-ASP.NET\ToDo.TaskApp-WithEntity\WebApp\Views\Home\Details.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(95, 78, true);
            WriteLiteral("    <div class=\"form-group row\">\r\n        <div class=\"col-md-4\">\r\n            ");
            EndContext();
            BeginContext(174, 27, false);
#line 11 "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Homeworks-ASP.NET\ToDo.TaskApp-WithEntity\WebApp\Views\Home\Details.cshtml"
       Write(Html.LabelFor(x => x.Title));

#line default
#line hidden
            EndContext();
            BeginContext(201, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(216, 62, false);
#line 12 "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Homeworks-ASP.NET\ToDo.TaskApp-WithEntity\WebApp\Views\Home\Details.cshtml"
       Write(Html.TextBoxFor(x => x.Title, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(278, 108, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group row\">\r\n        <div class=\"col-md-4\">\r\n            ");
            EndContext();
            BeginContext(387, 33, false);
#line 17 "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Homeworks-ASP.NET\ToDo.TaskApp-WithEntity\WebApp\Views\Home\Details.cshtml"
       Write(Html.LabelFor(x => x.Description));

#line default
#line hidden
            EndContext();
            BeginContext(420, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(435, 68, false);
#line 18 "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Homeworks-ASP.NET\ToDo.TaskApp-WithEntity\WebApp\Views\Home\Details.cshtml"
       Write(Html.TextBoxFor(x => x.Description, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(503, 108, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group row\">\r\n        <div class=\"col-md-4\">\r\n            ");
            EndContext();
            BeginContext(612, 30, false);
#line 23 "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Homeworks-ASP.NET\ToDo.TaskApp-WithEntity\WebApp\Views\Home\Details.cshtml"
       Write(Html.LabelFor(x => x.Priority));

#line default
#line hidden
            EndContext();
            BeginContext(642, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(657, 120, false);
#line 24 "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Homeworks-ASP.NET\ToDo.TaskApp-WithEntity\WebApp\Views\Home\Details.cshtml"
       Write(Html.DropDownListFor(x => x.Priority, Html.GetEnumSelectList(Model.Priority.GetType()), new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(777, 108, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group row\">\r\n        <div class=\"col-md-4\">\r\n            ");
            EndContext();
            BeginContext(886, 28, false);
#line 29 "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Homeworks-ASP.NET\ToDo.TaskApp-WithEntity\WebApp\Views\Home\Details.cshtml"
       Write(Html.LabelFor(x => x.Status));

#line default
#line hidden
            EndContext();
            BeginContext(914, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(929, 116, false);
#line 30 "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Homeworks-ASP.NET\ToDo.TaskApp-WithEntity\WebApp\Views\Home\Details.cshtml"
       Write(Html.DropDownListFor(x => x.Status, Html.GetEnumSelectList(Model.Status.GetType()), new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1045, 108, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group row\">\r\n        <div class=\"col-md-4\">\r\n            ");
            EndContext();
            BeginContext(1154, 32, false);
#line 35 "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Homeworks-ASP.NET\ToDo.TaskApp-WithEntity\WebApp\Views\Home\Details.cshtml"
       Write(Html.LabelFor(x => x.TypeOfTask));

#line default
#line hidden
            EndContext();
            BeginContext(1186, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1201, 124, false);
#line 36 "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Homeworks-ASP.NET\ToDo.TaskApp-WithEntity\WebApp\Views\Home\Details.cshtml"
       Write(Html.DropDownListFor(x => x.TypeOfTask, Html.GetEnumSelectList(Model.TypeOfTask.GetType()), new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1325, 126, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <br />\r\n    <br />\r\n    <button type=\"submit\" class=\"btn btn-danger\">Save Changes</button>\r\n");
            EndContext();
#line 42 "C:\Users\Filip Kostadinov\Desktop\GitHub-Filip\Homeworks-ASP.NET\ToDo.TaskApp-WithEntity\WebApp\Views\Home\Details.cshtml"
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
