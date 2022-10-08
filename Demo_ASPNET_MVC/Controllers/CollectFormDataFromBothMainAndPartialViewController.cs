using Demo_ASPNET_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;

namespace Demo_ASPNET_MVC.Controllers
{
    public class CollectFormDataFromBothMainAndPartialViewController : Controller
    {
        public IActionResult CollectFormDataFromBothMainAndPartialView()
        {
            return View();
        }

        [HttpPost]
        public void GetFormDataFromMainAndPartialView(Employee empFormData)
        {

        }
    }
}
