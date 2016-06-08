using L2C.Exemplo.Curto.Arquitetura.ID.Modelo.Modelo.Entidades;
using L2C.Exemplo.Curto.Arquitetura.ID.Modelo.Modelo.Interfaces;

namespace L2C.Exemplo.Curto.Arquitetura.ID.Modelo.Modelo.Repositorio
{
    public class UsuarioRepositorio : Repositorio<Usuario>, IUsuarioRepositorio
    {
        public Usuario ObterPorUsuario(string usuario)
        {
            return base.Procurar(u => u.Login == usuario);
        }
    }
}