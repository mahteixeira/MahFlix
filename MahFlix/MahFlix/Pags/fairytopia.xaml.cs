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
    public partial class fairytopia : ContentPage
    {
        public fairytopia()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            fada.Source = ImageSource.FromResource("MahFlix.Posters.fada.jpg");
        }
    }
}