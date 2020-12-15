using RedCorners;
using RedCorners.Forms;
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
    public partial class ContentPage1
    {
        public ContentPage1()
        {
            InitializeComponent();
            BindingContext = new ContentPage1VM();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Page1 page = new Page1();
            await Navigation.PushAsync(page);
        }
    }
}