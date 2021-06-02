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
    public class DodajDvoranu : ICommand
    {
        private DvoranaModel viewModel;
        private DvoranaView viewClose;

        public event EventHandler CanExecuteChanged;

        public DodajDvoranu(DvoranaModel param, DvoranaView param2)
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
            DodajDvoranaView view = new DodajDvoranaView();
            viewClose.Close();
            view.ShowDialog();
        }
    }
}
