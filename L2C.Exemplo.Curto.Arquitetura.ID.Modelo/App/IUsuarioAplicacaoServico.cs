using L2C.Exemplo.Curto.Arquitetura.ID.Modelo.Modelo.Entidades;
using System;

namespace L2C.Exemplo.Curto.Arquitetura.ID.Modelo.App
{
    public interface IUsuarioAplicacaoServico
    {
        Guid IdUsuario(Guid idusuario);

        Usuario ObterPorUsuario(string usuario);
    }
}