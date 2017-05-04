using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LabCompras.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace LabCompras.Controllers
{
    public class DespesasController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult NovaDespesa()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NovaDespesa(Despesa despesa)
        {
            if (ModelState.IsValid)
            {
                Repository.AddDespesa(despesa);               
                return View("DespesaConfirmada", despesa);
            }
            else
                return View();
        }

    }

}

