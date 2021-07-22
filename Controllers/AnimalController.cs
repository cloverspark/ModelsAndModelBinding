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
            pet.Breed = form["Animal_Breed"];
            pet.DateTimeOfDropOff =Convert.ToDateTime(form["Date_Dropped_Off"]);

            // add to database

            ViewData["Added"] = pet.OwnerFullName +" your pet named " + pet.AnimalName + " was added with ID of 1";

            return View();      
        }
        [HttpGet]
        public IActionResult AddWithBinding() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddWithBinding(Animal A)
        {
            if (ModelState.IsValid) // will run all validation if passed returns true
            {
                ViewData["message"] = $"{A.OwnerFullName} you pet named {A.AnimalName} was added with an ID of 1";
                //Add to database
            }
            return View();
        }
    }
}
