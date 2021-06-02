using BeogradskaFilharmonija.dao;
using BeogradskaFilharmonijaUI.View;
using BeogradskaFilharmonijaUI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;

namespace BeogradskaFilharmonijaUI.Command
{
    class ObrisiPosetioca : ICommand
    {
        private PosetilacModel viewModel;
        private PosetilacView view;

        public event EventHandler CanExecuteChanged;

        public ObrisiPosetioca(PosetilacModel param, PosetilacView param2)
        {
            this.viewModel = param;
            this.view = param2;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (viewModel.Izabrani == null)
            {
                view.textBlockIspis.Text = "Da biste obrisali posetioca, prvo morate izabrati jednog iz liste!";
                view.textBlockIspis.Foreground = Brushes.Red;

                return;
            }
            else
            {
                decimal brojac = viewModel.Izabrani.brckar;

                int ispis = BrisanjeIzBaze.ObrisiPosetioca(brojac);

                if (ispis == 2)
                {
                    view.textBlockIspis.Foreground = Brushes.Red;
                    view.textBlockIspis.Text = "Doslo je do greske, pokusajte ponovo!";
                }
                else
                {
                    view.textBlockIspis.Text = "Uspesno ste obrisali posetioca sa brojacem: " + brojac;
                    view.textBlockIspis.Foreground = Brushes.Green;

                    viewModel.Lista = CitanjeIzBaze.VratiPosetioce();
                }
            }
        }
    }
}