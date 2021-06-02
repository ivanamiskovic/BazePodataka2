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
    class IzmeniOrkestar : ICommand
    {
        private OrkestarModel viewModel;
        private OrkestarView viewClose;

        public event EventHandler CanExecuteChanged;

        public IzmeniOrkestar(OrkestarModel param, OrkestarView param2)
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
            IzmeniOrkestarView view = new IzmeniOrkestarView();

            if (viewModel.Izabrani == null)
            {
                viewClose.textBlockIspis.Text = "Da biste izmenili orkestar, prvo morate izabrati jednog iz liste!";
                viewClose.textBlockIspis.Foreground = Brushes.Red;

                return;
            }
            else
            {
                view.textBox.Text = viewModel.Izabrani.id.ToString();
                view.textBox1.Text = viewModel.Izabrani.imeork;
                view.textBox2.Text = viewModel.Izabrani.brclan.ToString();

                viewClose.Close();
                view.ShowDialog();
            }
        }
    }
}
