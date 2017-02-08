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
using PeP_PCL.Models;
using PeP_PCL.Util;
using System.Net.Http;
namespace PeP_Mobile.Products
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class OdabirVrsteProizvoda : Page
    {
        WebApiHelper vrsteService = new WebApiHelper("http://localhost:30455/", "api/VrsteProizvoda");

        public OdabirVrsteProizvoda()
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

            BindVrste();
        }

        private void BindVrste()
        {

            HttpResponseMessage responseVrste = vrsteService.GetResponse();
            if (responseVrste.IsSuccessStatusCode)
            {

                listVrsteProizvoda.ItemsSource = responseVrste.Content.ReadAsAsync<List<VrsteProizvoda>>().Result;
               



            }
            else {




            }
        }

        private void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {

            Frame.Navigate(typeof(Products.Pretraga), (VrsteProizvoda)e.ClickedItem);
;
        }

    
    }
}
