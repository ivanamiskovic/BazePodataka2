using BeogradskaFilharmonija;
using BeogradskaFilharmonija.dao;
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
    public class IzmeniKartu : ICommand
    {
        private KartaModel viewModel;
        private KartaView viewClose;

        public event EventHandler CanExecuteChanged;

        public IzmeniKartu(KartaModel param, KartaView param2)
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
            IzmeniKartuView view = new IzmeniKartuView();

            if (viewModel.Izabrani == null)
            {
                viewClose.textBlockIspis.Text = "Da biste izmenili kartu, prvo morate izabrati jednu iz liste!";
                viewClose.textBlockIspis.Foreground = Brushes.White;

                return;
            }
            else
            {
                view.textBox.Text = viewModel.Izabrani.br.ToString();
                view.textBox1.Text = viewModel.Izabrani.red.ToString();
                view.textBox2.Text = viewModel.Izabrani.sed.ToString();
                view.textBox3.Text = viewModel.Izabrani.daniz.ToString();
                view.textBox4.Text = viewModel.Izabrani.satiz.ToString();
                List<izvodjenjeSet> izvodjenja = CitanjeIzBaze.VratiIzvodjenje();
                foreach (var item in izvodjenja)
                {
                    string upis = "IDSale: " + item.sala_idsal_izvodjenje.ToString() + " , IdKoncerta: " + item.koncert_idkon_izvodjenje.ToString();
                    view.comboBox1.Items.Add(upis);

                    if (item.koncert_idkon_izvodjenje == viewModel.Izabrani.izvodjenje_koncert_idkon_karta && item.sala_idsal_izvodjenje == viewModel.Izabrani.izvodjenje_sala_idsal_karta)
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