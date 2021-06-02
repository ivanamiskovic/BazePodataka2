using BeogradskaFilharmonijaUI.View;
using BeogradskaFilharmonijaUI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BeogradskaFilharmonijaUI.Command
{
    class DodajKoncert : ICommand
    {
        private KoncertModel viewModel;
        private KoncertView viewClose;

        public event EventHandler CanExecuteChanged;

        public DodajKoncert(KoncertModel param, KoncertView param2)
        {
            this.viewModel = param;
            this.viewClose = param2;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            DodajKoncertView view = new DodajKoncertView();
            viewClose.Close();
            view.ShowDialog();
        }
    }
}
