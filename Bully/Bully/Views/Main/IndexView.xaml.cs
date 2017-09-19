using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bully.Views.Main
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IndexView : ContentPage
    {
        public IndexView()
        {
            InitializeComponent();
            outerScrollView.Scrolled += OnScroll;
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            outerScrollView.Scrolled -= OnScroll;
        }

        public void OnScroll(object sender, ScrolledEventArgs e)
        {

        }

        protected override void OnAppearing()
        {

            InitializeComponent();
        }
    }

}
