using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mvvmweb.Models;

namespace Mvvmweb.Pages.Forms
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public PersonModel Person { get; set; }

        //GET handler
        public void OnGet(string name, string age, string address)
        {
            //HttpResponseWritingExtensions.WriteAsync(this.Response, "Hi! " + name + ". Your are " + age + "y/o. You live in " + address);
        }

        //POST handler
        public ActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            return Redirect("/Index");
            //string name = Request.Form["txtname"];
            //string age = Request.Form["txtage"];
            //string address = Request.Form["txtaddress"];
            //HttpResponseWritingExtensions.WriteAsync(this.Response,"Hi! "+ Person.Name
            //    +". Your are "+Person.Age+" y/o. You live in "+Person.Address);
        }
    }
}
