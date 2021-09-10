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

    class OrkestarModel : INotifyPropertyChanged
    {
        private List<orkestarSet> lista;
        private orkestarSet izabrani;
        private bool dostupnost;

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, e);
            }
        }

        public DodajOrkestar Dodaj { get; set; }
        public ObrisiOrkestar Obrisi { get; set; }
        public IzmeniOrkestar Izmeni { get; set; }

        public OrkestarModel(OrkestarView viewParam)
        {
            this.Dodaj = new DodajOrkestar(this, viewParam);
            this.Obrisi = new ObrisiOrkestar(this, viewParam);
            this.Izmeni = new IzmeniOrkestar(this, viewParam);

            Lista = CitanjeIzBaze.VratiOrkestre();
        }

        public orkestarSet Izabrani
        {
            get { return izabrani; }
            set
            {
                izabrani = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Izabrani"));
            }
        }

        public List<orkestarSet> Lista
        {
            get { return lista; }
            set
            {
                lista = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Lista"));
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
