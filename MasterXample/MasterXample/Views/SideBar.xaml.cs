using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MasterXample.ViewModel;

namespace MasterXample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SideBar : ContentView
    {
        public SideBar()
        {
            InitializeComponent();
            BindingContext = new SideBarVM();
        }
    }
}