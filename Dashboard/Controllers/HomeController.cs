using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Dashboard.Domain.Model;
using Microsoft.AspNetCore.Mvc;
using Dashboard.Models;

namespace Dashboard.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
           var venda = new Venda();

            ViewBag.Vendas = venda.ListagemVendasMocada().ToList().GroupBy(x => DateTime.Parse(x.DataVenda.ToShortDateString()))
                .OrderByDescending(x => x.Key)
                .Select(x => new KeyValuePair<string, int>(x.Key.ToString("dd/MM/yyyy"), x.Count()))
                .ToList();


            ViewBag.ResumoMes = new KeyValuePair<decimal, int>(venda.ListagemVendasMocada().Sum(x => x.Valor), venda.ListagemVendasMocada().Count());

            return View();
        }
    }
}
