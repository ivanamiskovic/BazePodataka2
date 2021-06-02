using BeogradskaFilharmonijaUI.View;
using BeogradskaFilharmonija.dao;
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
    class ObrisiSalu : ICommand
    {
        private SalaModel viewModel;
        private SalaView view;

        public event EventHandler CanExecuteChanged;

        public ObrisiSalu(SalaModel param, SalaView param2)
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
                view.textBlockIspis.Text = "Da biste obrisali salu, prvo morate izabrati jedan iz liste!";
                view.textBlockIspis.Foreground = Brushes.Red;

                return;
            }
            else
            {
                decimal id = viewModel.Izabrani.idsal;

                int ispis = BrisanjeIzBaze.ObrisiSalu(id);

                if (ispis == 0 || ispis == 2)
                {
                    view.textBlockIspis.Foreground = Brushes.Red;

                    if (ispis == 0)
                        view.textBlockIspis.Text = "U sali sa ID-jem: " + id + " se izvode neki koncerti! Obrisite prvo koncerte!";
                    else
                        view.textBlockIspis.Text = "Doslo je do greske, pokusajte ponovo!";
                }
                else
                {
                    view.textBlockIspis.Text = "Uspesno ste obrisali salu sa ID-jem: " + id;
                    view.textBlockIspis.Foreground = Brushes.Green;

                    viewModel.Lista = CitanjeIzBaze.VratiSale();
                }
            }
        }
    }
}