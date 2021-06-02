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
    public class IzmeniDvoranu : ICommand
    {
        private DvoranaModel viewModel;
        private DvoranaView viewClose;

        public event EventHandler CanExecuteChanged;

        public IzmeniDvoranu(DvoranaModel param, DvoranaView param2)
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
            IzmeniDvoranaView view = new IzmeniDvoranaView();

            if (viewModel.Izabrani == null)
            {
                viewClose.textBlockIspis.Text = "Da biste izmenili pozoriste, prvo morate izabrati jedno iz liste!";
                viewClose.textBlockIspis.Foreground = Brushes.White;

                return;
            }
            else
            {
                view.textBox.Text = viewModel.Izabrani.iddvor.ToString();
                view.textBox1.Text = viewModel.Izabrani.mest;
                view.textBox2.Text = viewModel.Izabrani.nazdv;
                view.textBox3.Text = viewModel.Izabrani.ul;
                view.textBox4.Text = viewModel.Izabrani.br.ToString();

                viewClose.Close();
                view.ShowDialog();
            }
        }
    }
}
