using FitnessMvc.Models;
using FitnessMvc.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Linq;
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
           return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult Create(TodoViewModel todo)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors);

                return View("Create", todo);
            }
                

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