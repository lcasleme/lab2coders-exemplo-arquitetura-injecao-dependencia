using L2C.Exemplo.Curto.Arquitetura.ID.Modelo.App;
using L2C.Exemplo.Curto.Arquitetura.ID.Modelo.Modelo.Interfaces;
using L2C.Exemplo.Curto.Arquitetura.ID.Modelo.Modelo.Repositorio;
using L2C.Exemplo.Curto.Arquitetura.ID.Modelo.Modelo.Servicos;
using SimpleInjector;

namespace L2C.Exemplo.Curto.Arquitetura.ID.Modelo.Mapeamento
{
    public class MapeamentoID
    {
        public static void RegistrarMapeamento(Container container)
        {
            //Aqui realizamos o registro de acordo com a requisição que foi realizada no controlador

            //Aplicacao
            container.RegisterPerWebRequest<IUsuarioAplicacaoServico, UsuarioAplicacaoServico>();

            //Dominio
            container.RegisterPerWebRequest<IUsuarioServico, UsuarioServico>();

            //Infra Dados
            container.RegisterPerWebRequest<IUsuarioRepositorio, UsuarioRepositorio>();
        }
    }
}