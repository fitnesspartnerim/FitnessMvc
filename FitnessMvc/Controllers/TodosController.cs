using FitnessMvc.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Web.Mvc;

namespace FitnessMvc.Controllers
{
    public class TodosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TodosController()
        {
            _context = new ApplicationDbContext();;
        }

        [Authorize]
        public ActionResult Create()
        {
            var todo = new Todo();

            todo.CreateDate = DateTime.Now;

            return View(todo);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Create(Todo todo)
        {
            //if (!ModelState.IsValid)
            //    return View("Create", todo);

            var newTodo = new Todo
            {
                Title = todo.Title,
                UserId = User.Identity.GetUserId(),
                CreateDate = DateTime.Now,
                IsCompleted = todo.IsCompleted
            };

            _context.Todos.Add(newTodo);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}