using Microsoft.AspNetCore.Mvc;
using School_Register.Data.Models;
using School_Register.Data.Repositories;
using School_Register.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School_Register.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository<StudentAccount> studentAccRepo;
        private readonly IRepository<TeacherAccount> teacherAccRepo;

        public HomeController(
            IRepository<StudentAccount> studentAccRepo,
            IRepository<TeacherAccount> teacherAccRepo
            )
        {
            this.studentAccRepo = studentAccRepo;
            this.teacherAccRepo = teacherAccRepo;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            var model = new AccountViewModel();
            return this.View(model);
        }

        //public async Task<IActionResult> LoginAsync()
        //{

        //}

        public IActionResult Register()
        {
            var model = new AccountViewModel();
            return this.View(model);
        }

        //public async Task<IActionResult> RegisterAsync()
        //{

        //}
    }
}
