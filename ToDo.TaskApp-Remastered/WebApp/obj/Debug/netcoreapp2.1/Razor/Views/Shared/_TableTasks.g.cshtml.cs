#pragma checksum "C:\Users\Filip Kostadinov\source\repos\ToDo.TaskApp\WebApp\Views\Shared\_TableTasks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61cc10e1b65ba78c083ffaf08aeb0880551ed817"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__TableTasks), @"mvc.1.0.view", @"/Views/Shared/_TableTasks.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_TableTasks.cshtml", typeof(AspNetCore.Views_Shared__TableTasks))]
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
#line 1 "C:\Users\Filip Kostadinov\source\repos\ToDo.TaskApp\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61cc10e1b65ba78c083ffaf08aeb0880551ed817", @"/Views/Shared/_TableTasks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0eb012e07f2e2a6d8bcab9f8c8fba5c920479a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__TableTasks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TaskViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Filip Kostadinov\source\repos\ToDo.TaskApp\WebApp\Views\Shared\_TableTasks.cshtml"
  
    string color;
    if (Model.Status.ToString() == "NotDone")
    {
        color = "Red";
    }
    else if (Model.Status.ToString() == "InProgress")
    {
        color = "Yellow";
    }
    else
    {
        color = "Green";
    }


#line default
#line hidden
            BeginContext(283, 16, true);
            WriteLiteral("\r\n<tr>\r\n    <td>");
            EndContext();
            BeginContext(300, 11, false);
#line 21 "C:\Users\Filip Kostadinov\source\repos\ToDo.TaskApp\WebApp\Views\Shared\_TableTasks.cshtml"
   Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(311, 15, true);
            WriteLiteral("</td>\r\n    <td>");
            EndContext();
            BeginContext(327, 17, false);
#line 22 "C:\Users\Filip Kostadinov\source\repos\ToDo.TaskApp\WebApp\Views\Shared\_TableTasks.cshtml"
   Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(344, 15, true);
            WriteLiteral("</td>\r\n    <td>");
            EndContext();
            BeginContext(360, 32, false);
#line 23 "C:\Users\Filip Kostadinov\source\repos\ToDo.TaskApp\WebApp\Views\Shared\_TableTasks.cshtml"
   Write(Html.DisplayFor(x => x.Priority));

#line default
#line hidden
            EndContext();
            BeginContext(392, 14, true);
            WriteLiteral("</td>\r\n    <td");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 406, "\"", 437, 2);
            WriteAttributeValue("", 414, "background-color:", 414, 17, true);
#line 24 "C:\Users\Filip Kostadinov\source\repos\ToDo.TaskApp\WebApp\Views\Shared\_TableTasks.cshtml"
WriteAttributeValue("", 431, color, 431, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(438, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(440, 30, false);
#line 24 "C:\Users\Filip Kostadinov\source\repos\ToDo.TaskApp\WebApp\Views\Shared\_TableTasks.cshtml"
                                   Write(Html.DisplayFor(x => x.Status));

#line default
#line hidden
            EndContext();
            BeginContext(470, 15, true);
            WriteLiteral("</td>\r\n    <td>");
            EndContext();
            BeginContext(486, 16, false);
#line 25 "C:\Users\Filip Kostadinov\source\repos\ToDo.TaskApp\WebApp\Views\Shared\_TableTasks.cshtml"
   Write(Model.TypeOfTask);

#line default
#line hidden
            EndContext();
            BeginContext(502, 31, true);
            WriteLiteral("</td>\r\n    <td>\r\n        <ul>\r\n");
            EndContext();
#line 28 "C:\Users\Filip Kostadinov\source\repos\ToDo.TaskApp\WebApp\Views\Shared\_TableTasks.cshtml"
             foreach (var item in Model.SubTask)
            {

#line default
#line hidden
            BeginContext(598, 20, true);
            WriteLiteral("                <li>");
            EndContext();
            BeginContext(619, 4, false);
#line 30 "C:\Users\Filip Kostadinov\source\repos\ToDo.TaskApp\WebApp\Views\Shared\_TableTasks.cshtml"
               Write(item);

#line default
#line hidden
            EndContext();
            BeginContext(623, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 31 "C:\Users\Filip Kostadinov\source\repos\ToDo.TaskApp\WebApp\Views\Shared\_TableTasks.cshtml"
            }

#line default
#line hidden
            BeginContext(645, 33, true);
            WriteLiteral("        </ul>\r\n    </td>\r\n</tr>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TaskViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591