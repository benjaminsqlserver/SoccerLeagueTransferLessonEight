#pragma checksum "C:\SoccerLeagueTransfer\server\Pages\EditUsersInRole.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7bd71b4ef461c1a3be7ac3592080e12de7520a4"
// <auto-generated/>
#pragma warning disable 1591
namespace SoccerLeagueTransferApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\SoccerLeagueTransfer\server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\SoccerLeagueTransfer\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\SoccerLeagueTransfer\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\SoccerLeagueTransfer\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\SoccerLeagueTransfer\server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\SoccerLeagueTransfer\server\_Imports.razor"
using SoccerLeagueTransferApp.Shared;

#line default
#line hidden
#line 5 "C:\SoccerLeagueTransfer\server\Pages\EditUsersInRole.razor"
using Radzen;

#line default
#line hidden
#line 6 "C:\SoccerLeagueTransfer\server\Pages\EditUsersInRole.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "C:\SoccerLeagueTransfer\server\Pages\EditUsersInRole.razor"
using SoccerLeagueTransferApp.Models.ConData;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/edit-users-in-role/{ID}")]
    public partial class EditUsersInRole : SoccerLeagueTransferApp.Pages.EditUsersInRoleComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\n    ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "row");
                __builder2.AddMarkupContent(6, "\n      ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "col-md-12");
                __builder2.AddMarkupContent(9, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<SoccerLeagueTransferApp.Models.ConData.UsersInRole>>(10);
                __builder2.AddAttribute(11, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<SoccerLeagueTransferApp.Models.ConData.UsersInRole>(
#line 12 "C:\SoccerLeagueTransfer\server\Pages\EditUsersInRole.razor"
                                                                                              usersinrole

#line default
#line hidden
                ));
                __builder2.AddAttribute(12, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 12 "C:\SoccerLeagueTransfer\server\Pages\EditUsersInRole.razor"
                                                                                                                      usersinrole != null

#line default
#line hidden
                ));
                __builder2.AddAttribute(13, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<SoccerLeagueTransferApp.Models.ConData.UsersInRole>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<SoccerLeagueTransferApp.Models.ConData.UsersInRole>(this, 
#line 12 "C:\SoccerLeagueTransfer\server\Pages\EditUsersInRole.razor"
                                                                                                                                                     Form0Submit

#line default
#line hidden
                )));
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(15, "\n            ");
                    __builder3.OpenElement(16, "div");
                    __builder3.AddAttribute(17, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(18, "class", "row");
                    __builder3.AddMarkupContent(19, "\n              ");
                    __builder3.OpenElement(20, "div");
                    __builder3.AddAttribute(21, "class", "col-md-3");
                    __builder3.AddMarkupContent(22, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(23);
                    __builder3.AddAttribute(24, "Text", "User");
                    __builder3.AddAttribute(25, "Component", "UserID");
                    __builder3.AddAttribute(26, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(27, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(28, "\n              ");
                    __builder3.OpenElement(29, "div");
                    __builder3.AddAttribute(30, "class", "col-md-9");
                    __builder3.AddMarkupContent(31, "\n                ");
                    __Blazor.SoccerLeagueTransferApp.Pages.EditUsersInRole.TypeInference.CreateRadzenDropDown_0(__builder3, 32, 33, 
#line 20 "C:\SoccerLeagueTransfer\server\Pages\EditUsersInRole.razor"
                                       getUsersResult

#line default
#line hidden
                    , 34, "Username", 35, "UserID", 36, "Choose User", 37, "display: block; width: 100%", 38, "UserID", 39, 
#line 20 "C:\SoccerLeagueTransfer\server\Pages\EditUsersInRole.razor"
                                                                                                                                                                                   usersinrole.UserID

#line default
#line hidden
                    , 40, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => usersinrole.UserID = __value, usersinrole.UserID)), 41, () => usersinrole.UserID);
                    __builder3.AddMarkupContent(42, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(43);
                    __builder3.AddAttribute(44, "Component", "UserID");
                    __builder3.AddAttribute(45, "Text", "UserID is required");
                    __builder3.AddAttribute(46, "style", "position: absolute");
                    __builder3.AddAttribute(47, "DefaultValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 22 "C:\SoccerLeagueTransfer\server\Pages\EditUsersInRole.razor"
                                                                                                                               0

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(48, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(49, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(50, "\n            ");
                    __builder3.OpenElement(51, "div");
                    __builder3.AddAttribute(52, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(53, "class", "row");
                    __builder3.AddMarkupContent(54, "\n              ");
                    __builder3.OpenElement(55, "div");
                    __builder3.AddAttribute(56, "class", "col-md-3");
                    __builder3.AddMarkupContent(57, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(58);
                    __builder3.AddAttribute(59, "Text", "Role");
                    __builder3.AddAttribute(60, "Component", "RoleID");
                    __builder3.AddAttribute(61, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(62, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(63, "\n              ");
                    __builder3.OpenElement(64, "div");
                    __builder3.AddAttribute(65, "class", "col-md-9");
                    __builder3.AddMarkupContent(66, "\n                ");
                    __Blazor.SoccerLeagueTransferApp.Pages.EditUsersInRole.TypeInference.CreateRadzenDropDown_1(__builder3, 67, 68, 
#line 32 "C:\SoccerLeagueTransfer\server\Pages\EditUsersInRole.razor"
                                       getRolesResult

#line default
#line hidden
                    , 69, "RoleName", 70, "RoleID", 71, "Choose Role", 72, "display: block; width: 100%", 73, "RoleID", 74, 
#line 32 "C:\SoccerLeagueTransfer\server\Pages\EditUsersInRole.razor"
                                                                                                                                                                                   usersinrole.RoleID

#line default
#line hidden
                    , 75, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => usersinrole.RoleID = __value, usersinrole.RoleID)), 76, () => usersinrole.RoleID);
                    __builder3.AddMarkupContent(77, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(78);
                    __builder3.AddAttribute(79, "Component", "RoleID");
                    __builder3.AddAttribute(80, "Text", "RoleID is required");
                    __builder3.AddAttribute(81, "style", "position: absolute");
                    __builder3.AddAttribute(82, "DefaultValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 34 "C:\SoccerLeagueTransfer\server\Pages\EditUsersInRole.razor"
                                                                                                                               0

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(83, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(84, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(85, "\n            ");
                    __builder3.OpenElement(86, "div");
                    __builder3.AddAttribute(87, "class", "row");
                    __builder3.AddMarkupContent(88, "\n              ");
                    __builder3.OpenElement(89, "div");
                    __builder3.AddAttribute(90, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(91, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(92);
                    __builder3.AddAttribute(93, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#line 40 "C:\SoccerLeagueTransfer\server\Pages\EditUsersInRole.razor"
                                          ButtonType.Submit

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(94, "Icon", "save");
                    __builder3.AddAttribute(95, "Text", "Save");
                    __builder3.AddAttribute(96, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 40 "C:\SoccerLeagueTransfer\server\Pages\EditUsersInRole.razor"
                                                                                                  ButtonStyle.Primary

#line default
#line hidden
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(97, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(98);
                    __builder3.AddAttribute(99, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 42 "C:\SoccerLeagueTransfer\server\Pages\EditUsersInRole.razor"
                                           ButtonStyle.Light

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(100, "Text", "Cancel");
                    __builder3.AddAttribute(101, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 42 "C:\SoccerLeagueTransfer\server\Pages\EditUsersInRole.razor"
                                                                                    Button2Click

#line default
#line hidden
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(102, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(103, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(104, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(105, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(106, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(107, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.SoccerLeagueTransferApp.Pages.EditUsersInRole
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenDropDown_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.IEnumerable __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, System.Object __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.Object __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7, int __seq8, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg8)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDown<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "TextProperty", __arg1);
        __builder.AddAttribute(__seq2, "ValueProperty", __arg2);
        __builder.AddAttribute(__seq3, "Placeholder", __arg3);
        __builder.AddAttribute(__seq4, "style", __arg4);
        __builder.AddAttribute(__seq5, "Name", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.AddAttribute(__seq8, "ValueExpression", __arg8);
        __builder.CloseComponent();
        }
        public static void CreateRadzenDropDown_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.IEnumerable __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, System.Object __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.Object __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7, int __seq8, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg8)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDown<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "TextProperty", __arg1);
        __builder.AddAttribute(__seq2, "ValueProperty", __arg2);
        __builder.AddAttribute(__seq3, "Placeholder", __arg3);
        __builder.AddAttribute(__seq4, "style", __arg4);
        __builder.AddAttribute(__seq5, "Name", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.AddAttribute(__seq8, "ValueExpression", __arg8);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
