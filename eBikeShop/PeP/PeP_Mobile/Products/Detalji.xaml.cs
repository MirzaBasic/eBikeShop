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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Popups;
using System.Net.Http;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace PeP_Mobile.Products
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Detalji : Page
    {
        WebApiHelper proizvodiService = new WebApiHelper("http://localhost:30455/", "api/Proizvodi");

        WebApiHelper ocjeneService = new WebApiHelper("http://localhost:30455/", "api/Ocjene");
        Proizvodi proizvod = new Proizvodi();
        public Detalji()
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
            proizvod = e.Parameter as Proizvodi;
            

            BindDetalji();
            BindPreporuceniProizvodi();

            if (Global.prijavljeniKupac != null) {
                btnKupi.Visibility = Windows.UI.Xaml.Visibility.Visible;
                kolicinaTxt.Visibility= Windows.UI.Xaml.Visibility.Visible;
                kolicinaInput.Visibility = Windows.UI.Xaml.Visibility.Visible;
                gridRateStars.Visibility = Windows.UI.Xaml.Visibility.Visible;
                ocijeniProizvodTxt.Visibility= Windows.UI.Xaml.Visibility.Visible;
            }


        }

        private void BindPreporuceniProizvodi()
        {
            HttpResponseMessage response = proizvodiService.GetActionResponse("RecomendedProduct", proizvod.ProizvodID);
            if (response.IsSuccessStatusCode) {
                List<Proizvodi> preporuceniProizvodi= response.Content.ReadAsAsync<List<Proizvodi>>().Result;
                if (preporuceniProizvodi != null)
                    listPreporuceniProizvodi.ItemsSource = preporuceniProizvodi;


            }
        }

        private async void BindDetalji()
        {

            HttpResponseMessage response = proizvodiService.GetActionResponse("SelectByID", proizvod.ProizvodID);
            if (response.IsSuccessStatusCode) {
                proizvod = response.Content.ReadAsAsync<Proizvodi>().Result;
            MemoryStream ms = new MemoryStream(proizvod.SlikaThumb);

            BitmapImage image = new BitmapImage();
            await image.SetSourceAsync(ms.AsRandomAccessStream());
            imageProizvoda.Source = image;



            nazivProizvodaTxt.Text = "Naziv: "+proizvod.Naziv;
            sifraProizvodaTxt.Text = "Sifra: "+proizvod.Sifra;
            cijenaProizvodaTxt.Text = "Cijena: "+proizvod.Cijena+" KM";
            ocjenaProizvodaTxt.Text = "Ocjena: "+Math.Round(proizvod.ProsjecnaOcjena.GetValueOrDefault(0),1);
            }
        }

        private async void btnKupi_Click(object sender, RoutedEventArgs e)
        {

            if (Convert.ToInt32(kolicinaInput.Text) < 1)
            {
                MessageDialog msg = new MessageDialog("Količina mora biti veća od 0");
                await msg.ShowAsync();


            }

            else
            {
                if (Global.aktivnaNarudzba == null)
                {

                    Global.aktivnaNarudzba = new Narudzbe();
                    Global.aktivnaNarudzba.BrojNarudzbe = "N-/" + DateTime.Now.Millisecond + "-" + Global.prijavljeniKupac.KupacID;
                    Global.aktivnaNarudzba.Datum = DateTime.Now;
                    Global.aktivnaNarudzba.KupacID = Global.prijavljeniKupac.KupacID;
                }

                bool proizvodPostoji = false;
                foreach (NarudzbaStavke item in Global.aktivnaNarudzba.NarudzbaStavkes)
                {
                    if (item.ProizvodID == proizvod.ProizvodID)
                    {
                        item.Kolicina += Convert.ToInt32(kolicinaInput.Text);
                        proizvodPostoji = true;
                        break;

                    }
                }
                string message = "Uspješno ste dodali proizvod u korpu";
                if (proizvodPostoji)
                {

                    message = "Uspješno ste izmijenili kolicinu proizvoda u korpi";
                }


                else
                {


                    NarudzbaStavke s = new NarudzbaStavke();
                    s.ProizvodID = proizvod.ProizvodID;
                    s.Kolicina = Convert.ToInt32(kolicinaInput.Text);
                    s.Proizvodi = proizvod;

                    Global.aktivnaNarudzba.NarudzbaStavkes.Add(s);
                }


                MessageDialog msg = new MessageDialog(message);
                await msg.ShowAsync();
                kolicinaInput.Text = "";
                btnZakljuci.Visibility = Windows.UI.Xaml.Visibility.Visible;
            }
            
        }

        private void btnZakljuci_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Orders.Korpa));
        }

        private void listPreporuceniProizvodi_ItemClick(object sender, ItemClickEventArgs e)
        {


            Frame.Navigate(typeof(Detalji), ((Proizvodi)e.ClickedItem));

        }



        private async void star5_Click(object sender, RoutedEventArgs e)
        {
            if (Global.prijavljeniKupac == null)
            {
                return;
            }

            HttpResponseMessage response = ocjeneService.GetResponse();
            if (response.IsSuccessStatusCode)
            {

                List<Ocjene> ocjene = response.Content.ReadAsAsync<List<Ocjene>>().Result;
                if (ocjene.Where(x => x.ProizvodID == proizvod.ProizvodID && x.KupacID == Global.prijavljeniKupac.KupacID).Count() > 0)
                {
                    MessageDialog msg = new MessageDialog("Već ste ocijenili ovaj proizvod");
                    await msg.ShowAsync();
                    return;

                }


                
            }


            star1.Visibility = Visibility.Collapsed;
            star1Full.Visibility = Visibility.Visible;

            star2.Visibility = Visibility.Collapsed;
            star2Full.Visibility = Visibility.Visible;

            star3.Visibility = Visibility.Collapsed;
            star3Full.Visibility = Visibility.Visible;

            star4.Visibility = Visibility.Collapsed;
            star4Full.Visibility = Visibility.Visible;

            star5.Visibility = Visibility.Collapsed;
            star5Full.Visibility = Visibility.Visible;

            ocjeneService.PostResponse(new Ocjene { Ocjena = 5, ProizvodID = proizvod.ProizvodID, KupacID = Global.prijavljeniKupac.KupacID, Datum = DateTime.Now });


        }

        private async void star4_Click(object sender, RoutedEventArgs e)
        {

            if (Global.prijavljeniKupac == null)
            {
                return;
            }

            HttpResponseMessage response = ocjeneService.GetResponse();
            if (response.IsSuccessStatusCode)
            {

                List<Ocjene> ocjene = response.Content.ReadAsAsync<List<Ocjene>>().Result;
                if (ocjene.Where(x => x.ProizvodID == proizvod.ProizvodID && x.KupacID == Global.prijavljeniKupac.KupacID).Count() > 0)
                {
                    MessageDialog msg = new MessageDialog("Već ste ocijenili ovaj proizvod");
                    await msg.ShowAsync();
                    return;

                }
               
            }


            star1.Visibility = Visibility.Collapsed;
            star1Full.Visibility = Visibility.Visible;

            star2.Visibility = Visibility.Collapsed;
            star2Full.Visibility = Visibility.Visible;

            star3.Visibility = Visibility.Collapsed;
            star3Full.Visibility = Visibility.Visible;

            star4.Visibility = Visibility.Collapsed;
            star4Full.Visibility = Visibility.Visible;


            ocjeneService.PostResponse(new Ocjene { Ocjena = 4, ProizvodID = proizvod.ProizvodID, KupacID = Global.prijavljeniKupac.KupacID, Datum = DateTime.Now });


        }


        private async void star3_Click(object sender, RoutedEventArgs e)
        {
            if (Global.prijavljeniKupac == null)
            {
                return;
            }

            HttpResponseMessage response = ocjeneService.GetResponse();
            if (response.IsSuccessStatusCode)
            {

                List<Ocjene> ocjene = response.Content.ReadAsAsync<List<Ocjene>>().Result;
                if (ocjene.Where(x => x.ProizvodID == proizvod.ProizvodID && x.KupacID == Global.prijavljeniKupac.KupacID).Count() > 0)
                {
                    MessageDialog msg = new MessageDialog("Već ste ocijenili ovaj proizvod");
                    await msg.ShowAsync();
                    return;

                }
            }


            star1.Visibility = Visibility.Collapsed;
            star1Full.Visibility = Visibility.Visible;

            star2.Visibility = Visibility.Collapsed;
            star2Full.Visibility = Visibility.Visible;

            star3.Visibility = Visibility.Collapsed;
            star3Full.Visibility = Visibility.Visible;


            ocjeneService.PostResponse(new Ocjene { Ocjena = 3, ProizvodID = proizvod.ProizvodID, KupacID = Global.prijavljeniKupac.KupacID, Datum = DateTime.Now });

        }

        private async void star2_Click(object sender, RoutedEventArgs e)
        {
            if (Global.prijavljeniKupac == null)
            {
                return;
            }

            HttpResponseMessage response = ocjeneService.GetResponse();
            if (response.IsSuccessStatusCode)
            {

                List<Ocjene> ocjene = response.Content.ReadAsAsync<List<Ocjene>>().Result;
                if (ocjene.Where(x => x.ProizvodID == proizvod.ProizvodID && x.KupacID == Global.prijavljeniKupac.KupacID).Count() > 0)
                {
                    MessageDialog msg = new MessageDialog("Već ste ocijenili ovaj proizvod");
                    await msg.ShowAsync();
                    return;

                }
            }


            star1.Visibility = Visibility.Collapsed;
            star1Full.Visibility = Visibility.Visible;

            star2.Visibility = Visibility.Collapsed;
            star2Full.Visibility = Visibility.Visible;



            ocjeneService.PostResponse(new Ocjene { Ocjena = 2, ProizvodID = proizvod.ProizvodID, KupacID = Global.prijavljeniKupac.KupacID, Datum = DateTime.Now });

        }

        private async void star1_Click(object sender, RoutedEventArgs e)
        {
            if (Global.prijavljeniKupac == null)
            {
                return;
            }

            HttpResponseMessage response = ocjeneService.GetResponse();
            if (response.IsSuccessStatusCode)
            {

                List<Ocjene> ocjene = response.Content.ReadAsAsync<List<Ocjene>>().Result;
                if (ocjene.Where(x => x.ProizvodID == proizvod.ProizvodID && x.KupacID == Global.prijavljeniKupac.KupacID).Count() > 0)
                {
                    MessageDialog msg = new MessageDialog("Već ste ocijenili ovaj proizvod");
                    await msg.ShowAsync();
                    return;

                }
            }


            star1.Visibility = Visibility.Collapsed;
            star1Full.Visibility = Visibility.Visible;



            ocjeneService.PostResponse(new Ocjene { Ocjena = 1, ProizvodID = proizvod.ProizvodID, KupacID = Global.prijavljeniKupac.KupacID, Datum = DateTime.Now });


        }
    }
}

