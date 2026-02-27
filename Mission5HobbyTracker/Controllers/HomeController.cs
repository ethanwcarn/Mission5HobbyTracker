// Import the Diagnostics namespace for Activity tracking in error handling
using System.Diagnostics;
// Import ASP.NET Core MVC namespace for Controller base class and action results
using Microsoft.AspNetCore.Mvc;
// Import the project's Models namespace for ErrorViewModel
using Mission5HobbyTracker.Models;

// Define the namespace for all controllers in this project
namespace Mission5HobbyTracker.Controllers
{
    // HomeController inherits from Controller to handle HTTP requests for the Home routes
    public class HomeController : Controller
    {
        // GET: /Home/Index — returns the homepage view about BYU vintage apparel
        public IActionResult Index()
        {
            // Render and return the Index view (Views/Home/Index.cshtml)
            return View();
        }

        // GET: /Home/Calculator — returns the tutoring calculator view
        public IActionResult Calculator()
        {
            // Render and return the Calculator view (Views/Home/Calculator.cshtml)
            return View();
        }

        // GET: /Home/Error — returns the error page; response caching is disabled for fresh error info
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            // Create an ErrorViewModel with the current request ID for debugging, then render the Error view
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
