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
    class ObrisiKoncert : ICommand
    {
        private KoncertModel viewModel;
        private KoncertView view;

        public event EventHandler CanExecuteChanged;

        public ObrisiKoncert(KoncertModel param, KoncertView param2)
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
                view.textBlockIspis.Text = "Da biste obrisali, prvo morate izabrati jedan iz liste!";
                view.textBlockIspis.Foreground = Brushes.Red;

                return;
            }
            else
            {
                decimal id = viewModel.Izabrani.idkon;

                int ispis = BrisanjeIzBaze.ObrisiKoncert(id);

                if (ispis == 2)
                {
                    view.textBlockIspis.Foreground = Brushes.Red;
                    view.textBlockIspis.Text = "Doslo je do greske, pokusajte ponovo!";
                }
                else
                {
                    view.textBlockIspis.Text = "Uspesno ste obrisali  sa ID-jem: " + id;
                    view.textBlockIspis.Foreground = Brushes.Green;

                    viewModel.Lista = CitanjeIzBaze.VratiKoncerte();
                }
            }
        }

    }
}
