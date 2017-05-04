using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LabCompras.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace LabCompras.Controllers
{
    public class ContaController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult NovaConta()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NovaConta(ContaBancaria conta)
        {
            if (ModelState.IsValid)
            {
                return View("ContaConfirmada", conta);
            }
            else
                return View();
        }
    }
}
