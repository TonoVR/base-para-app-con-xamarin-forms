using Bully.Services.Facade;
using Bully.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bully.ViewModels.Main
{
    public class IndexViewModel :  ViewModelBase
    {

        private  MovieFacade movieFacade;
        public IndexViewModel()
        {
            this.Title = "@elbrinner";
            this.movieFacade = new MovieFacade();

    }

        public override async Task InitializeAsync(object navigationData)
        {
            this.IsBusy = true;
            var response = await movieFacade.MovieLast();
            this.IsBusy = false;
            
        }


    }
}
