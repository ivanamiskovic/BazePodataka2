using BeogradskaFilharmonijaUI.View;
using BeogradskaFilharmonija;
using BeogradskaFilharmonija.dao;
using BeogradskaFilharmonijaUI.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeogradskaFilharmonijaUI.ViewModel
{
    class SalaModel : INotifyPropertyChanged
    {
        private List<salaSet> lista;
        private salaSet izabrani;

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, e);
            }
        }

        public DodajSalu Dodaj { get; set; }
        public ObrisiSalu Obrisi { get; set; }
        public IzmeniSalu Izmeni { get; set; }

        public SalaModel(SalaView viewParam)
        {
            this.Dodaj = new DodajSalu(this, viewParam);
            this.Obrisi = new ObrisiSalu(this, viewParam);
            this.Izmeni = new IzmeniSalu(this, viewParam);

            Lista = CitanjeIzBaze.VratiSale();
        }

        public salaSet Izabrani
        {
            get { return izabrani; }
            set
            {
                izabrani = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Izabrani"));
            }
        }

        public List<salaSet> Lista
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