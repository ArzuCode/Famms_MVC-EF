﻿using Famms_MVC.Controllers;
using Famms_MVC.Models;
using Famms_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Famms_MVC.ViewComponents
{
    public class FooterContactHomeViewComponent : ViewComponent
    {
        private readonly FammsDbContext _context;
        public FooterContactHomeViewComponent(FammsDbContext context)
        {
            _context = context;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
            var footerContacts = _context.FooterContacts.ToList();
            var model = new FooterContactVM
            {
                FooterContacts = footerContacts
            };
            return View(model);
        }

    }


}

