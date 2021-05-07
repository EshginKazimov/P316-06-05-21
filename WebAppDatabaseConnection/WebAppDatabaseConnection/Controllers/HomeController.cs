using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppDatabaseConnection.DataAccessLayer;
using WebAppDatabaseConnection.Models;

namespace WebAppDatabaseConnection.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            //var students = new List<Student>
            //{
            //    new Student {Id = 1, Name = "Faig", Surname = "Abdullayev", Age = 21},
            //    new Student {Id = 2, Name = "Nihat", Surname = "Osmanov", Age = 20},
            //    new Student {Id = 3, Name = "Hashim", Surname = "Seyidov", Age = 20},
            //    new Student {Id = 4, Name = "Nazim", Surname = "Hasanov", Age = 29},
            //    new Student {Id = 5, Name = "Abdulaziz", Surname = "Karimli", Age = 20}
            //};

            //var students = _db.Students.Include(x => x.Group).Where(student => student.Group.Name == "P316").ToList();
            var students = _db.Students.Include(x => x.Group).ToList();
            var p316Students = students.Where(student => student.Group.Name == "P316").ToList();

            return View(p316Students);
        }
    }
}
