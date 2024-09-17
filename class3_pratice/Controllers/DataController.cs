using class3_pratice.Models;
using Microsoft.AspNetCore.Mvc;

namespace class3_pratice.Controllers
{
    public class DataController : Controller
    {
        public IActionResult Index()
        {
            int[] myints = {21,2,3,1,4,5,6,7};
            ViewData["msg"] = "This is the ViewData";
            ViewData["data"]=myints;

            ViewBag.ms = "This is the Viewdata";
            ViewBag.d = myints;
            return View();
        }
        public IActionResult product()
        {
            List<product>prodlist = new List<product>()
             {
                new product() { Id = 1,name="apple", unit="5kg",price=100,quantity=10},
                new product() { Id = 2,name="mango", unit="4kg",price=60,quantity=5},
                new product() { Id = 3,name="apple5", unit="5kg",price=100,quantity=10},

             };
            ViewBag.fruit = prodlist;
            return View();
        }
    }
}
