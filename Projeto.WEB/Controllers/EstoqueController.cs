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
    public class EstoqueController : Controller
    {
        //método para retornar os estoques para a página
        public JsonResult ConsultarEstoque()
        {
            try
            {
                List<EstoqueViewModelConsulta> lista = new List<EstoqueViewModelConsulta>();

                EstoqueBussines bussines = new EstoqueBussines();
                foreach(Estoque e in bussines.Consultar())
                {
                    EstoqueViewModelConsulta model = new EstoqueViewModelConsulta();
                    
                    model.IdEstoque = e.IdEstoque;
                    model.NomeEstoque = e.NomeEstoque;

                    lista.Add(model);
                    Console.WriteLine(model);
                }
                Console.WriteLine(lista);
                return Json(lista);
            }
            catch (Exception e)
            {
                //retornando mensagem de erro!
                return Json(e.Message);
            }
            
        }
    }
}