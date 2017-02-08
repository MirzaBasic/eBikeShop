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

namespace PeP_Mobile.Users
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class KorisnickiProfil : Page
    {
        WebApiHelper korisniciService = new WebApiHelper("http://localhost:30455/", "api/Kupci");
        public KorisnickiProfil()
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
            imeInput.Text = Global.prijavljeniKupac.Ime;
            prezimeInput.Text = Global.prijavljeniKupac.Prezime;
            korisnickoImeInput.Text = Global.prijavljeniKupac.KorisnickoIme;
            emailInput.Text = Global.prijavljeniKupac.Email;
            lozinkaPonovoInput.Password = Global.Lozinka;
            lozinkaInput.Password = Global.Lozinka;



        }

        private void btnOmoguciPromjenu_Click(object sender, RoutedEventArgs e)
        {
           
            emailInput.IsEnabled = true;
            imeInput.IsEnabled = true;
            prezimeInput.IsEnabled = true;
            korisnickoImeInput.IsEnabled = true;
            lozinkaPonovoInput.IsEnabled = true;
            lozinkaInput.IsEnabled = true;

           izmijeniSacuvajGrid.Visibility= Windows.UI.Xaml.Visibility.Visible;
            btnOmoguciPromjenu.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
        }

        private void btnOdustani_Click(object sender, RoutedEventArgs e)
        {
            imeInput.Text = Global.prijavljeniKupac.Ime;
            prezimeInput.Text = Global.prijavljeniKupac.Prezime;
            korisnickoImeInput.Text = Global.prijavljeniKupac.KorisnickoIme;
            emailInput.Text = Global.prijavljeniKupac.Email;
            lozinkaInput.Password = Global.Lozinka;
            lozinkaPonovoInput.Password = Global.Lozinka;


            emailInput.IsEnabled = false;
            imeInput.IsEnabled = false;
            prezimeInput.IsEnabled = false;
            korisnickoImeInput.IsEnabled = false;
            lozinkaPonovoInput.IsEnabled = false;
            lozinkaInput.IsEnabled = false;

            izmijeniSacuvajGrid.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            btnOmoguciPromjenu.Visibility = Windows.UI.Xaml.Visibility.Visible;
        }

        private async void btnSacuvaj_Click(object sender, RoutedEventArgs e)
        {
            string poruka = "";
            bool mogucaIzmjena = true;
            if (imeInput.Text == "" || prezimeInput.Text == "" || emailInput.Text == "" || korisnickoImeInput.Text == "" || lozinkaInput.Password == "" || lozinkaPonovoInput.Password == "")
            {
                poruka = "Niste popunili potrebna polja!";
                mogucaIzmjena = false;
            }

            if (lozinkaInput.Password != lozinkaPonovoInput.Password)
            {

                poruka = "Lozinke nisu iste!";
                mogucaIzmjena = false;
            }


            if (mogucaIzmjena)
            {
                Global.prijavljeniKupac.Ime = imeInput.Text;
                Global.prijavljeniKupac.Prezime = prezimeInput.Text;
                Global.prijavljeniKupac.KorisnickoIme = korisnickoImeInput.Text;
                Global.prijavljeniKupac.Email = emailInput.Text;
                Global.prijavljeniKupac.LozinkaSalt = UIHelper.GenerateSalt();
                Global.prijavljeniKupac.LozinkaHash = UIHelper.GenerateHash(lozinkaInput.Password, Global.prijavljeniKupac.LozinkaSalt);
                Global.Lozinka = lozinkaInput.Password;

                HttpResponseMessage response = korisniciService.PutActionResponse(Global.prijavljeniKupac.KupacID, Global.prijavljeniKupac);
                if (response.IsSuccessStatusCode)
                {



                    izmijeniSacuvajGrid.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                    btnOmoguciPromjenu.Visibility = Windows.UI.Xaml.Visibility.Visible;
                    emailInput.IsEnabled = false;
                    imeInput.IsEnabled = false;
                    prezimeInput.IsEnabled = false;
                    korisnickoImeInput.IsEnabled = false;
                    lozinkaPonovoInput.IsEnabled = false;
                    lozinkaInput.IsEnabled = false;

                    poruka = "Uspješno ste izmijenili podatke!";

                }

                else
                {

                    poruka = "Izmjena podataka nije uspjela. Došlo je do greške!";


                }

               

            }

            MessageDialog msg = new MessageDialog(poruka);
            await msg.ShowAsync();





        }
    }
}
