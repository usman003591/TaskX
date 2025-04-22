using Microsoft.AspNetCore.Mvc;

namespace TaskX.Controllers
{
    public class TasksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
