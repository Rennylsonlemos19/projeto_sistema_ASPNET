using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspnetVenda.Models;


namespace AspnetVenda.Controllers
{
    public class DepartmentsController1 : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "eletronics" });
            list.Add(new Department { Id = 2, Name = "fashion" });


            return View(list);
        }
    }
}
