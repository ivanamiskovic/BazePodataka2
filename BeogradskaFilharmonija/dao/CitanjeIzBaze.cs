using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeogradskaFilharmonija.dao
{
    public class CitanjeIzBaze
    {
        public static List<dvoranaSet> VratiDvorana()
        {
            List<dvoranaSet> lista = new List<dvoranaSet>();

            using (var db = new BeogradskaFilharmonijaModelContainer())
            {
                try
                {
                    foreach (var item in db.dvoranaSet)
                    {
                        lista.Add(item);
                    }
                }
                catch
                {

                }
            }

            return lista;
        }

        public static List<salaSet> VratiSale()
        {
            List<salaSet> lista = new List<salaSet>();

            using (var db = new BeogradskaFilharmonijaModelContainer())
            {
                try
                {
                    foreach (var item in db.salaSet)
                    {
                        lista.Add(item);
                    }

                }
                catch
                {

                }
            }
            return lista;
        }

        public static List<kartaSet> VratiKarte()
        {
            List<kartaSet> lista = new List<kartaSet>();

            using (var db = new BeogradskaFilharmonijaModelContainer())
            {
                try
                {
                    foreach (var item in db.kartaSet)
                    {
                        lista.Add(item);
                    }
                }
                catch
                {

                }
            }

            return lista;
        }

        public static List<kartaSet> VratiSlobodneKarte()
        {
            List<kartaSet> lista = new List<kartaSet>();

            using (var db = new BeogradskaFilharmonijaModelContainer())
            {
                try
                {
                    foreach (var item in db.kartaSet)
                    {
                        if (item.posetilac_brckar_karta == null)
                        {
                            lista.Add(item);
                        }
                    }
                }
                catch
                {

                }
            }
            return lista;
        }

        public static List<koncertSet> VratiKoncerte()
        {
            List<koncertSet> lista = new List<koncertSet>();

            using (var db = new BeogradskaFilharmonijaModelContainer())
            {
                try
                {
                    foreach (var item in db.koncertSet)
                    {
                        lista.Add(item);
                    }
                }
                catch
                {

                }
            }
            return lista;

        }
        public static List<orkestarSet> VratiOrkestre()
        {
            List<orkestarSet> lista = new List<orkestarSet>();

            using (var db = new BeogradskaFilharmonijaModelContainer())
            {
                try
                {
                    foreach (var item in db.orkestarSet)
                    {
                        lista.Add(item);
                    }
                }
                catch
                {

                }
            }
            return lista;
        }

        public static List<sef_dirigentSet> Vratisefadirigenta()
        {
            List<sef_dirigentSet> lista = new List<sef_dirigentSet>();

            using (var db = new BeogradskaFilharmonijaModelContainer())
            {
                try
                {
                    foreach (var item in db.sef_dirigentSet)
                    {
                        lista.Add(item);
                    }
                }
                catch
                {

                }
            }

            return lista;
        }
        public static List<izvodjenjeSet> VratiIzvodjenje()
        {
            List<izvodjenjeSet> lista = new List<izvodjenjeSet>();

            using (var db = new BeogradskaFilharmonijaModelContainer())
            {
                try
                {
                    foreach (var item in db.izvodjenjeSet)
                    {
                        lista.Add(item);
                    }
                }
                catch
                {

                }
            }

            return lista;
        }

        public static List<posetilacSet> VratiPosetioce()
        {
            List<posetilacSet> lista = new List<posetilacSet>();

            using (var db = new BeogradskaFilharmonijaModelContainer())
            {
                try
                {
                    foreach (var item in db.posetilacSet)
                    {
                        lista.Add(item);
                    }
                }
                catch
                {

                }
            }

            return lista;
        }

        public static List<clan_klubaSet> VratiClanKluba()
        {
            List<clan_klubaSet> lista = new List<clan_klubaSet>();

            using (var db = new BeogradskaFilharmonijaModelContainer())
            {
                try
                {
                    foreach (var item in db.clan_klubaSet)
                    {
                        lista.Add(item);
                    }
                }
                catch
                {

                }
            }

            return lista;
        }

        public static List<Korisnik> VratiKorisnike()
        {
            List<Korisnik> lista = new List<Korisnik>();

            using (var db = new BeogradskaFilharmonijaModelContainer())
            {
                try
                {
                    foreach (var item in db.Korisnik)
                    {
                        lista.Add(item);
                    }
                }
                catch
                {

                }
            }

            return lista;
        }
    }
}
