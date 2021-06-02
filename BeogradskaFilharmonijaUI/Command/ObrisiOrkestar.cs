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

    class ObrisiOrkestar : ICommand
    {
        private OrkestarModel viewModel;
        private OrkestarView view;

        public event EventHandler CanExecuteChanged;

        public ObrisiOrkestar(OrkestarModel param, OrkestarView param2)
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
                view.textBlockIspis.Text = "Da biste obrisali orkestar, prvo morate izabrati jednog iz liste!";
                view.textBlockIspis.Foreground = Brushes.Red;

                return;
            }
            else
            {
                decimal id = viewModel.Izabrani.id;

                int ispis = BrisanjeIzBaze.ObrisiOrkestar(id);

                if (ispis == 0 || ispis == 2)
                {
                    view.textBlockIspis.Foreground = Brushes.Red;

                    if (ispis == 0)
                        view.textBlockIspis.Text = "Orkestar sa ID-jem: " + id + " svira na nekim nastupima! Obrisite prvo nastupe!";
                    else
                        view.textBlockIspis.Text = "Doslo je do greske, pokusajte ponovo!";
                }
                else
                {
                    view.textBlockIspis.Text = "Uspesno ste obrisali nastup sa ID-jem: " + id;
                    view.textBlockIspis.Foreground = Brushes.Green;

                    viewModel.Lista = CitanjeIzBaze.VratiOrkestre();
                }
            }
        }
    }
}