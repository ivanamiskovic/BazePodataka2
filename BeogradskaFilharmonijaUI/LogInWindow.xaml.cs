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
	/// Interaction logic for LogInWindow.xaml
	/// </summary>
	public partial class LogInWindow : Window
	{
		public LogInWindow()
		{
			InitializeComponent();
		}

		private void UlogujSe_Click(object sender, RoutedEventArgs e)
		{
			if (korisnickoImeTextBox.Text == "" || sifraBox.Password == "")
			{
				textBlockUspeh.Text = "Neka polja su prazna, popunite ih!";
				textBlockUspeh.Foreground = Brushes.Red;

				return;
			}



			Korisnik postoji = PomocnaKlasa.ProveriDaliPostojiKorisnik(korisnickoImeTextBox.Text, sifraBox.Password);
			if (postoji == null)
			{
				textBlockUspeh.Text = "Korisnik sa unetim kredencijalima ne postoji, probajte ponovo";
				textBlockUspeh.Foreground = Brushes.Red;

				return;
			}

			GlobalnaKorisnickaKlasa.korisnik = postoji;
			GlobalnaKorisnickaKlasa.korisnik.Uloga = GlobalnaKorisnickaKlasa.korisnik.Uloga.Trim();
			GlobalnaKorisnickaKlasa.korisnik.Sifra = GlobalnaKorisnickaKlasa.korisnik.Sifra.Trim();
			GlobalnaKorisnickaKlasa.korisnik.KorisnickoIme = GlobalnaKorisnickaKlasa.korisnik.KorisnickoIme.Trim();

			MainWindow view = new MainWindow();
			Close();
			view.ShowDialog();
		}

		private void RegistrujSe_Click(object sender, RoutedEventArgs e)
		{
			RegisterWindow view = new RegisterWindow();
			Close();
			view.ShowDialog();
		}
	}
}
