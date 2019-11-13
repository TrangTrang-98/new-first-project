using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace DangKi.Controllers
{
    
    public class AccountController : Controller
    {
         public IActionResult PatientLogin()
        {
            return View();
        }

         public IActionResult PatientSign()
        {
            return View();
        }
        
    }
}