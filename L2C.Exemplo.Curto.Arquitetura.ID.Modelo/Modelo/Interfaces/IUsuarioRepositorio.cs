using L2C.Exemplo.Curto.Arquitetura.ID.Modelo.Modelo.Entidades;

namespace L2C.Exemplo.Curto.Arquitetura.ID.Modelo.Modelo.Interfaces
{
    public interface IUsuarioRepositorio : IRepositorio<Usuario>
    {
        Usuario ObterPorUsuario(string usuario);
    }
}