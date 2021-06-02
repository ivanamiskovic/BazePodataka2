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
   public class ObrisiClanKluba : ICommand
    {
        private ClanKlubaModel viewModel;
        private ClanKlubaView view;

        public event EventHandler CanExecuteChanged;

        public ObrisiClanKluba(ClanKlubaModel param, ClanKlubaView param2)
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
                decimal id = viewModel.Izabrani.sfr;

                int ispis = BrisanjeIzBaze.ObrisiClanKluba(id);

                if (ispis == 2)
                {
                    view.textBlockIspis.Text = "Doslo je do greske, pokusajte ponovo!";
                    view.textBlockIspis.Foreground = Brushes.Red;
                }
                else
                {
                    view.textBlockIspis.Text = "Uspesno ste obrisali clana kluba sa ID-jem: " + id;
                    view.textBlockIspis.Foreground = Brushes.Green;

                    viewModel.Lista = CitanjeIzBaze.VratiClanKluba();
                }
            }
        }
    }
}