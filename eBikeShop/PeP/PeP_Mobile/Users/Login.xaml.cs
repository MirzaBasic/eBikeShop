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
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace PeP_Mobile.Users
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Login : Page
    {

        WebApiHelper korisniciService = new WebApiHelper("http://localhost:30455/", "api/Kupci");
        public Login()
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
            if (Global.prijavljeniKupac != null) {

                korisnickoImeInput.Text = Global.prijavljeniKupac.KorisnickoIme;
                lozinkaInput.Password = Global.Lozinka;
 

                btnLogin_Click(null,null);
            }


        }

        private async void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            HttpResponseMessage response = korisniciService.GetActionResponse("GetUserByUsername", korisnickoImeInput.Text.Trim());
            if (response.IsSuccessStatusCode)
            {

                Kupci k = response.Content.ReadAsAsync<Kupci>().Result;

                string hash = UIHelper.GenerateHash(lozinkaInput.Password, k.LozinkaSalt);
                if (hash == k.LozinkaHash)
                {

                    Global.prijavljeniKupac = k;
                    Global.Lozinka = lozinkaInput.Password;
                    MessageDialog dialog = new MessageDialog("Welcome " + k.Ime + " " + k.Prezime);
                    await dialog.ShowAsync();
                    Frame.Navigate(typeof(MainPage));

                }
                else
                {

                    MessageDialog dialog = new MessageDialog("Wrong password");
                    await dialog.ShowAsync();

                }


            }
            else
            {

                MessageDialog dialog = new MessageDialog("Wrong username");
                await dialog.ShowAsync();
            }
            }

        private  void btnRegistracija_Click(object sender, RoutedEventArgs e)


        {
            
            Frame.Navigate(typeof(Users.Registracija));



        }
    }
}
