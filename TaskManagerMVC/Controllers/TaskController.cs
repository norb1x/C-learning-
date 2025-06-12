using Microsoft.AspNetCore.Mvc;
using TaskManagerMVC.Models;
using System.Collections.Generic;

namespace TaskManagerMVC.Controllers
{
    public class TaskController : Controller
    {
        private static List<Task> tasks = new List<Task>();

        public IActionResult Index()
        {
            return View(tasks);
        }

        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Task task)
        {
            if (ModelState.IsValid)
            {
                task.Id = tasks.Count + 1;
                tasks.Add(task);
                return RedirectToAction("Index");
            }
            return View(task);
        }
    }
}