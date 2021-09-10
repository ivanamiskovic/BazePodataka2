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
    public class Sef_dirigentModel : INotifyPropertyChanged
    {
        private List<sef_dirigentSet> lista;
        private sef_dirigentSet izabrani;
        private bool dostupnost;

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, e);
            }
        }

        public DodajSefa_dirigenta Dodaj { get; set; }
        public ObrisiSefa_dirigenta Obrisi { get; set; }
        public IzmeniSefa_dirigenta Izmeni { get; set; }

        public Sef_dirigentModel(Sef_dirigentView viewParam)
        {
            this.Dodaj = new DodajSefa_dirigenta(this, viewParam);
            this.Obrisi = new ObrisiSefa_dirigenta(this, viewParam);
            this.Izmeni = new IzmeniSefa_dirigenta(this, viewParam);

            Lista = CitanjeIzBaze.Vratisefadirigenta();
        }

        public sef_dirigentSet Izabrani
        {
            get { return izabrani; }
            set
            {
                izabrani = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Izabrani"));
            }
        }

        public List<sef_dirigentSet> Lista
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
