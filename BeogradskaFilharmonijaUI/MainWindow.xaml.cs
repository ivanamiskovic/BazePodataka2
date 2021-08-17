using BeogradskaFilharmonijaUI.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BeogradskaFilharmonijaUI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonDvorana_Click(object sender, RoutedEventArgs e)
        {
            DvoranaView view = new DvoranaView();
            view.ShowDialog();
        }

        private void buttonSala_Click(object sender, RoutedEventArgs e)
        {
            SalaView view = new SalaView();
            view.ShowDialog();
        }

        private void buttonKoncert_Click(object sender, RoutedEventArgs e)
        {
            KoncertView view = new KoncertView();
            view.ShowDialog();
        }

        private void buttonOrkestar_Click(object sender, RoutedEventArgs e)
        {
            OrkestarView view = new OrkestarView();
            view.ShowDialog();
        }

        private void buttonPosetilac_Click(object sender, RoutedEventArgs e)
        {
            PosetilacView view = new PosetilacView();
            view.ShowDialog();
        }

        //private void buttonFjeProcedure_Click(object sender, RoutedEventArgs e)
        //{
        //    GlumciZanrView view = new GlumciZanrView();
        //    view.ShowDialog();
        //}

        private void ButtonSef_dirigent_Click(object sender, RoutedEventArgs e)
        {
            Sef_dirigentView view = new Sef_dirigentView();
            view.ShowDialog();
        }

        private void ButtonKarta_Click(object sender, RoutedEventArgs e)
        {
            KartaView view = new KartaView();
            view.ShowDialog();
        }

        private void ButtonClanKluba_Click_1(object sender, RoutedEventArgs e)
        {
            ClanKlubaView view = new ClanKlubaView();
            view.ShowDialog();
        }

		private void buttonOdjaviSe_Click(object sender, RoutedEventArgs e)
		{
            GlobalnaKorisnickaKlasa.korisnik = null;

            LogInWindow view = new LogInWindow();
            Close();
            view.ShowDialog();
        }
	}
}
