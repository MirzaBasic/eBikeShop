using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using PeP_PCL.Models;
using PeP_PCL.Util;
using System.Net.Http;
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace PeP_Mobile.Orders
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Korpa : Page
    {
        WebApiHelper narudzbeService=new WebApiHelper("http://localhost:30455/", "api/Narudzbe");

        public Korpa()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            if (Global.aktivnaNarudzba == null) {
                btnZakljuci.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                praznaKorpaTxt.Visibility = Windows.UI.Xaml.Visibility.Visible;
            }
            else {
                BindKorpa();
            }
         
        }

        private void BindKorpa()
        {
            decimal iznos = 0;
            listProizvodiKorpa.ItemsSource = Global.aktivnaNarudzba.NarudzbaStavkes;

            foreach (NarudzbaStavke item in Global.aktivnaNarudzba.NarudzbaStavkes)
            {
                iznos += item.Kolicina * item.Proizvodi.Cijena;
            }

            iznosTxt.Text = "Ukupan iznos: "+iznos+" KM";
        }

        private void listProizvodiKorpa_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private async void btnZakljuci_Click(object sender, RoutedEventArgs e)
        {
            string message = "";
            HttpResponseMessage response = narudzbeService.PostResponse(Global.aktivnaNarudzba);
            if (response.IsSuccessStatusCode)
            {


                message = "Naružba uspjesno zaključena";
                Global.aktivnaNarudzba = null;

                OnNavigatedTo(null);
                listProizvodiKorpa.ItemsSource = null;
                iznosTxt.Text = "";
            }

            else
            {

                message = "Narudžba nije zaključena. Došlo je do greske!";
            }

            MessageDialog msg = new MessageDialog(message);
            await msg.ShowAsync();


           
        }
    }
}
