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

    class PosetilacModel : INotifyPropertyChanged
    {
        private List<posetilacSet> lista;
        private posetilacSet izabrani;

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, e);
            }
        }

        public DodajPosetioca Dodaj { get; set; }
        public ObrisiPosetioca Obrisi { get; set; }

        public PosetilacModel(PosetilacView viewParam)
        {
            this.Dodaj = new DodajPosetioca(this, viewParam);
            this.Obrisi = new ObrisiPosetioca(this, viewParam);

            Lista = CitanjeIzBaze.VratiPosetioce();
        }

        public posetilacSet Izabrani
        {
            get { return izabrani; }
            set
            {
                izabrani = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Izabrani"));
            }
        }

        public List<posetilacSet> Lista
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
