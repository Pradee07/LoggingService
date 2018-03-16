using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
//using TestLogging.Models;

namespace TestLogging.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            this._logger= logger;
        }
        public IActionResult Index()
        {
            _logger.LogInformation("Log from Index");
            return View();
        }

        public IActionResult About()
        {            
            //Start , Test Logs
            _logger.LogInformation("Information from About");
            _logger.LogError("Error from About");
            _logger.LogError("Error from About");
            //End , Test Log

            //Create an Exception
            throw new NullReferenceException();

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
            //return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            return null;
        }
    }
}
