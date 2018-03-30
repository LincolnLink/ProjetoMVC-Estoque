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
            try
            {
                Produto p = new Produto();

                p.NomeProduto = model.Nome;
                p.Preco = model.Preco;
                p.Quantidade = model.Quantidade;
                p.IdEstoque = model.IdEstoque;

                ProdutoBusiness business = new ProdutoBusiness();

                business.Cadastrar(p);

                return Json($"Produto "+p.NomeProduto+" Cadastrado com sucesso! ");
            }
            catch (Exception e)
            {
                return Json(e.Message);
            }
            
        }

        public JsonResult ConsultarProdutos(string filtro)
        {            
            try
            {
                //declarando uma lista de classe de modelo
                List<ProdutoViewModelConsulta> lista = new List<ProdutoViewModelConsulta>();

                //instanciando a classe de negócio
                ProdutoBusiness business = new ProdutoBusiness();

                foreach (Produto p in business.ConsultarPorNome(filtro))
                {
                    ProdutoViewModelConsulta model = new ProdutoViewModelConsulta();

                    model.IdProduto = p.IdProduto;
                    model.Nome = p.NomeProduto;
                    model.Preco = p.Preco;
                    model.Quantidade = p.Quantidade;
                    model.Total = p.Quantidade * p.Preco;
                    model.DataCadastro = p.DataCadastro.ToString("dd/MM/yyyy");
                    model.NomeEstoque = p.Estoque.NomeEstoque;

                    lista.Add(model);
                }

                return Json(lista);
            }
            catch (Exception e)
            {
                return Json("Erro: " + e.Message);
            }
        }
    }
}