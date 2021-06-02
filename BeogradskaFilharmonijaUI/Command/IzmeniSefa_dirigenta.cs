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
    public class IzmeniSefa_dirigenta : ICommand
    {
        private ViewModel.Sef_dirigentModel viewModel;
        private Sef_dirigentView viewClose;
       

        public event EventHandler CanExecuteChanged;

        public IzmeniSefa_dirigenta(ViewModel.Sef_dirigentModel param, Sef_dirigentView param2)
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
            IzmeniSefa_dirigentaView view = new IzmeniSefa_dirigentaView();

            if (viewModel.Izabrani == null)
            {
                viewClose.textBlockIspis.Text = "Da biste izmenili dirigenta, prvo morate izabrati jednog iz liste!";
                viewClose.textBlockIspis.Foreground = Brushes.Red;

                return;
            }
            else
            {
                view.textBox.Text = viewModel.Izabrani.iddir.ToString();
                view.textBox1.Text = viewModel.Izabrani.imed;
                view.textBox2.Text = viewModel.Izabrani.prezdir;

                viewClose.Close();
                view.ShowDialog();
            }
        }
    }
}
