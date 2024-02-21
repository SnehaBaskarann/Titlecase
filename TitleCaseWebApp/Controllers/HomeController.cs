using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TitleCaseWebApp.Models;

namespace TitleCaseWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly TestMe _testMe;

        public HomeController(TestMe testMe)
        {
            _testMe = testMe;
        }

        public IActionResult Index()
        {
            string originalText = "hello arun";
            string titleCaseText = _testMe.MakeTitle(originalText);

            //Console.WriteLine($"Original Text :{originalText}");
            //Console.WriteLine($"TitleCaseText : {titleCaseText}");

            ViewData["OriginalText"] ="hello arun";
            ViewData["TitlecaseText"] = titleCaseText;  

            return View();
        }

        
    }
}
