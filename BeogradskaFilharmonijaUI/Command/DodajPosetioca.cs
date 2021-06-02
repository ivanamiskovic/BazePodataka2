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
    class DodajPosetioca : ICommand
    {
        private PosetilacModel viewModel;
        private PosetilacView viewClose;

        public event EventHandler CanExecuteChanged;

        public DodajPosetioca(PosetilacModel param, PosetilacView param2)
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
            DodajPosetiocaView view = new DodajPosetiocaView();
            viewClose.Close();
            view.ShowDialog();
        }
    }
}