using BeogradskaFilharmonija;
using BeogradskaFilharmonija.dao;
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
using System.Windows.Shapes;

namespace BeogradskaFilharmonijaUI
{
	/// <summary>
	/// Interaction logic for RegisterWindow.xaml
	/// </summary>
	public partial class RegisterWindow : Window
	{
		public RegisterWindow()
		{
			InitializeComponent();
		}

		private void RegistrujSe_Click(object sender, RoutedEventArgs e)
		{
			if (korisnickoImeTextBox.Text == "" || sifraBox.Password == "" || ulogaComboBox.Text == "")
			{
				textBlockUspeh.Text = "Neka polja su prazna, popunite ih!";
				textBlockUspeh.Foreground = Brushes.Red;

				return;
			}

			Korisnik postoji = PomocnaKlasa.ProveriDaliPostojiKorisnik(korisnickoImeTextBox.Text, sifraBox.Password);
			if (postoji != null)
			{
				textBlockUspeh.Text = "Korisnik sa unetim kredencijalima vec postoji, probajte ponovo";
				textBlockUspeh.Foreground = Brushes.Red;

				return;
			}

			bool uspesno = DodavanjeUBazu.DodajKorisnika(korisnickoImeTextBox.Text, korisnickoImeTextBox.Text, ulogaComboBox.Text);
			if (uspesno == false)
			{
				textBlockUspeh.Text = "Doslo je do greske, probajte ponovo";
				textBlockUspeh.Foreground = Brushes.Red;

				return;
			}

			LogInWindow view = new LogInWindow();
			Close();
			view.ShowDialog();
		}

		private void UlogujSe_Click(object sender, RoutedEventArgs e)
		{
			LogInWindow view = new LogInWindow();
			Close();
			view.ShowDialog();
		}
	}
}
