using L2C.Exemplo.Curto.Arquitetura.ID.Modelo.App;
using L2C.Exemplo.Curto.Arquitetura.ID.Modelo.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace L2C.Exemplo.Curto.Arquitetura.ID.Modelo.Controllers
{
    public class DefaultController : Controller
    {
        //Aqui acontece a mágica da Injeção de Dependência - Ao invés de utilizar a implementação de uma classe concreta
        //utilizamos uma Interface mapeada para que possamos utilizar os métodos da classe concreta sem a necessidade de dar um new();
        private readonly IUsuarioAplicacaoServico _usuarioAplicacaoServico;

        //Ao inicializar a classe passando a Interface como paramêtro através da Injeção de Dependência realizada no container
        //será realizado o mapeamento da Interface com a Classe concreta
        public DefaultController(IUsuarioAplicacaoServico usuarioAplicacaoServico)
        {
            _usuarioAplicacaoServico = usuarioAplicacaoServico;
        }

        // GET: Default
        public ActionResult Index()
        {
            //Utilizando a Interface para consumir os métodos da Classe concreta
            Usuario listUsuario = _usuarioAplicacaoServico.ObterPorUsuario("");
            return View();
        }
    }
}