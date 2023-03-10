// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#pragma warning restore 1591
