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
    public partial class cisne : ContentPage
    {
        public cisne()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            pato.Source = ImageSource.FromResource("MahFlix.Posters.cisne.jpg");
        }
    }
}