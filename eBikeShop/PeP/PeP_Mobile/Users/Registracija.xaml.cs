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
using PeP_PCL.Util;
using PeP_PCL.Models;
using System.Net.Http;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace PeP_Mobile.Users
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Registracija : Page
    {

        WebApiHelper korisniciService =new WebApiHelper("http://localhost:30455/", "api/Kupci");
        public Registracija()
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
        }

        private async void btnSignup_Click(object sender, RoutedEventArgs e)
        {


            string poruka = "";
            bool mogucaIzmjena = true;
            if (imeInput.Text == "" || prezimeInput.Text == "" || emailInput.Text == "" || korisnickoImeInput.Text == "" || lozinkaInput.Password == "" || lozinkaPonovoInput.Password == "")
            {
                poruka = "Niste popunili potrebna polja!";
                mogucaIzmjena = false;
                MessageDialog dialog = new MessageDialog(poruka);
                await dialog.ShowAsync();
            }

            if (lozinkaInput.Password != lozinkaPonovoInput.Password)
            {

                poruka = "Lozinke nisu iste!";
                mogucaIzmjena = false;
                MessageDialog dialog = new MessageDialog(poruka);
                await dialog.ShowAsync();
            }


            if (mogucaIzmjena)
            {





                Kupci k = new Kupci();
                k.KorisnickoIme = korisnickoImeInput.Text;
                k.Ime = imeInput.Text;
                k.Prezime = prezimeInput.Text;
                k.Email = emailInput.Text;
                k.Status = true;
                k.DatumRegistracije = DateTime.Now;
                k.LozinkaSalt = UIHelper.GenerateSalt();
                k.LozinkaHash = UIHelper.GenerateHash(lozinkaInput.Password, k.LozinkaSalt);


                HttpResponseMessage response = korisniciService.PostResponse(k);
                if (response.IsSuccessStatusCode)
                {
                    Global.prijavljeniKupac = k;
                    Global.Lozinka = lozinkaInput.Password;
                    MessageDialog dialog = new MessageDialog("Registration successfull!");
                    await dialog.ShowAsync();

                    Frame.Navigate(typeof(Users.Login));

                }
                else
                {
                    MessageDialog dialog = new MessageDialog("Error: " + response.ReasonPhrase);
                    await dialog.ShowAsync();



                }
            }
        }
    }
}
