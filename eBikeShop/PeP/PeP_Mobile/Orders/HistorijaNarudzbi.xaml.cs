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
using PeP_PCL.Util;
using PeP_PCL.Models;
using System.Net.Http;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace PeP_Mobile.Orders
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HistorijaNarudzbi : Page
    {

        WebApiHelper narudzbeService = new WebApiHelper("http://localhost:30455/", "api/Narudzbe");
        
        public HistorijaNarudzbi()
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
            BindNarudzbe();
          
        }

        private void BindNarudzbe()
        {
            HttpResponseMessage response = narudzbeService.GetActionResponse("SelectAktivneByKupacID", Global.prijavljeniKupac.KupacID);
            if (response.IsSuccessStatusCode)
            {
                listNarudzbe.ItemsSource = response.Content.ReadAsAsync<List<Narudzbe>>().Result;
            }
        }

        private void listNarudzbe_ItemClick(object sender, ItemClickEventArgs e)
        {
            Narudzbe n = (Narudzbe)e.ClickedItem;
            HttpResponseMessage response = narudzbeService.GetActionResponse("SelectStavke",(n.NarudzbaID));
            if (response.IsSuccessStatusCode) {
             
                n.NarudzbaStavkes=response.Content.ReadAsAsync<List<NarudzbaStavke>>().Result;
                Frame.Navigate(typeof(DetaljiNarudzbe), n);
             
                    }
        }
    }
}
