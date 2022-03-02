using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CompassApp
{
    public partial class MainPage : ContentPage
    {

        CompassViewModel vm;

        public MainPage()
        {
            InitializeComponent();

            BindingContext = vm = new CompassViewModel();

            vm.StartCompass();
        }
    }
}
