using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MahFlix
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            btnNoz.Source = ImageSource.FromResource("MahFlix.Posters.noz.jpg");
            btnRap.Source = ImageSource.FromResource("MahFlix.Posters.rap.jpg");
            logo.Source = ImageSource.FromResource("MahFlix.Posters.logo.png");
            btnCisne.Source = ImageSource.FromResource("MahFlix.Posters.cisne.jpg");
            btnPlebe.Source = ImageSource.FromResource("MahFlix.Posters.plebe.jpg");
            btnFada.Source = ImageSource.FromResource("MahFlix.Posters.fada.jpg");
            btnPega.Source = ImageSource.FromResource("MahFlix.Posters.pega.jpg");
        }

        private void btnNoz_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Pags.noz());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void btnRap_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Pags.rap());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void btnCisne_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Pags.cisne());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void btnPlebe_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Pags.pobre());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void btnFada_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Pags.fairytopia());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void btnPega_Clicked(object sender, EventArgs e)
        {

        }
    }

}



