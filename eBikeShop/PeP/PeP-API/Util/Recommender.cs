using PeP_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeP_API.Util
{
    public class Recommender
    {
        eProdajaEntities db = new eProdajaEntities();
        Dictionary<int, List<Ocjene>> proizvodi = new Dictionary<int, List<Ocjene>>();
        public List<ProizvodiByID_Result> GetSlicneProizvode(int proizvodID) {


            UcitajProizvode(proizvodID);
            List<Ocjene> ocjenePosmatranogProizvoda = db.Ocjenes.Where(x => x.ProizvodID == proizvodID).OrderBy(x=>x.KupacID).ToList();
            List<Ocjene> zajednickeOcjene1 = new List<Ocjene>();
            List<Ocjene> zajednickeOcjene2 = new List<Ocjene>();
            List<ProizvodiByID_Result> preporuceniProizvodi = new List<ProizvodiByID_Result>();


            foreach (var item in proizvodi)
            {
                foreach (Ocjene o in ocjenePosmatranogProizvoda)
                {
                    if (item.Value.Where(x => x.KupacID == o.KupacID).Count() > 0) {
                        zajednickeOcjene1.Add(o);
                        zajednickeOcjene2.Add((item.Value.Where(x => x.KupacID == o.KupacID).First()));
                    }

                }

                double slicnost = GetSlicnost(zajednickeOcjene1, zajednickeOcjene2);

                if (slicnost > 0.5)
                     preporuceniProizvodi.Add(db.esp_Proizvodi_SelectById(item.Key).FirstOrDefault());
                
                zajednickeOcjene1.Clear();
                zajednickeOcjene2.Clear();
            }

            return preporuceniProizvodi;
        }

        private double GetSlicnost(List<Ocjene> zajednickeOcjene1, List<Ocjene> zajednickeOcjene2)
        {
            if (zajednickeOcjene1.Count() != zajednickeOcjene2.Count())
                return 0;

            double brojnik = 0, nazivnik1 = 0, nazivnik2 = 0;



            for (int i = 0; i < zajednickeOcjene1.Count(); i++)
            {
                brojnik = zajednickeOcjene1[i].Ocjena * zajednickeOcjene2[i].Ocjena;

                nazivnik1 = zajednickeOcjene1[i].Ocjena * zajednickeOcjene1[i].Ocjena;
                nazivnik2 = zajednickeOcjene2[i].Ocjena * zajednickeOcjene2[i].Ocjena;
            }
            nazivnik1 = Math.Sqrt(nazivnik1);
            nazivnik2 = Math.Sqrt(nazivnik2);

            double nazivnik = nazivnik1 * nazivnik2;
            if (nazivnik == 0)
                return 0;
            return brojnik / nazivnik;
        }

        private void UcitajProizvode(int proizvodID)
        {
            List<Proizvodi> aktivniProizvodi = db.Proizvodis.Where(x => x.ProizvodID != proizvodID && x.Status == true).ToList();
            List<Ocjene> ocjene;
            foreach (Proizvodi p in aktivniProizvodi)
            {
                ocjene = db.Ocjenes.Where(x => x.ProizvodID == p.ProizvodID).OrderBy(x => x.KupacID).ToList();
                if (ocjene.Count > 0)
                {
                    proizvodi.Add(p.ProizvodID, ocjene);
                }
            }
        }
    }
}