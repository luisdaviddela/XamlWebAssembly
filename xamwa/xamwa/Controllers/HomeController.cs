using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using xamwa.Models;
using Xamarin.Forms;
using Ooui.AspNetCore;

namespace xamwa.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //return View();
            var page = new MainView();
            var element = page.GetOouiElement();
            return new ElementResult(element, "Hello XAML!");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
