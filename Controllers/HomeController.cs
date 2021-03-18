using Microsoft.AspNetCore.Mvc;
using RibbonWeb.Models;
using System.Linq;

namespace RibbonWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Support()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Support(UserLog userLog)
        {
            Repository.AddLog(userLog);
            return View("LogComplete", userLog);
        }

        public ViewResult ListLogs()
        {
            return View(Repository.Logs.OrderBy(l => l.ID));
        }

        public ViewResult RibbonResponce(UserLog userLog)
        {
            return View("Index", Repository.Logs.Where(l => l.ID == l.ID));
        }
    }
}