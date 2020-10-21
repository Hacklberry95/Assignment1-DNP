#pragma checksum "C:\Users\matej\RiderProjects\WebApplication\Pages\AddAdult.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1046de67156758a13da77fc95aaaec50aa54157"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApplication.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\matej\RiderProjects\WebApplication\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\matej\RiderProjects\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\matej\RiderProjects\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\matej\RiderProjects\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\matej\RiderProjects\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\matej\RiderProjects\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\matej\RiderProjects\WebApplication\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\matej\RiderProjects\WebApplication\_Imports.razor"
using WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\matej\RiderProjects\WebApplication\_Imports.razor"
using WebApplication.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\matej\RiderProjects\WebApplication\Pages\AddAdult.razor"
           [Authorize(Policy = "AdminPolicy")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddAdult")]
    public partial class AddAdult : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\matej\RiderProjects\WebApplication\Pages\AddAdult.razor"
       

    private int nextID;
    FileData.FileContext file = new FileData.FileContext();
    

    private void GetNextID()
    {
        IList<Data.Models.Adult> adults;
        adults = file.Adults;

        foreach (Data.Models.Adult a in adults)
        {
            if (a.Id > nextID)
            {
                nextID = a.Id + 1;
            }
        }
    }

    private string firstName;
    private string lastName;
    private string hairColor;
    private string eyeColor;
    private int age;
    private float weight;
    private int height;
    private string sex;
    private string jobTitle;

    private void SaveAdult()
    {
        
        GetNextID();
        Data.Models.Adult toSave = new Data.Models.Adult();
        toSave.Id = nextID;
        toSave.FirstName = firstName;
        toSave.LastName = lastName;
        toSave.HairColor = hairColor;
        toSave.EyeColor = eyeColor;
        toSave.Age = age;
        toSave.Weight = weight;
        toSave.Height = height;
        toSave.Sex = sex;
        toSave.JobTitle = jobTitle;

        file.Adults.Add(toSave);
        file.SaveChanges();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
