﻿using Famms_MVC.Models;
using Famms_MVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Famms_MVC.Controllers
{
    public class ContactController : Controller
    {
        private readonly FammsDbContext _context;

        public ContactController(FammsDbContext context)
        {
            _context = context; 
        }



        public ActionResult Index()
        {
           return View();
        }


        [HttpPost]
        public ActionResult Index(ContactIndexVM model)
        {
            if (!ModelState.IsValid) return View(model);

            var query = new Query
            {
                FullName = model.FullName,
                Email = model.Email,
                Subject = model.Subject,
                Message = model.Message
            };
            

                _context.Queries.Add(query);
            _context.SaveChanges(); 


            return RedirectToAction("Index");
        }
    }
}
