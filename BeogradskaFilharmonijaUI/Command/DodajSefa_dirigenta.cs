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
    public class DodajSefa_dirigenta : ICommand
    {
        private Sef_dirigentModel viewModel;
        private Sef_dirigentView viewClose;
        

        public event EventHandler CanExecuteChanged;

        public DodajSefa_dirigenta(Sef_dirigentModel param, Sef_dirigentView param2)
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
            DodajSefa_dirigentaView view = new DodajSefa_dirigentaView();
            viewClose.Close();
            view.ShowDialog();
        }
    }
}
