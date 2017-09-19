using Bully.Models;
using Bully.Services.Menu;
using Bully.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Bully.ViewModels.Main
{
    public class MainMenuViewModel : ViewModelBase
    {
        private ObservableCollection<MenuItem> menu;
        private MenuItem selectedMenu;

        private ICommand indexCommand;


        public ICommand IndexCommand
        {
            get { return indexCommand = indexCommand ?? new DelegateCommand(DoIndexCommandExecute); }
        }

        private async void DoIndexCommandExecute()
        {
            await this.NavigationService.NavigateToAsync<IndexViewModel>();
        }

        private IMenuService menuService;

        public MainMenuViewModel(
            IMenuService menuService)
        {
            this.menuService = menuService;
        }

        public ObservableCollection<MenuItem> Menu
        {
            get { return this.menu; }
            set
            {
                this.menu = value;
                this.RaisePropertyChanged("Menu");
            }
        }

        public MenuItem SelectedMenu
        {
            get { return this.selectedMenu; }
            set
            {
                this.selectedMenu = value;

                if (this.selectedMenu.PageType != null)
                    NavigationService.NavigateToAsync(this.selectedMenu.PageType);
            }
        }

        public override Task InitializeAsync(object navigationData)
        {
            Menu = this.menuService.LoadMenu();

            return base.InitializeAsync(navigationData);
        }
    }
}
