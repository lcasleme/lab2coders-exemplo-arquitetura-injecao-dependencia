using L2C.Exemplo.Curto.Arquitetura.ID.Modelo.Modelo.Entidades;
using L2C.Exemplo.Curto.Arquitetura.ID.Modelo.Modelo.Interfaces;

namespace L2C.Exemplo.Curto.Arquitetura.ID.Modelo.Modelo.Servicos
{
    public class UsuarioServico : IUsuarioServico
    {
        //Aqui acontece a mágica da Injeção de Dependência - Ao invés de utilizar a implementação de uma classe concreta
        //utilizamos uma Interface mapeada para que possamos utilizar os métodos da classe concreta sem a necessidade de dar um new();
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        //Ao inicializar a classe passando a Interface como paramêtro através da Injeção de Dependência realizada no container
        //será realizado o mapeamento da Interface com a Classe concreta
        public UsuarioServico(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public Usuario ObterPorUsuario(string usuario)
        {
            //Utilizando a Interface para consumir os métodos da Classe concreta
            return _usuarioRepositorio.ObterPorUsuario(usuario);
        }

        public void Dispose()
        {
            _usuarioRepositorio.Dispose();
        }
    }
}