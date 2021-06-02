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
    public class KartaModel : INotifyPropertyChanged
    {
        private List<kartaSet> lista;
        private kartaSet izabrani;

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

        public KartaModel(KartaView viewParam)
        {
            this.Dodaj = new DodajKartu(this, viewParam);
            this.Obrisi = new ObrisiKartu(this, viewParam);
            this.Izmeni = new IzmeniKartu(this, viewParam);

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
    }
}
