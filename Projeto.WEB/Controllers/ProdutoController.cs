using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projeto.Entidades;
using Projeto.BLL;
using Projeto.WEB.Models;

namespace Projeto.WEB.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto/Cadastro
        public ActionResult Cadastro()
        {
            return View();
        }

        // GET: Produto/Consulta
        public ActionResult Consulta()
        {
            return View();
        }

        // POST: Produto/CadastrarProduto
        public JsonResult CadastrarProduto(ProdutoViewModelCadastro model)
        {
            return Json("OK");
        }

    }
}