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
    public sealed partial class DetaljiNarudzbe : Page
    {

        WebApiHelper narudzbeService=new WebApiHelper("http://localhost:30455/", "api/Narudzbe");
        Narudzbe narudzba;
        public DetaljiNarudzbe()
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
           narudzba = e.Parameter as Narudzbe;
            BindStavke();
            if (narudzba.Otkazano) {

                btnOtkazi.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            }
            if (!narudzba.Status)
            {

                btnOtkazi.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            }


        }

        private void BindStavke()
        {
            HttpResponseMessage response = narudzbeService.GetActionResponse("SelectProizvodiStavke", narudzba.NarudzbaID);
            if(response.IsSuccessStatusCode)
            listNarudzbaStavke.ItemsSource = response.Content.ReadAsAsync<List<ProizvodiNarudzbe>>().Result;
            
           
        }

        private async void btnOtkazi_Click(object sender, RoutedEventArgs e)
        {
            string message = "";
            narudzba.NarudzbaStavkes = null;
            narudzba.Otkazano = true;
            HttpResponseMessage response = narudzbeService.PutActionResponse(narudzba.NarudzbaID, narudzba);
            if (response.IsSuccessStatusCode)
            {
                message = "Narudžba uspješno otkazana";
                btnOtkazi.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            }
            else
            {


                message = "Otkazivanje narudžbe nije uspjelo. Došlo je do greške!";
            }

            MessageDialog msg = new MessageDialog(message);
            await msg.ShowAsync();

        }
    }
}
