using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MVC_test.Models;
using System.Diagnostics;

namespace MVC_test.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _config;

        public HomeController(IConfiguration config)
        {
            _config = config;
        }

        public IActionResult Index()
        {
            if (_config.GetValue<bool>("StudentFormFeatures:AddIsEnabled"))
            {
                return View();

            }
            else
            {
                return null;
            }


        }



        
    }
}