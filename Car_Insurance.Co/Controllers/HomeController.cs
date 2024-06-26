using Car_Insurance.Co.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Car_Insurance.Co.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }


        public IActionResult Services()
        {
            return View();
        }
        public IActionResult ServiceDetail()
        {
            return View();
        }

        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult NewsDetail()
        {
            return View();
        }
        public IActionResult InsuranceForm()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }     
        public IActionResult NotFound()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Signup()
        {
            return View();
        }

        public IActionResult Team()
        {
            return View();
        }

        public IActionResult TeamDetail()
        {
            return View();
        }
                public IActionResult Tearms()
        {
            return View();
        }







        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
          
        }
    }
}