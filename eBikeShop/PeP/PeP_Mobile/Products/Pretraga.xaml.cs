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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556


using System.Net.Http;
using PeP_PCL.Models;
using PeP_PCL.Util;

namespace PeP_Mobile.Products
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Pretraga : Page
    {
        WebApiHelper proizvodiService = new WebApiHelper("http://localhost:30455/", "api/Proizvodi");

        VrsteProizvoda vrsta;
        Proizvodi p = new Proizvodi();
        
        public  Pretraga()
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
           vrsta = e.Parameter as VrsteProizvoda;

            if (vrsta != null)
            {
                vrstaProizvodaTxt.Text = vrsta.Naziv;
                pretragaNazivInput_TextChanged(null, null);
            }
        }

        private void pretragaNazivInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            HttpResponseMessage responseProizvodi = proizvodiService.GetActionResponse("SearchProizvodiNazivVrsta", vrsta.VrstaID, pretragaNazivInput.Text);

            if (responseProizvodi.IsSuccessStatusCode)
            {
                List<Proizvodi> proizvodi = responseProizvodi.Content.ReadAsAsync<List<Proizvodi>>().Result;
                listProizvodiNaziv.ItemsSource = proizvodi;



            }

            else {






            }



        }

        private void listProizvodiNaziv_ItemClick(object sender, ItemClickEventArgs e)
        {

            Frame.Navigate(typeof(Detalji), ((Proizvodi)e.ClickedItem));
        }
    }
}
