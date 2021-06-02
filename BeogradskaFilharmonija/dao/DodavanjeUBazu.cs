using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeogradskaFilharmonija.dao
{

    public class DodavanjeUBazu
    {
        public static bool DodajDvoranu(int id, string mesto, string naziv, string ulica, int broj)
        {
            dvoranaSet dvorana;
            using (var db = new BeogradskaFilharmonijaModelContainer())
            {
                try
                {
                    dvorana = db.dvoranaSet.Where(c => c.iddvor.Equals(id)).FirstOrDefault();

                    if (dvorana != null)
                    {
                        return false;
                    }
                    else
                    {
                        dvorana = new dvoranaSet();
                        dvorana.iddvor = id;
                        dvorana.mest = mesto;
                        dvorana.nazdv = naziv;
                        dvorana.ul = ulica;
                        dvorana.br = broj;

                        db.dvoranaSet.Add(dvorana);
                        db.SaveChanges();

                        return true;

                    }

                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    return false;
                }
            }
        }
        public static int DodajClanaKluba(int sfr, string jmbg, string imeClanaKluba, string prezimeClanaKluba, string korisnickoIme, string datumRodjenja, int brojacKarte)
        {
            clan_klubaSet clanKluba;
            posetilacSet posetilac;

            using (var db = new BeogradskaFilharmonijaModelContainer())
            {
                try
                {
                    clanKluba = db.clan_klubaSet.Where(c => c.sfr.Equals(sfr)).FirstOrDefault();
                    posetilac = db.posetilacSet.Where(c => c.brckar.Equals(brojacKarte)).FirstOrDefault();

                    if (clanKluba != null)
                    {
                        return 0;
                    }
                    else
                    {
                        clanKluba = new clan_klubaSet();
                        clanKluba.sfr = sfr;
                        clanKluba.jmbg = jmbg;
                        clanKluba.imeck = imeClanaKluba;
                        clanKluba.prezck = prezimeClanaKluba;

                        if (clanKluba.korime == korisnickoIme)
                        {
                            return 1;

                        }
                        else
                        {
                            clanKluba.korime = korisnickoIme;
                        }
                        clanKluba.datrodj = datumRodjenja;

                        clanKluba.posetilac_brckar_clan_kluba = brojacKarte;
                        clanKluba.posetilacSet = posetilac;

                        db.clan_klubaSet.Add(clanKluba);
                        db.SaveChanges();

                        return 2;

                    }

                }
                catch
                {
                    return 3;
                }
            }

        }

        public static bool DodajSalu(int id, int sediste, string scena, int idDvorane)
        {
            salaSet sala;
            dvoranaSet dvorana;

            using (var db = new BeogradskaFilharmonijaModelContainer())
            {
                try
                {
                    sala = db.salaSet.Where(c => c.idsal.Equals(id)).FirstOrDefault();
                    dvorana = db.dvoranaSet.Where(c => c.iddvor.Equals(idDvorane)).FirstOrDefault();

                    if (sala != null)
                    {
                        return false;
                    }
                    else
                    {
                        sala = new salaSet();
                        sala.idsal = id;
                        sala.brsed = sediste;
                        sala.velsce = scena;

                        sala.dvorana_iddvor_sala = idDvorane;
                        sala.dvoranaSet = dvorana;

                        db.salaSet.Add(sala);
                        db.SaveChanges();

                        return true;



                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);

                    return false;
                }
            }
        }

        public static bool DodajKartu(int id, int red, int brojSedista, string danIzvodjenja, string satIzvodjenja, float cena, int idSale, int idKoncerta)
        {
            kartaSet karta;
            izvodjenjeSet izvodjenje;

            using (var db = new BeogradskaFilharmonijaModelContainer())
            {
                try
                {
                    karta = db.kartaSet.Where(c => c.br.Equals(id)).FirstOrDefault();
                    izvodjenje = db.izvodjenjeSet.Where(c => c.sala_idsal_izvodjenje.Equals(idSale)).FirstOrDefault();

                    if (karta != null)
                    {
                        return false;
                    }
                    else
                    {
                        karta = new kartaSet();
                        karta.br = id;
                        karta.red = red;
                        karta.sed = brojSedista;
                        karta.daniz = danIzvodjenja;
                        karta.satiz = satIzvodjenja;
                        karta.cen = cena;

                        karta.izvodjenje_sala_idsal_karta = idSale;
                        karta.izvodjenje_koncert_idkon_karta = idKoncerta;
                        karta.izvodjenjeSet = izvodjenje;

                        db.kartaSet.Add(karta);
                        db.SaveChanges();

                        return true;


                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    return false;
                }
            }
        }

        public static int DodajPosetioca(int brojac, List<int> idKarte)
        {
            if (idKarte.Count == 0)
            {
                return 0;
            }

            posetilacSet posetilac;

            using (var db = new BeogradskaFilharmonijaModelContainer())
            {
                try
                {
                    posetilac = db.posetilacSet.Where(c => c.brckar.Equals(brojac)).FirstOrDefault();

                    if (posetilac != null)
                    {
                        return 1;
                    }
                    else
                    {
                        posetilac = new posetilacSet();
                        posetilac.brckar = brojac;

                        foreach (var item in idKarte)
                        {
                            kartaSet karta = new kartaSet();
                            karta = db.kartaSet.Where(c => c.br.Equals(item)).FirstOrDefault();
                            db.kartaSet.Add(karta);
                            db.posetilacSet.Add(posetilac);

                        }
                        db.SaveChanges();
                        return 2;
                    }
                }
                catch
                {
                    return 3;
                }
            }

        }

        public static int DodajKoncert(int id, int trajanje, string naziv, string zanr, List<int> idSale, List<int> idOrkestra, List<int> idSef_dirigent)
        {
            if (idSale.Count == 0)
            {
                return 0;
            }
            if (idOrkestra.Count == 0)
            {
                return 1;
            }
            if (idSef_dirigent.Count == 0)
            {
                return 2;
            }

            koncertSet koncert;

            using (var db = new BeogradskaFilharmonijaModelContainer())
            {
                try
                {
                    koncert = db.koncertSet.Where(c => c.idkon.Equals(id)).FirstOrDefault();

                    if (koncert != null)
                    {
                        return 3;
                    }
                    else
                    {
                        koncert = new koncertSet();
                        koncert.idkon = id;
                        koncert.traj = trajanje;
                        koncert.nazkon = naziv;
                        koncert.znrmuzik = zanr;

                        foreach (var item in idSale)
                        {
                            salaSet sala = new salaSet();
                            sala = db.salaSet.Where(c => c.idsal.Equals(item)).FirstOrDefault();

                            izvodjenjeSet izvodjenje = new izvodjenjeSet();
                            izvodjenje.sala_idsal_izvodjenje = item;
                            izvodjenje.salaSet = sala;
                            izvodjenje.sala_dvorana_iddvor_izvodjenje = sala.dvorana_iddvor_sala;
                            izvodjenje.koncert_idkon_izvodjenje = id;
                            izvodjenje.koncertSet = koncert;

                            db.izvodjenjeSet.Add(izvodjenje);
                            db.izvodjenjeSet.Add(izvodjenje);

                            db.izvodjenjeSet.Add(izvodjenje);
                            db.SaveChanges();
                        }

                        foreach (var item in idOrkestra)
                        {
                            orkestarSet glumac = new orkestarSet();
                            glumac = db.orkestarSet.Where(c => c.id.Equals(item)).FirstOrDefault();
                            db.orkestarSet.Add(glumac);

                        }
                        foreach (var item in idSef_dirigent)
                        {
                            sef_dirigentSet sef_Dirigent = new sef_dirigentSet();
                            sef_Dirigent = db.sef_dirigentSet.Where(c => c.iddir.Equals(item)).FirstOrDefault();
                            db.sef_dirigentSet.Add(sef_Dirigent);
                        }

                        return 5;
                    }

                }
                catch
                {
                    return 4;
                }
            }

        }
        public static bool DodajOrkestar(int id, string ime,Int32 brclan)
        {
            orkestarSet orkestar;

            using (var db = new BeogradskaFilharmonijaModelContainer())
            {
                try
                {
                    orkestar = db.orkestarSet.Where(c => c.id.Equals(id)).FirstOrDefault();

                    if (orkestar != null)
                    {
                        return false;
                    }
                    else
                    {
                        orkestar = new orkestarSet();
                        orkestar.id = id;
                        orkestar.imeork = ime;
                        orkestar.brclan = brclan;

                        db.orkestarSet.Add(orkestar);
                        db.SaveChanges();

                        return true;
                    }
                }
                catch
                {
                    return false;
                }
            }

        }

        public static bool DodajSefa_dirigenta(int id, string ime, string prezime)
        {
            sef_dirigentSet sef_dirigent;

            using (var db = new BeogradskaFilharmonijaModelContainer())
            {
                try
                {
                    sef_dirigent = db.sef_dirigentSet.Where(c => c.iddir.Equals(id)).FirstOrDefault();

                    if (sef_dirigent != null)
                    {
                        return false;
                    }
                    else
                    {
                        sef_dirigent = new sef_dirigentSet();
                        sef_dirigent.iddir = id;
                        sef_dirigent.imed = ime;
                        sef_dirigent.prezdir = prezime;

                        db.sef_dirigentSet.Add(sef_dirigent);
                        db.SaveChanges();

                        return true;
                    }
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
