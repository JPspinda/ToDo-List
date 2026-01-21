using Microsoft.AspNetCore.Mvc;

namespace To_Do_List.Controllers
{
    public class ToDoList : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
