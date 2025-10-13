using CarInsurance.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace CarInsurance.Controllers
{
    // Controller for handling insuree-related actions
    public class InsureeController : Controller // inherits from base Controller class
    {
        private readonly InsuranceContext _context;

        // Constructor to inject the database context
        public InsureeController(InsuranceContext context)
        {
            _context = context;
        }

        // Show the Create form
        public IActionResult Create()
        {
            return View();
        }

        // Handle form submission
        [HttpPost]
        
        public IActionResult Create(Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                decimal quote = 50m; // base price

                // calculate age
                var today = DateTime.Today;
                int age = today.Year - insuree.DateOfBirth.Year;
                if (insuree.DateOfBirth.Date > today.AddYears(-age)) age--;

                // add price based on age
                if (age <= 18)
                    quote += 100;
                else if (age <= 25)
                    quote += 50;
                else
                    quote += 25;

                // add price based on car year
                if (insuree.CarYear < 2000)
                    quote += 25;
                else if (insuree.CarYear > 2015)
                    quote += 25;

                // add price based on car make/model
                if (insuree.CarMake?.ToLower() == "porsche")
                {
                    quote += 25;
                    if (insuree.CarModel?.ToLower() == "911 carrera")
                        quote += 25;
                }

                // add price for speeding tickets
                quote += insuree.SpeedingTickets * 10;

                // add 25% if DUI
                if (insuree.DUI)
                    quote *= 1.25m;

                // add 50% if full coverage
                if (insuree.CoverageType)
                    quote *= 1.5m;

                insuree.Quote = quote; // save quote

                _context.Add(insuree); // save to db
                _context.SaveChanges();

                return RedirectToAction("Index", "Home"); // redirect to home page
            }

            return View(insuree);
        }

        // Admin page - shows all insurees and quotes
        public IActionResult Admin()
        {
            var insurees = _context.Insurees.ToList(); // get all from db
            return View(insurees);
        }
    }
}
