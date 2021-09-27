using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeogradskaFilharmonija.dao
{
    public class AzuriranjeUBazi
    {
        public static bool AzurirajDvoranu(int id, string mesto, string naziv, string ulica, int broj)
        {
            dvoranaSet dvorana;

            using (var db = new BeogradskaFilharmonijaModelEntities())
            {
                dvorana = db.dvoranaSet.Where(c => c.iddvor.Equals(id)).FirstOrDefault();

                try
                {
                    dvorana.mest = mesto;
                    dvorana.nazdv = naziv;
                    dvorana.ul = ulica;
                    dvorana.br = broj;

                    db.Entry(dvorana).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public static bool AzurirajSalu(int id, int sediste, string scena, int idSale)
        {
            salaSet sala;
            dvoranaSet dvorana;

            using (var db = new BeogradskaFilharmonijaModelEntities())
            {
                sala = db.salaSet.Where(c => c.idsal.Equals(id)).FirstOrDefault();
                dvorana = db.dvoranaSet.Where(c => c.iddvor.Equals(id)).FirstOrDefault();

                try
                {
                    sala.brsed = sediste;
                    sala.velsce = scena;

                    db.Entry(sala).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    return true;
                }
                catch
                {
                    return false;
                }

            }
        }

        public static bool AzurirajKartu(int id, int red, int brojSedista, string danIzvodjenja, string satIzvodjenja, float cena, int idSale, int idKoncerta)
        {
            kartaSet karta;
            izvodjenjeSet izvodjenje;

            using (var db = new BeogradskaFilharmonijaModelEntities())
            {
                karta = db.kartaSet.Where(c => c.br.Equals(id)).FirstOrDefault();
                izvodjenje = db.izvodjenjeSet.Where(c => c.sala_idsal_izvodjenje.Equals(idSale)).FirstOrDefault();

                try
                {
                    karta.red = red;
                    karta.sed = brojSedista;
                    karta.cen = cena;
                    karta.daniz = danIzvodjenja;
                    karta.satiz = satIzvodjenja;

                    db.Entry(karta).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public static int AzurirajKoncert(int id, int trajanje, string naziv, string zanr, List<int> idSala, List<int> idOrkestar, List<int> idSef_dirigent)
        {
            koncertSet koncert;

            if (idSala.Count == 0)
            {
                return 0;
            }
            if (idOrkestar.Count == 0)
            {
                return 1;
            }
            if (idSef_dirigent.Count == 0)
            {
                return 2;
            }

            using (var db = new BeogradskaFilharmonijaModelEntities())
            {
                koncert = db.koncertSet.Where(c => c.idkon.Equals(id)).FirstOrDefault();

                try
                {
                    koncert.traj = trajanje;
                    koncert.nazkon = naziv;
                    koncert.znrmuzik = zanr;

                    koncert.orkestarSet.Clear();

                    foreach (var item in idOrkestar)
                    {
                        orkestarSet orkestar;
                        orkestar = db.orkestarSet.Where(c => c.id.Equals(item)).FirstOrDefault();
                        db.orkestarSet.Add(orkestar);
                    }
                    koncert.sef_dirigentSet.Clear();

                    foreach (var item in idSef_dirigent)
                    {
                        sef_dirigentSet sef_dirigent;
                        sef_dirigent = db.sef_dirigentSet.Where(c => c.iddir.Equals(item)).FirstOrDefault();
                        koncert.sef_dirigentSet.Add(sef_dirigent);
                    }
                    db.Entry(koncert).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    return 5;
                }
                catch
                {
                    return 4;
                }
            }
        }

        public static bool AzurirajOrkestar(int id, string ime, Int32 brclan)
        {
            orkestarSet orkestar;
            using (var db = new BeogradskaFilharmonijaModelEntities())
            {
                orkestar = db.orkestarSet.Where(c => c.id.Equals(id)).FirstOrDefault();

                try
                {
                    orkestar.imeork = ime;
                    orkestar.brclan = brclan;

                    db.Entry(orkestar).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();


                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public static bool AzurirajSefa_dirigenta(int id, string ime, string prezime)
        {
            sef_dirigentSet sef_dirigent;

            using (var db = new BeogradskaFilharmonijaModelEntities())
            {
                sef_dirigent = db.sef_dirigentSet.Where(c => c.iddir.Equals(id)).FirstOrDefault();

                try
                {
                    sef_dirigent.imed = ime;
                    sef_dirigent.prezdir = prezime;

                    db.Entry(sef_dirigent).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    return true;
                }
                catch
                {
                    return false;
                }
            }

        }
        public static int AzurirajClanKluba(int sfr, string jmbg, string imeck, string przck, string korime, string datrodj)
        {
            clan_klubaSet clan_Kluba;


            using (var db = new BeogradskaFilharmonijaModelEntities())
            {
                clan_Kluba = db.clan_klubaSet.Where(c => c.sfr.Equals(sfr)).FirstOrDefault();

                try
                {
                    clan_Kluba.jmbg = jmbg;
                    clan_Kluba.imeck = imeck;
                    clan_Kluba.prezck = przck;
                   
                    clan_Kluba.datrodj = datrodj;

                    db.Entry(clan_Kluba).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return 0;
                }
                catch
                {
                    return 2;
                }
            }
        }
    }
}
