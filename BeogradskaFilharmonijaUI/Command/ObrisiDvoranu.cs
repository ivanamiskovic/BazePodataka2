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

    public class ObrisiDvoranu : ICommand
    {
        private DvoranaModel viewModel;
        private DvoranaView view;

        public event EventHandler CanExecuteChanged;

        public ObrisiDvoranu(DvoranaModel param, DvoranaView param2)
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
                view.textBlockIspis.Text = "Da biste obrisali dvoranu, prvo morate izabrati jedno iz liste!";
                view.textBlockIspis.Foreground = Brushes.White;

                return;
            }
            else
            {
                decimal id = viewModel.Izabrani.iddvor;

                int ispis = BrisanjeIzBaze.ObrisiDvoranu(id);

                if (ispis == 0 || ispis == 2)
                {
                    view.textBlockIspis.Foreground = Brushes.White;

                    if (ispis == 0)
                        view.textBlockIspis.Text = "Dvorana sa ID-jem: " + id + " ima sale vezane za njega! Obrisite prvo sale!";
                    else
                        view.textBlockIspis.Text = "Doslo je do greske, pokusajte ponovo!";
                }
                else
                {
                    view.textBlockIspis.Text = "Uspesno ste obrisali dvoranu sa ID-jem: " + id;
                    view.textBlockIspis.Foreground = Brushes.Black;

                    viewModel.Lista = CitanjeIzBaze.VratiDvorana();
                }
            }
        }
    }
}
