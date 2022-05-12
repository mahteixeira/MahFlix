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
    public partial class pobre : ContentPage
    {
        public pobre()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            plebe.Source = ImageSource.FromResource("MahFlix.Posters.plebe.jpg");
        }
    }
}