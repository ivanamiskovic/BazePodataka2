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
   public class ObrisiKartu : ICommand
    {
        private KartaModel viewModel;
        private KartaView view;

        public event EventHandler CanExecuteChanged;

        public ObrisiKartu(KartaModel param, KartaView param2)
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
                view.textBlockIspis.Text = "Da biste obrisali kartu, prvo morate izabrati jednu iz liste!";
                view.textBlockIspis.Foreground = Brushes.Red;

                return;
            }
            else
            {
                decimal id = viewModel.Izabrani.br;

                int ispis = BrisanjeIzBaze.ObrisiKartu(id);

                if (ispis == 0 || ispis == 2)
                {
                    view.textBlockIspis.Foreground = Brushes.Red;

                    if (ispis == 0)
                        view.textBlockIspis.Text = "Karta sa ID-jem: " + id + " je kupljena od nekih posetilaca! Obrisite prvo posetioce!";
                    else
                        view.textBlockIspis.Text = "Doslo je do greske, pokusajte ponovo!";
                }
                else
                {
                    view.textBlockIspis.Text = "Uspesno ste obrisali kartu sa ID-jem: " + id;
                    view.textBlockIspis.Foreground = Brushes.Green;

                    viewModel.Lista = CitanjeIzBaze.VratiKarte();
                }
            }
        }
    }
}