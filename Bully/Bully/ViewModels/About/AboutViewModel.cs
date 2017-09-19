using Bully.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bully.ViewModels.About
{
    public class AboutViewModel : ViewModelBase
    {
     

        public override Task InitializeAsync(object navigationData)
        {

            this.Title = "Acerca de";

            return Task.FromResult(false);
        }
    }
}
