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

    class DodajOrkestar : ICommand
    {
        private OrkestarModel viewModel;
        private OrkestarView viewClose;

        public event EventHandler CanExecuteChanged;

        public DodajOrkestar(OrkestarModel param, OrkestarView param2)
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
            DodajOrkestarView view = new DodajOrkestarView();
            viewClose.Close();
            view.ShowDialog();
        }
    }
}
