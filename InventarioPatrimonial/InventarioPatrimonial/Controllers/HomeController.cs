using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InventarioPatrimonial.Models;
using Negocio.Dominio;
using Servicos;

namespace InventarioPatrimonial.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Usuario()
        {
            return View();
        }

        public IActionResult OrdemDeServico()
        {
            return View();
        }

        public IActionResult Movimentacao(MovimentacaoModel item)
        {
            try
            {
                using (var servico = new ServicoDeMovimentacao())
                {
                    servico.Salve(item);
                }
                ViewData["Message"] = "Registro realizado com sucesso!";
            }
            catch (Exception e)
            {

            }
            
            return View();
            
            
        }

        public IActionResult TelaDeCadastroMovimentacao()
        {
            return View("Movimentacao");
        }

        public IActionResult CadastroDeMovimentacao(MovimentacaoModel item)
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
