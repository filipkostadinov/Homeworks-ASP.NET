#pragma checksum "C:\Users\Filip Kostadinov\source\repos\ToDo\ToDo\Views\Home\AddTask.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb2186ecc25653ce8b16eb214cd6bd84e623310c"
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
#line 1 "C:\Users\Filip Kostadinov\source\repos\ToDo\ToDo\Views\_ViewImports.cshtml"
using ToDo.Models.DomainModels;

#line default
#line hidden
#line 2 "C:\Users\Filip Kostadinov\source\repos\ToDo\ToDo\Views\_ViewImports.cshtml"
using ToDo.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb2186ecc25653ce8b16eb214cd6bd84e623310c", @"/Views/Home/AddTask.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52726f6fed68f7ce930e8fa56b3f0be80ba0a919", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AddTask : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TaskViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Filip Kostadinov\source\repos\ToDo\ToDo\Views\Home\AddTask.cshtml"
  
    ViewBag.Title = "New ToDo Task ";

#line default
#line hidden
            BeginContext(70, 29, true);
            WriteLiteral("\r\n<h3>Add a new task</h3>\r\n\r\n");
            EndContext();
#line 9 "C:\Users\Filip Kostadinov\source\repos\ToDo\ToDo\Views\Home\AddTask.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(134, 27, false);
#line 11 "C:\Users\Filip Kostadinov\source\repos\ToDo\ToDo\Views\Home\AddTask.cshtml"
Write(Html.LabelFor(x => x.Title));

#line default
#line hidden
            EndContext();
            BeginContext(168, 29, false);
#line 12 "C:\Users\Filip Kostadinov\source\repos\ToDo\ToDo\Views\Home\AddTask.cshtml"
Write(Html.TextBoxFor(x => x.Title));

#line default
#line hidden
            EndContext();
            BeginContext(199, 12, true);
            WriteLiteral("    <br />\r\n");
            EndContext();
            BeginContext(216, 33, false);
#line 14 "C:\Users\Filip Kostadinov\source\repos\ToDo\ToDo\Views\Home\AddTask.cshtml"
Write(Html.LabelFor(x => x.Description));

#line default
#line hidden
            EndContext();
            BeginContext(256, 35, false);
#line 15 "C:\Users\Filip Kostadinov\source\repos\ToDo\ToDo\Views\Home\AddTask.cshtml"
Write(Html.TextBoxFor(x => x.Description));

#line default
#line hidden
            EndContext();
            BeginContext(293, 12, true);
            WriteLiteral("    <br />\r\n");
            EndContext();
            BeginContext(310, 30, false);
#line 17 "C:\Users\Filip Kostadinov\source\repos\ToDo\ToDo\Views\Home\AddTask.cshtml"
Write(Html.LabelFor(x => x.Priority));

#line default
#line hidden
            EndContext();
            BeginContext(347, 87, false);
#line 18 "C:\Users\Filip Kostadinov\source\repos\ToDo\ToDo\Views\Home\AddTask.cshtml"
Write(Html.DropDownListFor(x => x.Priority, Html.GetEnumSelectList(Model.Priority.GetType())));

#line default
#line hidden
            EndContext();
            BeginContext(436, 12, true);
            WriteLiteral("    <br />\r\n");
            EndContext();
            BeginContext(453, 32, false);
#line 20 "C:\Users\Filip Kostadinov\source\repos\ToDo\ToDo\Views\Home\AddTask.cshtml"
Write(Html.LabelFor(x => x.TypeOfTask));

#line default
#line hidden
            EndContext();
            BeginContext(492, 91, false);
#line 21 "C:\Users\Filip Kostadinov\source\repos\ToDo\ToDo\Views\Home\AddTask.cshtml"
Write(Html.DropDownListFor(x => x.TypeOfTask, Html.GetEnumSelectList(Model.TypeOfTask.GetType())));

#line default
#line hidden
            EndContext();
            BeginContext(585, 67, true);
            WriteLiteral("    <br />\r\n    <br />\r\n    <button type=\"submit\">Submit</button>\r\n");
            EndContext();
#line 25 "C:\Users\Filip Kostadinov\source\repos\ToDo\ToDo\Views\Home\AddTask.cshtml"

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
