using BeogradskaFilharmonijaUI.Command;
using BeogradskaFilharmonijaUI.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeogradskaFilharmonija;
using BeogradskaFilharmonija.dao;

namespace BeogradskaFilharmonijaUI.ViewModel
{
    public class ClanKlubaModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, e);
            }
        }

        private List<clan_klubaSet> lista;
        private clan_klubaSet izabrani;
        private bool dostupnost;

        public DodajClanKluba Dodaj { get; set; }
        public ObrisiClanKluba Obrisi { get; set; }
        public IzmeniClanKluba Izmeni { get; set; }

        public ClanKlubaModel(ClanKlubaView viewParam)
        {
            this.Dodaj = new DodajClanKluba(this, viewParam);
            this.Obrisi = new ObrisiClanKluba(this, viewParam);
            this.Izmeni = new IzmeniClanKluba(this, viewParam);

            Lista = CitanjeIzBaze.VratiClanKluba();
        }

        public List<clan_klubaSet> Lista
        {
            get { return lista; }
            set
            {
                lista = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Lista"));
            }
        }

        public clan_klubaSet Izabrani
        {
            get { return izabrani; }
            set
            {
                izabrani = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Izabrani"));
            }
        }

        public bool Dostupnost
        {
            get
            {
                ProveriKorisnika();
                return dostupnost;
            }
            set
            {
                dostupnost = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Dostupnost"));
            }
        }

        private void ProveriKorisnika()
        {
            if (GlobalnaKorisnickaKlasa.korisnik.Uloga == "Kupac")
            {
                dostupnost = true;
            }
            else
            {
                dostupnost = false;
            }
        }
    }
}