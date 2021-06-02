using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeogradskaFilharmonija.dao
{
    public class BrisanjeIzBaze
    {
        public static int ObrisiDvoranu(decimal id)
        {
            dvoranaSet dvorana;

            using (var db = new BeogradskaFilharmonijaModelContainer())
            {
                dvorana = db.dvoranaSet.Where(c => c.iddvor.Equals(id)).FirstOrDefault();

                if (dvorana.salaSet.Count > 0)
                    return 0;

                try
                {
                    db.Entry(dvorana).State = System.Data.Entity.EntityState.Deleted;
                    //db.Procedure1(id);
                    db.SaveChanges();

                    return 1;
                }
                catch
                {
                    return 2;
                }
            }
        }

        public static int ObrisiClanKluba(decimal sfr)
        {
            clan_klubaSet clanKluba;

            using (var db = new BeogradskaFilharmonijaModelContainer())
            {
                clanKluba = db.clan_klubaSet.Where(c => c.sfr.Equals(sfr)).FirstOrDefault();

                try
                {
                    db.Entry(clanKluba).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();

                    return 1;
                }
                catch
                {
                    return 2;
                }
            }
        }
        public static int ObrisiSalu(decimal id)
        {
            salaSet sala;
            izvodjenjeSet izvodjenje;

            using (var db = new BeogradskaFilharmonijaModelContainer())
            {
                sala = db.salaSet.Where(c => c.idsal.Equals(id)).FirstOrDefault();
                izvodjenje = db.izvodjenjeSet.Where(c => c.sala_idsal_izvodjenje.Equals(id)).FirstOrDefault();

                if (izvodjenje != null)
                    return 0;

                try
                {
                    db.Entry(sala).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();

                    return 1;
                }
                catch
                {
                    return 2;
                }
            }
        }

        public static int ObrisiKartu(decimal id)
        {
            kartaSet karta;
            posetilacSet posetilac;

            using (var db = new BeogradskaFilharmonijaModelContainer())
            {
                karta = db.kartaSet.Where(c => c.br==id).FirstOrDefault();
                posetilac = db.posetilacSet.Where(c => c.brckar==id).FirstOrDefault();

                if (posetilac != null)
                    return 0;

                try
                {
                    db.Entry(karta).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();

                    return 1;
                }
                catch
                {
                    return 2;
                }
            }
        }

        public static int ObrisiPosetioca(decimal brojac)
        {
            posetilacSet posetilac;
            clan_klubaSet clanKluba;

            using (var db = new BeogradskaFilharmonijaModelContainer())
            {
                posetilac = db.posetilacSet.Where(c => c.brckar.Equals(brojac)).FirstOrDefault();
                clanKluba = db.clan_klubaSet.Where(c => c.posetilac_brckar_clan_kluba.Equals(brojac)).FirstOrDefault();

                try
                {
                    if (clanKluba != null)
                    {
                        db.Entry(clanKluba).State = System.Data.Entity.EntityState.Deleted;

                    }

                    posetilac.kartaSet.Clear();
                    db.Entry(posetilac).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();

                    return 1;
                }
                catch
                {
                    return 2;
                }
            }
        }

        public static int ObrisiKoncert(decimal id)
        {
            koncertSet koncert;
            List<izvodjenjeSet> izvodjenja = CitanjeIzBaze.VratiIzvodjenje();

            using (var db = new BeogradskaFilharmonijaModelContainer())
            {
                koncert = db.koncertSet.Where(c => c.idkon.Equals(id)).FirstOrDefault();

                try
                {
                    koncert.orkestarSet.Clear();
                    koncert.sef_dirigentSet.Clear();

                    foreach (var item in db.izvodjenjeSet)
                    {
                        if (item.koncert_idkon_izvodjenje == id)
                        {
                            db.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                        }
                    }
                    db.Entry(koncert).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();

                    return 1;
                }
                catch
                {
                    return 2;
                }
            }
        }

        public static int ObrisiOrkestar(decimal id)
        {
            orkestarSet orkestar;

            using (var db = new BeogradskaFilharmonijaModelContainer())
            {
                orkestar = db.orkestarSet.Where(c => c.id.Equals(id)).FirstOrDefault();

                if (orkestar.koncertSet.Count > 0)
                {
                    return 0;
                }

                try
                {
                    db.Entry(orkestar).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();

                    return 1;
                }
                catch
                {
                    return 2;
                }
            }
        }

        public static int ObrisiSefa_dirigenta(decimal id)
        {
            sef_dirigentSet sef_dirigent;

            using (var db = new BeogradskaFilharmonijaModelContainer())
            {
                sef_dirigent = db.sef_dirigentSet.Where(c => c.iddir.Equals(id)).FirstOrDefault();

                if (sef_dirigent.koncertSet.Count > 0)
                {
                    return 0;
                }

                try
                {
                    db.Entry(sef_dirigent).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();

                    return 1;
                }
                catch
                {
                    return 2;
                }
            }
        }


    }
}
