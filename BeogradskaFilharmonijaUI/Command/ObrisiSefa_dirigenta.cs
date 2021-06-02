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
    public class ObrisiSefa_dirigenta : ICommand
    {
        private ViewModel.Sef_dirigentModel viewModel;
        private Sef_dirigentView view;
        
        public event EventHandler CanExecuteChanged;

        public ObrisiSefa_dirigenta(ViewModel.Sef_dirigentModel param, Sef_dirigentView param2)
        {
            this.viewModel = param;
            this.view = param2;
        }

     

        public bool CanExecute(object parametar)
        {
            return true;
        }

        public void Execute(object parametar)
        {
            if (viewModel.Izabrani == null)
            {
                view.textBlockIspis.Text = "Da biste obrisali sefa dirigenta, prvo morate izabrati jednog iz liste!";
                view.textBlockIspis.Foreground = Brushes.Red;

                return;
            }
            else
            {
                decimal id = viewModel.Izabrani.iddir;

                int ispis = BrisanjeIzBaze.ObrisiSefa_dirigenta(id);

                if (ispis == 0 || ispis == 2)
                {
                    view.textBlockIspis.Foreground = Brushes.Red;

                    if (ispis == 0)
                        view.textBlockIspis.Text = "Sef_dirigent sa ID-jem: " + id + " je dirigovao neki koncert! Obrisite prvo koncert!";
                    else
                        view.textBlockIspis.Text = "Doslo je do greske, pokusajte ponovo!";
                }
                else
                {
                    view.textBlockIspis.Text = "Uspesno ste obrisali sefa dirigenta sa ID-jem: " + id;
                    view.textBlockIspis.Foreground = Brushes.Green;

                    viewModel.Lista = CitanjeIzBaze.Vratisefadirigenta();
                }
            }
        }
    }
}
