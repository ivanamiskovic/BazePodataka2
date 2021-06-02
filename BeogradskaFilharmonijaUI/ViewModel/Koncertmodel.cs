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
    class KoncertModel : INotifyPropertyChanged
    {
        private List<koncertSet> lista;
        private koncertSet izabrani;

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, e);
            }
        }

        public DodajKoncert Dodaj { get; set; }
        public ObrisiKoncert Obrisi { get; set; }
        public IzmeniKoncert Izmeni { get; set; }

        public KoncertModel(KoncertView viewParam)
        {
            this.Dodaj = new DodajKoncert(this, viewParam);
            this.Obrisi = new ObrisiKoncert(this, viewParam);
            this.Izmeni = new IzmeniKoncert(this, viewParam);

            Lista = CitanjeIzBaze.VratiKoncerte();
        }

        public koncertSet Izabrani
        {
            get { return izabrani; }
            set
            {
                izabrani = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Izabrani"));
            }
        }

        public List<koncertSet> Lista
        {
            get { return lista; }
            set
            {
                lista = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Lista"));
            }
        }
    }
}
