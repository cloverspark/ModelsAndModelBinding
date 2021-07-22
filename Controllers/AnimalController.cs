using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using ModelsAndModelBinding.Models;

namespace ModelsAndModelBinding.Controllers
{
    public class AnimalController : Controller
    {
        [HttpGet]//when first go to url
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]//called on submit
        public IActionResult Add(IFormCollection form)
        {
            // need server side validation for all data
            Animal pet = new Animal();
            pet.AnimalName = form["Animal_Name"];
            pet.OwnerFullName = form["Animals_Owner_Name"];
            pet.breed = form["Animal_Breed"];
            pet.DateTimeOfDropOff =Convert.ToDateTime(form["Date_Dropped_Off"]);

            // add to database

            ViewData["Added"] = true;

            return View();      
        }
    }
}
