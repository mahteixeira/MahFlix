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
    public partial class noz : ContentPage
    {
        public noz()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            naz.Source = ImageSource.FromResource("MahFlix.Posters.noz.jpg");


        }
    }
}