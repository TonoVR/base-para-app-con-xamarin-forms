using Bully.Interfaces.Navigation;
using Bully.Services.Facade;
using Bully.Services.Menu;
using Bully.Services.Navigation;
using Bully.ViewModels.Main;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Bully.ViewModels.Base
{
    public class ViewModelLocator
    {
        readonly IUnityContainer unityContainer;
        private static readonly ViewModelLocator instance = new ViewModelLocator();


        public static ViewModelLocator Instance
        {
            get
            {
                return instance;
            }
        }

        public ViewModelLocator()
        {
            unityContainer = new UnityContainer();

            // ViewModels
            unityContainer.RegisterType<MainViewModel>();

            // Services
            unityContainer.RegisterType<INavigationService, NavigationService>();
            unityContainer.RegisterType<IMenuService, MenuService>();
        }


        public T Resolve<T>()
        {
            return unityContainer.Resolve<T>();
        }

        public object Resolve(Type type)
        {
            return unityContainer.Resolve(type);
        }

        public void Register<T>(T instance)
        {
            unityContainer.RegisterInstance<T>(instance);
        }

        public void Register<TInterface, T>() where T : TInterface
        {
            unityContainer.RegisterType<TInterface, T>();
        }

        public void RegisterSingleton<TInterface, T>() where T : TInterface
        {
            unityContainer.RegisterType<TInterface, T>(new ContainerControlledLifetimeManager());
        }
    }
}
