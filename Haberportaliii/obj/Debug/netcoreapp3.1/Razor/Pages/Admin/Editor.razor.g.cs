#pragma checksum "C:\Users\timur\www.HaberPortalim.somee.com\Pages\Admin\Editor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ff30d213b05210c1f73ce964009963170d029d2"
// <auto-generated/>
#pragma warning disable 1591
namespace SportsStore.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\timur\www.HaberPortalim.somee.com\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\timur\www.HaberPortalim.somee.com\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\timur\www.HaberPortalim.somee.com\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\timur\www.HaberPortalim.somee.com\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\timur\www.HaberPortalim.somee.com\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\timur\www.HaberPortalim.somee.com\Pages\Admin\_Imports.razor"
using SportsStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/admin/habers/edit/{id:long}")]
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/admin/habers/create")]
    public partial class Editor : OwningComponentBase<IHaberRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\n    div.validation-message { color: rgb(220, 53, 69); font-weight: 500 }\n</style>\n\n");
            __builder.OpenElement(1, "h3");
            __builder.AddAttribute(2, "class", "bg-" + (
#nullable restore
#line 9 "C:\Users\timur\www.HaberPortalim.somee.com\Pages\Admin\Editor.razor"
               ThemeColor

#line default
#line hidden
#nullable disable
            ) + " text-white" + " text-center" + " p-1");
#nullable restore
#line 9 "C:\Users\timur\www.HaberPortalim.somee.com\Pages\Admin\Editor.razor"
__builder.AddContent(3, TitleText);

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, " a Haber");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\n");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 10 "C:\Users\timur\www.HaberPortalim.somee.com\Pages\Admin\Editor.razor"
                 Haber

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\Users\timur\www.HaberPortalim.somee.com\Pages\Admin\Editor.razor"
                                       SaveHaber

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(10, "\n    ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\n");
#nullable restore
#line 12 "C:\Users\timur\www.HaberPortalim.somee.com\Pages\Admin\Editor.razor"
     if(Haber.HaberID != 0) {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(13, "        ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "form-group");
                __builder2.AddMarkupContent(16, "\n            ");
                __builder2.AddMarkupContent(17, "<label>ID</label>\n            ");
                __builder2.OpenElement(18, "input");
                __builder2.AddAttribute(19, "class", "form-control");
                __builder2.AddAttribute(20, "disabled", true);
                __builder2.AddAttribute(21, "value", 
#nullable restore
#line 15 "C:\Users\timur\www.HaberPortalim.somee.com\Pages\Admin\Editor.razor"
                                                         Haber.HaberID

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\n");
#nullable restore
#line 17 "C:\Users\timur\www.HaberPortalim.somee.com\Pages\Admin\Editor.razor"
    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(24, "    ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "form-group");
                __builder2.AddMarkupContent(27, "\n        ");
                __builder2.AddMarkupContent(28, "<label>Name</label>\n        ");
                global::__Blazor.SportsStore.Pages.Admin.Editor.TypeInference.CreateValidationMessage_0(__builder2, 29, 30, 
#nullable restore
#line 20 "C:\Users\timur\www.HaberPortalim.somee.com\Pages\Admin\Editor.razor"
                                  () => Haber.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(31, "\n        ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(32);
                __builder2.AddAttribute(33, "class", "form-control");
                __builder2.AddAttribute(34, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 21 "C:\Users\timur\www.HaberPortalim.somee.com\Pages\Admin\Editor.razor"
                                                     Haber.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Haber.Name = __value, Haber.Name))));
                __builder2.AddAttribute(36, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Haber.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\n    ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "form-group");
                __builder2.AddMarkupContent(41, "\n        ");
                __builder2.AddMarkupContent(42, "<label>Description</label>\n        ");
                global::__Blazor.SportsStore.Pages.Admin.Editor.TypeInference.CreateValidationMessage_1(__builder2, 43, 44, 
#nullable restore
#line 25 "C:\Users\timur\www.HaberPortalim.somee.com\Pages\Admin\Editor.razor"
                                  () => Haber.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(45, "\n        ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(46);
                __builder2.AddAttribute(47, "class", "form-control");
                __builder2.AddAttribute(48, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 26 "C:\Users\timur\www.HaberPortalim.somee.com\Pages\Admin\Editor.razor"
                                                     Haber.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Haber.Description = __value, Haber.Description))));
                __builder2.AddAttribute(50, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Haber.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\n    ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "form-group");
                __builder2.AddMarkupContent(55, "\n        ");
                __builder2.AddMarkupContent(56, "<label>Category</label>\n        ");
                global::__Blazor.SportsStore.Pages.Admin.Editor.TypeInference.CreateValidationMessage_2(__builder2, 57, 58, 
#nullable restore
#line 30 "C:\Users\timur\www.HaberPortalim.somee.com\Pages\Admin\Editor.razor"
                                  () => Haber.Category

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(59, "\n        ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(60);
                __builder2.AddAttribute(61, "class", "form-control");
                __builder2.AddAttribute(62, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 31 "C:\Users\timur\www.HaberPortalim.somee.com\Pages\Admin\Editor.razor"
                                                     Haber.Category

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(63, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Haber.Category = __value, Haber.Category))));
                __builder2.AddAttribute(64, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Haber.Category));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(65, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\n    ");
                __builder2.OpenElement(67, "div");
                __builder2.AddAttribute(68, "class", "form-group");
                __builder2.AddMarkupContent(69, "\n        ");
                __builder2.AddMarkupContent(70, "<label>Image</label>\n        ");
                global::__Blazor.SportsStore.Pages.Admin.Editor.TypeInference.CreateValidationMessage_3(__builder2, 71, 72, 
#nullable restore
#line 35 "C:\Users\timur\www.HaberPortalim.somee.com\Pages\Admin\Editor.razor"
                                  () => Haber.ImageUrl

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(73, "\n        ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(74);
                __builder2.AddAttribute(75, "class", "form-control");
                __builder2.AddAttribute(76, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 36 "C:\Users\timur\www.HaberPortalim.somee.com\Pages\Admin\Editor.razor"
                                                     Haber.ImageUrl

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(77, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Haber.ImageUrl = __value, Haber.ImageUrl))));
                __builder2.AddAttribute(78, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Haber.ImageUrl));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(79, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\n    ");
                __builder2.OpenElement(81, "button");
                __builder2.AddAttribute(82, "type", "submit");
                __builder2.AddAttribute(83, "class", "btn" + " btn-" + (
#nullable restore
#line 38 "C:\Users\timur\www.HaberPortalim.somee.com\Pages\Admin\Editor.razor"
                                          ThemeColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(84, "Save");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\n    ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(86);
                __builder2.AddAttribute(87, "class", "btn btn-secondary");
                __builder2.AddAttribute(88, "href", "/admin/habers");
                __builder2.AddAttribute(89, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(90, "Cancel");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(91, "\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\timur\www.HaberPortalim.somee.com\Pages\Admin\Editor.razor"
       

    public IHaberRepository Repository => Service;

    [Inject]
    public NavigationManager NavManager { get; set; }

    [Parameter]
    public long Id { get; set; } = 0;

    public Haber Haber { get; set; } = new Haber();

    protected override void OnParametersSet() {
        if (Id != 0) {
            Haber = Repository.Habers.FirstOrDefault(h => h.HaberID == Id);
        }
    }

    public void SaveHaber() {
        if (Id == 0) {
            Repository.CreateHaber(Haber);
        } else {
            Repository.SaveHaber(Haber);
        }
        NavManager.NavigateTo("/admin/habers");
    }

    public string ThemeColor => Id == 0 ? "primary" : "warning";
    public string TitleText => Id == 0 ? "Create" : "Edit";

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.SportsStore.Pages.Admin.Editor
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
