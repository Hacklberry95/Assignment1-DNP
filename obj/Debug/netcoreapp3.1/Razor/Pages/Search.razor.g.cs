#pragma checksum "C:\Users\matej\RiderProjects\WebApplication\Pages\Search.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4625d6899a3f5dff82dd97f16eda9cc767308543"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "C:\Users\matej\RiderProjects\WebApplication\Pages\Search.razor"
using WebApplication.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\matej\RiderProjects\WebApplication\Pages\Search.razor"
           [Authorize(Policy = "MustBeUser")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Search")]
    public partial class Search : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 onload=\"OnLoad\">Search</h1>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<p>List of adults: </p>\r\n    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddAttribute(6, "id", "adultsTable");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, @"<thead>
            <tr>
                <th>First name</th>
                <th>Last name</th>
                <th>Hair color</th>
                <th>Eye color</th>
                <th>Age</th>
                <th>Height</th>
                <th>Weight</th>
                <th>Sex</th>
                <th>Job title</th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 25 "C:\Users\matej\RiderProjects\WebApplication\Pages\Search.razor"
             foreach (Adult adult in adults)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\r\n                   ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 28 "C:\Users\matej\RiderProjects\WebApplication\Pages\Search.razor"
                        adult.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                   ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 29 "C:\Users\matej\RiderProjects\WebApplication\Pages\Search.razor"
                        adult.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                   ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 30 "C:\Users\matej\RiderProjects\WebApplication\Pages\Search.razor"
                        adult.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                   ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 31 "C:\Users\matej\RiderProjects\WebApplication\Pages\Search.razor"
                        adult.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                   ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 32 "C:\Users\matej\RiderProjects\WebApplication\Pages\Search.razor"
                        adult.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                   ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 33 "C:\Users\matej\RiderProjects\WebApplication\Pages\Search.razor"
                        adult.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                   ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 34 "C:\Users\matej\RiderProjects\WebApplication\Pages\Search.razor"
                        adult.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                   ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 35 "C:\Users\matej\RiderProjects\WebApplication\Pages\Search.razor"
                        adult.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                   ");
            __builder.OpenElement(38, "td");
            __builder.AddContent(39, 
#nullable restore
#line 36 "C:\Users\matej\RiderProjects\WebApplication\Pages\Search.razor"
                        adult.JobTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                 ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
#nullable restore
#line 38 "C:\Users\matej\RiderProjects\WebApplication\Pages\Search.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(42, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n    <p></p>\r\n    <p></p>\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n\r\n");
            __builder.OpenElement(46, "div");
            __builder.AddMarkupContent(47, "\r\n    ");
            __builder.AddMarkupContent(48, "<p>Search for adults by: </p>\r\n    <p></p>\r\n    ");
            __builder.OpenElement(49, "p");
            __builder.AddContent(50, "First name: ");
            __builder.OpenElement(51, "input");
            __builder.AddAttribute(52, "type", "text");
            __builder.AddAttribute(53, "id", "firstName");
            __builder.AddAttribute(54, "name", "firstName");
            __builder.AddAttribute(55, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 48 "C:\Users\matej\RiderProjects\WebApplication\Pages\Search.razor"
                                                                                   firstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => firstName = __value, firstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.OpenElement(57, "button");
            __builder.AddAttribute(58, "class", "btn btn-primary");
            __builder.AddAttribute(59, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\matej\RiderProjects\WebApplication\Pages\Search.razor"
                                                                                                                                                                    SearchFirstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(60, "Search by first name");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n    ");
            __builder.OpenElement(62, "p");
            __builder.AddContent(63, "Last name:  ");
            __builder.OpenElement(64, "input");
            __builder.AddAttribute(65, "type", "text");
            __builder.AddAttribute(66, "id", "lastName");
            __builder.AddAttribute(67, "name", "lastName");
            __builder.AddAttribute(68, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 49 "C:\Users\matej\RiderProjects\WebApplication\Pages\Search.razor"
                                                                                 lastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(69, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => lastName = __value, lastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.OpenElement(70, "button");
            __builder.AddAttribute(71, "class", "btn btn-primary");
            __builder.AddAttribute(72, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "C:\Users\matej\RiderProjects\WebApplication\Pages\Search.razor"
                                                                                                                                                                 SearchLastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(73, "Search by last name");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n    ");
            __builder.OpenElement(75, "p");
            __builder.AddMarkupContent(76, "\r\n        ");
            __builder.AddMarkupContent(77, "<label for=\"hairColor\">Select a hair color: </label>\r\n        ");
            __builder.OpenElement(78, "select");
            __builder.AddAttribute(79, "name", "hairColor");
            __builder.AddAttribute(80, "id", "hairColor");
            __builder.AddAttribute(81, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 52 "C:\Users\matej\RiderProjects\WebApplication\Pages\Search.razor"
                                                             eyeColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(82, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => eyeColor = __value, eyeColor));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(83, "\r\n            ");
            __builder.OpenElement(84, "option");
            __builder.AddAttribute(85, "value", "blond");
            __builder.AddContent(86, "Blond");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n            ");
            __builder.OpenElement(88, "option");
            __builder.AddAttribute(89, "value", "red");
            __builder.AddContent(90, "Red");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n            ");
            __builder.OpenElement(92, "option");
            __builder.AddAttribute(93, "value", "brown");
            __builder.AddContent(94, "Brown");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n            ");
            __builder.OpenElement(96, "option");
            __builder.AddAttribute(97, "value", "black");
            __builder.AddContent(98, "Black");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n            ");
            __builder.OpenElement(100, "option");
            __builder.AddAttribute(101, "value", "white");
            __builder.AddContent(102, "White");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n            ");
            __builder.OpenElement(104, "option");
            __builder.AddAttribute(105, "value", "grey");
            __builder.AddContent(106, "Grey");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n            ");
            __builder.OpenElement(108, "option");
            __builder.AddAttribute(109, "value", "blue");
            __builder.AddContent(110, "Blue");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n            ");
            __builder.OpenElement(112, "option");
            __builder.AddAttribute(113, "value", "green");
            __builder.AddContent(114, "Green");
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n            ");
            __builder.OpenElement(116, "option");
            __builder.AddAttribute(117, "value", "leverpostej");
            __builder.AddContent(118, "Leverpostej");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n        ");
            __builder.OpenElement(121, "button");
            __builder.AddAttribute(122, "class", "btn btn-primary");
            __builder.AddAttribute(123, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 63 "C:\Users\matej\RiderProjects\WebApplication\Pages\Search.razor"
                                                  SearchHairColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(124, "Search by hair color");
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n    ");
            __builder.OpenElement(127, "p");
            __builder.AddMarkupContent(128, "\r\n        ");
            __builder.AddMarkupContent(129, "<label for=\"eyeColor\">Select a hair color: </label>\r\n        ");
            __builder.OpenElement(130, "select");
            __builder.AddAttribute(131, "name", "eyeColor");
            __builder.AddAttribute(132, "id", "eyeColor");
            __builder.AddAttribute(133, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 67 "C:\Users\matej\RiderProjects\WebApplication\Pages\Search.razor"
                                                           hairColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(134, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => hairColor = __value, hairColor));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(135, "\r\n            ");
            __builder.OpenElement(136, "option");
            __builder.AddAttribute(137, "value", "brown");
            __builder.AddContent(138, "Brown");
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n            ");
            __builder.OpenElement(140, "option");
            __builder.AddAttribute(141, "value", "amber");
            __builder.AddContent(142, "Amber");
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\r\n            ");
            __builder.OpenElement(144, "option");
            __builder.AddAttribute(145, "value", "hazel");
            __builder.AddContent(146, "Hazel");
            __builder.CloseElement();
            __builder.AddMarkupContent(147, "\r\n            ");
            __builder.OpenElement(148, "option");
            __builder.AddAttribute(149, "value", "grey");
            __builder.AddContent(150, "Grey");
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\r\n            ");
            __builder.OpenElement(152, "option");
            __builder.AddAttribute(153, "value", "blue");
            __builder.AddContent(154, "Blue");
            __builder.CloseElement();
            __builder.AddMarkupContent(155, "\r\n            ");
            __builder.OpenElement(156, "option");
            __builder.AddAttribute(157, "value", "green");
            __builder.AddContent(158, "Green");
            __builder.CloseElement();
            __builder.AddMarkupContent(159, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(160, "\r\n        ");
            __builder.OpenElement(161, "button");
            __builder.AddAttribute(162, "class", "btn btn-primary");
            __builder.AddAttribute(163, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 75 "C:\Users\matej\RiderProjects\WebApplication\Pages\Search.razor"
                                                  SearchEyeColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(164, "Search by eye color");
            __builder.CloseElement();
            __builder.AddMarkupContent(165, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(166, "\r\n    ");
            __builder.OpenElement(167, "p");
            __builder.AddContent(168, "Age: ");
            __builder.OpenElement(169, "input");
            __builder.AddAttribute(170, "type", "number");
            __builder.AddAttribute(171, "id", "age");
            __builder.AddAttribute(172, "name", "age");
            __builder.AddAttribute(173, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 77 "C:\Users\matej\RiderProjects\WebApplication\Pages\Search.razor"
                                                                  age

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(174, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => age = __value, age, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.OpenElement(175, "button");
            __builder.AddAttribute(176, "class", "btn btn-primary");
            __builder.AddAttribute(177, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 77 "C:\Users\matej\RiderProjects\WebApplication\Pages\Search.razor"
                                                                                                                                             SearchAge

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(178, "Search by age");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(179, "\r\n    ");
            __builder.OpenElement(180, "p");
            __builder.AddContent(181, "Weight:  ");
            __builder.OpenElement(182, "input");
            __builder.AddAttribute(183, "type", "number");
            __builder.AddAttribute(184, "id", "weight");
            __builder.AddAttribute(185, "name", "weight");
            __builder.AddAttribute(186, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 78 "C:\Users\matej\RiderProjects\WebApplication\Pages\Search.razor"
                                                                            weight

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(187, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => weight = __value, weight, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.OpenElement(188, "button");
            __builder.AddAttribute(189, "class", "btn btn-primary");
            __builder.AddAttribute(190, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 78 "C:\Users\matej\RiderProjects\WebApplication\Pages\Search.razor"
                                                                                                                                                          SearchWeight

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(191, "Search by weight");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(192, "\r\n    ");
            __builder.OpenElement(193, "p");
            __builder.AddContent(194, "Height: ");
            __builder.OpenElement(195, "input");
            __builder.AddAttribute(196, "type", "number");
            __builder.AddAttribute(197, "id", "height");
            __builder.AddAttribute(198, "name", "height");
            __builder.AddAttribute(199, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 79 "C:\Users\matej\RiderProjects\WebApplication\Pages\Search.razor"
                                                                           height

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(200, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => height = __value, height, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.OpenElement(201, "button");
            __builder.AddAttribute(202, "class", "btn btn-primary");
            __builder.AddAttribute(203, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 79 "C:\Users\matej\RiderProjects\WebApplication\Pages\Search.razor"
                                                                                                                                                         SearchHeight

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(204, "Search by height");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(205, "\r\n    ");
            __builder.OpenElement(206, "p");
            __builder.AddContent(207, "Sex:  ");
            __builder.OpenElement(208, "input");
            __builder.AddAttribute(209, "type", "text");
            __builder.AddAttribute(210, "id", "sex");
            __builder.AddAttribute(211, "name", "sex");
            __builder.AddAttribute(212, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 80 "C:\Users\matej\RiderProjects\WebApplication\Pages\Search.razor"
                                                                 sex

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(213, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => sex = __value, sex));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.OpenElement(214, "button");
            __builder.AddAttribute(215, "class", "btn btn-primary");
            __builder.AddAttribute(216, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 80 "C:\Users\matej\RiderProjects\WebApplication\Pages\Search.razor"
                                                                                                                                            SearchSex

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(217, "Search by sex");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(218, "\r\n    ");
            __builder.OpenElement(219, "p");
            __builder.AddContent(220, "Job title:  ");
            __builder.OpenElement(221, "input");
            __builder.AddAttribute(222, "type", "text");
            __builder.AddAttribute(223, "id", "jobTitle");
            __builder.AddAttribute(224, "name", "jobTitle");
            __builder.AddAttribute(225, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 81 "C:\Users\matej\RiderProjects\WebApplication\Pages\Search.razor"
                                                                                 jobTitle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(226, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => jobTitle = __value, jobTitle));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.OpenElement(227, "button");
            __builder.AddAttribute(228, "class", "btn btn-primary");
            __builder.AddAttribute(229, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 81 "C:\Users\matej\RiderProjects\WebApplication\Pages\Search.razor"
                                                                                                                                                                 SearchJobTitle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(230, "Search by job title");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(231, "\r\n    <p></p>\r\n    ");
            __builder.OpenElement(232, "p");
            __builder.OpenElement(233, "button");
            __builder.AddAttribute(234, "class", "btn btn-primary");
            __builder.AddAttribute(235, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 83 "C:\Users\matej\RiderProjects\WebApplication\Pages\Search.razor"
                                                 SearchComplex

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(236, "Complex Search");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(237, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 86 "C:\Users\matej\RiderProjects\WebApplication\Pages\Search.razor"
       
    private FileData.FileContext file = new FileData.FileContext();

    private IList<Adult> adults = new List<Adult>();

    private void OnLoad()
    {
        adults = file.Adults;
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

    private void SearchFirstName()
    {
        adults = new List<Adult>();
        foreach (Adult item in file.Adults)
        {
            if (item.FirstName.Equals(firstName))
            {
                adults.Add(item);
            }
        }
    }
    private void SearchLastName()
    {
        adults = new List<Adult>();
        foreach (Adult item in file.Adults)
        {
            if (item.LastName.Equals(lastName))
            {
                adults.Add(item);
            }
        }
    }
    private void SearchHairColor()
    {
        adults = new List<Adult>();
        foreach (Adult item in file.Adults)
        {
            if (item.HairColor.Equals(hairColor))
            {
                adults.Add(item);
            }
        }
    }
    private void SearchEyeColor()
    {
        adults = new List<Adult>();
        foreach (Adult item in file.Adults)
        {
            if (item.EyeColor.Equals(eyeColor))
            {
                adults.Add(item);
            }
        }
    }
    private void SearchAge()
    {
        adults = new List<Adult>();
        foreach (Adult item in file.Adults)
        {
            if (item.Age.Equals(age))
            {
                adults.Add(item);
            }
        }
    }
    private void SearchWeight()
    {
        adults = new List<Adult>();
        foreach (Adult item in file.Adults)
        {
            if (item.Weight.Equals(weight))
            {
                adults.Add(item);
            }
        }
    }
    private void SearchHeight()
    {
        adults = new List<Adult>();
        foreach (Adult item in file.Adults)
        {
            if (item.Height.Equals(height))
            {
                adults.Add(item);
            }
        }
    }
    private void SearchSex()
    {
        adults = new List<Adult>();
        foreach (Adult item in file.Adults)
        {
            if (item.Sex.Equals(sex))
            {
                adults.Add(item);
            }
        }
    }
    private void SearchJobTitle()
    {
        adults = new List<Adult>();
        foreach (Adult item in file.Adults)
        {
            if (item.JobTitle.Equals(jobTitle))
            {
                adults.Add(item);
            }
        }
    }

    private void SearchComplex()
    {
        if (firstName != null && firstName != "")
        {
            SearchFirstName();
        }
        if (lastName != null && lastName != "")
        {
            SearchLastName();
        }
        if (hairColor != null && hairColor != "")
        {
            SearchHairColor();
        }
        if (eyeColor != null && eyeColor != "")
        {
            SearchEyeColor();
        }
        SearchAge();
        SearchWeight();
        SearchHeight();
        if (sex != null && sex != "")
        {
            SearchSex();
        }
        if (jobTitle != null && jobTitle != "")
        {
            SearchJobTitle();
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
