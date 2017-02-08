using PeP_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace PeP_UI
{
    public class Global
    {

        public static Korisnici prijavljeniKorisnici { get; set; }
        public static string GetMessage(string key)
        {

            ResourceManager rm = new ResourceManager("PeP_UI.Messages", Assembly.GetExecutingAssembly());
            return rm.GetString(key);
        }
    }
}
