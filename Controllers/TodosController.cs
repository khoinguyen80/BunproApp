using BunproApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace BunproApp.Controllers
{
    public class TodosController : Controller
    {
        private ApplicationDbContext _context;
        public TodosController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Todos
        public ActionResult Index()
        {
            var todos = _context.Todos.ToList();
            return View(todos);
        }
    }
}