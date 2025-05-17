using Microsoft.AspNetCore.Mvc;
using TaskX.Data;
using TaskX.Models;

namespace TaskX.Controllers
{
    public class TasksController : Controller
    {
        private readonly ApplicationDbContext _db;
        public TasksController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<TodoTask> getAllTasks = _db.TodoTasks.ToList();
            return View(getAllTasks);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(TodoTask Obj)
        {
            _db.TodoTasks.Add(Obj); //Adds the new entry to the database
            _db.SaveChanges();  //Saves the changes to the database
            return RedirectToAction("Index");  //This will redirect to the Index action method of the current controller (TasksController)
        }
    }
}
