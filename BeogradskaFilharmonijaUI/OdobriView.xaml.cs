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
	/// Interaction logic for OdobriView.xaml
	/// </summary>
	public partial class OdobriView : Window
	{
		//TODO DODATO
		public OdobriView()
		{
			InitializeComponent();

			List<Korisnik> korisniks = CitanjeIzBaze.VratiKorisnike();
			foreach (var korisnik in korisniks)
			{
				if (korisnik.Uloga != "Admin" && korisnik.Odobreno == 0)
				{
					korisnikComboBox.Items.Add(korisnik.KorisnickoIme);
				}
			}
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			string korisnickoIme = korisnikComboBox.Text;
			if (korisnickoIme == null || korisnickoIme == "")
			{
				textBlockUspeh.Text = "Morate izabrati korisnika iz padajuceg menija, probajte ponovo";
				textBlockUspeh.Foreground = Brushes.Red;

				return;
			}

			bool uspesno = AzuriranjeUBazi.OdobriKorisnika(korisnickoIme);
			if (uspesno == false)
			{
				textBlockUspeh.Text = "Doslo je do greske, probajte ponovo";
				textBlockUspeh.Foreground = Brushes.Red;

				return;
			}

			var korisniks = korisnikComboBox.Items;
			foreach (var korisnik in korisniks)
			{
				if (korisnik.ToString() == korisnickoIme)
				{
					korisnikComboBox.Items.Remove(korisnik);
					break;
				}
			}
		}
	}
}
