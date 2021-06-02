using BeogradskaFilharmonija;
using BeogradskaFilharmonija.dao;
using BeogradskaFilharmonijaUI.View;
using BeogradskaFilharmonijaUI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace BeogradskaFilharmonijaUI.Command
{
    class IzmeniKoncert : ICommand
    {
        private KoncertModel viewModel;
        private KoncertView viewClose;

        public event EventHandler CanExecuteChanged;

        public IzmeniKoncert(KoncertModel param, KoncertView param2)
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
            IzmeniKoncertView view = new IzmeniKoncertView();

            if (viewModel.Izabrani == null)
            {
                viewClose.textBlockIspis.Text = "Da biste izmenili koncert, prvo morate izabrati jednu iz liste!";
                viewClose.textBlockIspis.Foreground = Brushes.Red;

                return;
            }
            else
            {
                view.textBox.Text = viewModel.Izabrani.idkon.ToString();
                view.textBox1.Text = viewModel.Izabrani.traj.ToString();
                view.textBox2.Text = viewModel.Izabrani.nazkon;
                view.textBox3.Text = viewModel.Izabrani.znrmuzik;

                List<salaSet> sale = CitanjeIzBaze.VratiSale();
                List<orkestarSet> orkestar = CitanjeIzBaze.VratiOrkestre();
                List<sef_dirigentSet> sef_dirigent = CitanjeIzBaze.Vratisefadirigenta();

                List<string> cekiranaIzvodjenja = PomocnaKlasa.ListBoxIzvodjenjaKoncerta(viewModel.Izabrani.idkon);
                List<string> cekiraniOrkestar = PomocnaKlasa.ListBoxOrkestaraNaKoncertu(viewModel.Izabrani.idkon);
                List<string> cekiraniSef_dirigent = PomocnaKlasa.ListBoxSef_dirigentNaKoncertu(viewModel.Izabrani.idkon);

                foreach (var item in sale)
                {
                    CheckBox cb = new CheckBox();
                    cb.Content = "ID: " + item.idsal.ToString() + " , ID dvorane: " + item.dvorana_iddvor_sala;

                    if (cekiranaIzvodjenja.Contains("ID: " + item.idsal.ToString() + " , ID pozorista: " + item.dvorana_iddvor_sala))
                        cb.IsChecked = true;
                    else
                        cb.IsChecked = false;

                    view.listBox.Items.Add(cb);
                }

                foreach (var item in orkestar)
                {
                    string s = "ID: " + item.id.ToString() + " , " + item.imeork + " " ;
                    CheckBox cb = new CheckBox();
                    cb.Content = s;

                    if (cekiraniOrkestar.Contains(s))
                        cb.IsChecked = true;
                    else
                        cb.IsChecked = false;

                    view.listBox1.Items.Add(cb);
                }

                foreach (var item in sef_dirigent)
                {
                    CheckBox cb = new CheckBox();
                    cb.Content = "ID: " + item.iddir.ToString() + " , " + item.imed + " " + item.prezdir;

                    if (cekiraniSef_dirigent.Contains("ID: " + item.iddir.ToString() + " , " + item.imed + " " + item.prezdir))
                        cb.IsChecked = true;
                    else
                        cb.IsChecked = false;

                    view.listBox2.Items.Add(cb);
                }

                viewClose.Close();
                view.ShowDialog();
            }
        }
    }
}
