using Bully.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bully.ViewModels.Main
{
    public class MainViewModel : ViewModelBase
    {
        private MainMenuViewModel menuViewModel;

        public MainViewModel(MainMenuViewModel menuViewModel)
        {
            this.menuViewModel = menuViewModel;
        }

        public MainMenuViewModel MenuViewModel
        {
            get
            {
                return this.menuViewModel;
            }

            set
            {
                this.menuViewModel = value;
                RaisePropertyChanged();
            }
        }

        public override Task InitializeAsync(object navigationData)
        {
            return Task.WhenAll
                (
                    this.menuViewModel.InitializeAsync(navigationData),
                    NavigationService.NavigateToAsync<IndexViewModel>()
                );
        }
    }
}
