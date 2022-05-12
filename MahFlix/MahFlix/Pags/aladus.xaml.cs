using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MahFlix.Pags
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class aladus : ContentPage
    {
        public aladus()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            cavalo.Source = ImageSource.FromResource("MahFlix.Posters.pega.jpg");
        }
    }
}