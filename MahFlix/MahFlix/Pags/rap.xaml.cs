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
    public partial class rap : ContentPage
    {
        public rap()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            rap1.Source = ImageSource.FromResource("MahFlix.Posters.rap.jpg");
        }
    }
}