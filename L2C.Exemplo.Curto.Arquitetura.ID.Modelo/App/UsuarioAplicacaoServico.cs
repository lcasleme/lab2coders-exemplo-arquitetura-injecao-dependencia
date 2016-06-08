using L2C.Exemplo.Curto.Arquitetura.ID.Modelo.Modelo.Entidades;
using L2C.Exemplo.Curto.Arquitetura.ID.Modelo.Modelo.Servicos;
using System;

namespace L2C.Exemplo.Curto.Arquitetura.ID.Modelo.App
{
    public class UsuarioAplicacaoServico : IUsuarioAplicacaoServico
    {
        //Aqui acontece a mágica da Injeção de Dependência - Ao invés de utilizar a implementação de uma classe concreta
        //utilizamos uma Interface mapeada para que possamos utilizar os métodos da classe concreta sem a necessidade de dar um new();
        private readonly IUsuarioServico _usuarioServico;

        //Ao inicializar a classe passando a Interface como paramêtro através da Injeção de Dependência realizada no container
        //será realizado o mapeamento da Interface com a Classe concreta
        public UsuarioAplicacaoServico(IUsuarioServico usuarioServico)
        {
            _usuarioServico = usuarioServico;
        }

        public Usuario ObterPorUsuario(string usuario)
        {
            //Utilizando a Interface para consumir os métodos da Classe concreta
            return _usuarioServico.ObterPorUsuario(usuario);
        }

        public Guid IdUsuario(Guid idusuario)
        {
            return idusuario;
        }
    }
}