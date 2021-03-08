using Assessment.Data;
using Assessment.Services;
using Microsoft.AspNetCore.Mvc;
using SynicTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment.Web.Controllers
{
    public class BlogController : SynicController
    {
        private readonly IBlogService BlogService;

        public BlogController(IBlogService blogService)
        {
            this.BlogService = blogService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Details(Blog model)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            return RedirectToAction(nameof(this.Index));
        }
    }
}
