﻿using Famms_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Famms_MVC.Views.Shared.Components.Testimonial
{
    public class TestimonialViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
