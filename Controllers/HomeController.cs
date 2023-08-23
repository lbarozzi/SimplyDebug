using Microsoft.AspNetCore.Mvc;
using SimplyDebug.Models;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SimplyDebug.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger) {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index() {
            ViewBag.Request = Request;
            
            /*
            foreach(KeyValuePair<string,string> tk in Request.Query) {
                tk.
            }
            //*/
            return View();
        }
        [HttpPost("/")]
        public IActionResult IndexPost() {
            ViewBag.Request = Request;
            /*
            foreach(KeyValuePair<string,string> tk in Request.Query) {
                tk.
            }
            //*/
            return View("/Views/Home/Index.cshtml");
        }
        //*
        public IActionResult Privacy() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}