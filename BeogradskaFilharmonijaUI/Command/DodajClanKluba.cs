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
    public class DodajClanKluba : ICommand
    {
        private ClanKlubaModel viewModel;
        private ClanKlubaView viewClose;

        public event EventHandler CanExecuteChanged;

        public DodajClanKluba(ClanKlubaModel param, ClanKlubaView param2)
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
            DodajClanKlubaView view = new DodajClanKlubaView();
            viewClose.Close();
            view.ShowDialog();
        }
    }
}
