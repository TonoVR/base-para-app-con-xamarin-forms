using Bully.Models;
using Bully.ViewModels.About;
using Bully.ViewModels.Main;
using System.Collections.ObjectModel;

namespace Bully.Services.Menu
{
    public class MenuService : IMenuService
    {
        public ObservableCollection<MenuItem> LoadMenu()
        {
            return new ObservableCollection<MenuItem> {
               new MenuItem("Inicio", typeof(MainViewModel)),
               new MenuItem("Acerca de la app", typeof(AboutViewModel))
        };
        }
    }
}