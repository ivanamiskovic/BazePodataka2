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
    //TODO IZMENJENO
    public class KartaModel : INotifyPropertyChanged
    {
        private List<kartaSet> lista;
        private kartaSet izabrani;
        private bool dostupnost;
        private string filterTip;

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, e);
            }
        }

        public DodajKartu Dodaj { get; set; }
        public ObrisiKartu Obrisi { get; set; }
        public IzmeniKartu Izmeni { get; set; }
        public FiltrirajKartu Filtriraj { get; set; }
        public PrebaciUFajlKartu PrebaciUFajl { get; set; }

        public KartaModel(KartaView viewParam)
        {
            this.Dodaj = new DodajKartu(this, viewParam);
            this.Obrisi = new ObrisiKartu(this, viewParam);
            this.Izmeni = new IzmeniKartu(this, viewParam);
            this.Filtriraj = new FiltrirajKartu(this, viewParam);
            this.PrebaciUFajl = new PrebaciUFajlKartu(this, viewParam);

            lista = CitanjeIzBaze.VratiKarte();
        }

        public kartaSet Izabrani
        {
            get { return izabrani; }
            set
            {
                izabrani = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Izabrani"));
            }
        }

        public List<kartaSet> Lista
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

        public string FilterTip
        {
            get { return filterTip; }
            set
            {
                filterTip = value;
                OnPropertyChanged(new PropertyChangedEventArgs("FilterTip"));
            }
        }

        private void ProveriKorisnika()
        {
            if (GlobalnaKorisnickaKlasa.korisnik.Uloga == "Dispecer")
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
