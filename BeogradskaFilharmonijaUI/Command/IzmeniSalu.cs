using BeogradskaFilharmonijaUI.View;
using BeogradskaFilharmonija;
using BeogradskaFilharmonija.dao;
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
    class IzmeniSalu : ICommand
    {
        private SalaModel viewModel;
        private SalaView viewClose;

        public event EventHandler CanExecuteChanged;

        public IzmeniSalu(SalaModel param, SalaView param2)
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
            IzmeniSaluView view = new IzmeniSaluView();

            if (viewModel.Izabrani == null)
            {
                viewClose.textBlockIspis.Text = "Da biste izmenili salu, prvo morate izabrati jednu iz liste!";
                viewClose.textBlockIspis.Foreground = Brushes.Red;

                return;
            }
            else
            {
                view.textBox.Text = viewModel.Izabrani.idsal.ToString();
                view.textBox1.Text = viewModel.Izabrani.brsed.ToString();
                view.textBox2.Text = viewModel.Izabrani.velsce.ToString();
               // view.comboBox.Text = viewModel.Izabrani.nacem;

                List<dvoranaSet> dvorana = CitanjeIzBaze.VratiDvorana();
                foreach (var item in dvorana)
                {
                    string upis = "ID: " + item.iddvor.ToString() + " , " + item.nazdv;
                    view.comboBox1.Items.Add(upis);

                    if (item.iddvor == viewModel.Izabrani.dvorana_iddvor_sala)
                    {
                        view.comboBox1.Text = upis;
                    }
                }

                viewClose.Close();
                view.ShowDialog();
            }
        }
    }
}
