using Microsoft.AspNetCore.Mvc;
using Moneris_Hosted_Paypage_Demo.Models;
using System.Diagnostics;

namespace Moneris_Hosted_Paypage_Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            ViewBag.StoreId = _configuration["MonerisHostedPaypage:StoreId"];
            ViewBag.Key = _configuration["MonerisHostedPaypage:Key"];
            ViewBag.Url = _configuration["MonerisHostedPaypage:Url"];

            return View();
        }

        public IActionResult Privacy()
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