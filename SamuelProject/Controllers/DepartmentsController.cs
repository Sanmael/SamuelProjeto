using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SamuelProject.Models.ViewModels;

namespace SamuelProject.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Departament> list = new List<Departament>();
            list.Add(new Departament { ID = 1, Name = "Eletronics" });
            list.Add(new Departament { ID = 2, Name = "Fashion" });

            return View(list);
        }
    }
}
