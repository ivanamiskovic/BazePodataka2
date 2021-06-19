using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BeogradskaFilharmonija.dao
{
    public class PomocnaKlasa
    {

        public static List<int> IDListBox(ListBox lista)
        {
            List<int> povratna = new List<int>();

            foreach (var item in lista.Items)
            {
                CheckBox cb = (CheckBox)item;

                if (cb.IsChecked == true)
                {
                    string natpis = cb.Content.ToString();
                    string[] reci = natpis.Split(' ');
                    int id = Convert.ToInt32(reci[0]);

                    povratna.Add(id);
                }
            }
            return povratna;
        }

        public static List<kartaSet> SlobodneKarte(List<int> zauzeteKarte)
        {
            List<kartaSet> karte = CitanjeIzBaze.VratiKarte();
            List<kartaSet> povratna = new List<kartaSet>();

            foreach (var item in karte)
            {
                if (!zauzeteKarte.Contains((int)item.br))
                {
                    povratna.Add(item);
                }
            }
            return povratna;
        }

        public static List<string> ListBoxIzvodjenjaKoncerta(decimal id)
        {
            List<string> povratna = new List<string>();

            using (var db = new BeogradskaFilharmonijaModelContainer())
            {
                try
                {
                    foreach (var item in db.izvodjenjeSet)
                    {
                        if (item.koncert_idkon_izvodjenje == id)
                        {
                            povratna.Add("ID: " + item.sala_idsal_izvodjenje.ToString() + " , ID dvorane: " + item.sala_dvorana_iddvor_izvodjenje);

                        }
                    }
                }
                catch
                {

                }
            }
            return povratna;

        }

        //izmena orkestara 
        public static List<string> ListBoxOrkestaraNaKoncertu(decimal id)
        {
            List<string> povratna = new List<string>();

            using (var db = new BeogradskaFilharmonijaModelContainer())
            {
                try
                {
                    koncertSet koncert = db.koncertSet.Where(c => c.idkon.Equals(id)).FirstOrDefault();

                    foreach (var item in koncert.orkestarSet)
                    {
                        povratna.Add("ID: " + item.id.ToString() + " , " + item.imeork + " " + item.brclan.ToString());
                    }
                }
                catch
                {

                }
            }

            return povratna;
        }

        public static List<string> ListBoxSef_dirigentNaKoncertu(decimal id)
        {
            List<string> povratna = new List<string>();

            using (var db = new BeogradskaFilharmonijaModelContainer())
            {
                try
                {
                    koncertSet koncert = db.koncertSet.Where(c => c.idkon  ==  id).FirstOrDefault();

                    foreach (var item in koncert.sef_dirigentSet)
                    {
                        povratna.Add("ID: " + item.iddir.ToString() + " , " + item.imed + " " + item.prezdir);
                    }
                }
                catch
                {

                }
            }

            return povratna;
        }
    }
}
