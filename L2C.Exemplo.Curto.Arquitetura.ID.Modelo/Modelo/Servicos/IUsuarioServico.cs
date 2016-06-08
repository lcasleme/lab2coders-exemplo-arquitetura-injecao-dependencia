using L2C.Exemplo.Curto.Arquitetura.ID.Modelo.Modelo.Entidades;
using System;

namespace L2C.Exemplo.Curto.Arquitetura.ID.Modelo.Modelo.Servicos
{
    public interface IUsuarioServico : IDisposable
    {
        Usuario ObterPorUsuario(string usuario);
    }
}