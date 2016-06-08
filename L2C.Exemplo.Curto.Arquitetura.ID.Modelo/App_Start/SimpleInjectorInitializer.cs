using L2C.Exemplo.Curto.Arquitetura.ID.Modelo.Mapeamento;
using L2C.EXP.Arquitetura.ID.UI.App_Start;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using System.Reflection;
using System.Web.Mvc;

[assembly: WebActivatorEx.PostApplicationStartMethod(typeof(SimpleInjectorInitializer), "Initialize")]

namespace L2C.EXP.Arquitetura.ID.UI.App_Start
{
    public class SimpleInjectorInitializer
    {
        public static void Initialize()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            InicializarContainer(container);

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());

            container.Verify();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }

        private static void InicializarContainer(Container container)
        {
            MapeamentoID.RegistrarMapeamento(container);
        }
    }
}