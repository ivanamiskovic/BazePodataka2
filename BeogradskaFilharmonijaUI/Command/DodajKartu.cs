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
    public class DodajKartu : ICommand
    {
        private KartaModel viewModel;
        private KartaView viewClose;

        public event EventHandler CanExecuteChanged;

        public DodajKartu(KartaModel param, KartaView param2)
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
            DodajKartuView view = new DodajKartuView();
            viewClose.Close();
            view.ShowDialog();
        }
    }
}
