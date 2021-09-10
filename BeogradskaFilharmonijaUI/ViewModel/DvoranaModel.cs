using BeogradskaFilharmonija;
using BeogradskaFilharmonija.dao;
using BeogradskaFilharmonijaUI.Command;
using BeogradskaFilharmonijaUI.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeogradskaFilharmonijaUI.ViewModel
{
    public class DvoranaModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, e);
            }
        }

        private List<dvoranaSet> lista;
        private dvoranaSet izabrani;
        private bool dostupnost;

        public DodajDvoranu Dodaj { get; set; }
        public ObrisiDvoranu Obrisi { get; set; }
        public IzmeniDvoranu Izmeni { get; set; }


        public DvoranaModel(DvoranaView viewParam)
        {
            this.Dodaj = new DodajDvoranu(this, viewParam);
            this.Obrisi = new ObrisiDvoranu(this, viewParam);
            this.Izmeni = new IzmeniDvoranu(this, viewParam);

            Lista = CitanjeIzBaze.VratiDvorana();

        }

        public List<dvoranaSet> Lista
        {
            get { return lista; }
            set
            {
                lista = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Lista"));
            }
        }

        public dvoranaSet Izabrani
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
            if (GlobalnaKorisnickaKlasa.korisnik.Uloga == "Admin")
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
