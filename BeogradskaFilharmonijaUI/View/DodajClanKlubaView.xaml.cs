using BeogradskaFilharmonija;
using BeogradskaFilharmonija.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace BeogradskaFilharmonijaUI.View
{
    public partial class DodajClanKlubaView : Window
    {
        public DodajClanKlubaView()
        {
            InitializeComponent();

            //COMBOBOX POSETILAC
            List<posetilacSet> lista = CitanjeIzBaze.VratiPosetioce();

            foreach (var item in lista)
            {
                string upis = "Brojac karte: " + item.brckar.ToString();
                comboBox1.Items.Add(upis);
            }
        }

        //ID
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;

            if (textBox.Text.Length > 6)
            {
                textBlock.Text = "ID clana kluba ne sme biti duzi od 6 cifara!";
                dodaj.Visibility = Visibility.Hidden;

                return;
            }

            for (int i = 0; i < textBox.Text.Length; i++)
            {
                if (char.IsLetter(textBox.Text[i]) || char.IsPunctuation(textBox.Text[i]) || char.IsSymbol(textBox.Text[i]) || char.IsWhiteSpace(textBox.Text[i]))
                {
                    textBlock.Text = "ID clana kluba sme sadrzati samo brojeve!";
                    dodaj.Visibility = Visibility.Hidden;

                    return;
                }
            }

            textBlock.Text = "";

            if (textBlock.Text == "" && textBlock1.Text == "" && textBlock2.Text == "" && textBlock4.Text == "")
                dodaj.Visibility = Visibility.Visible;
        }

        //JMBG
        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;

            if (textBox1.Text.Length != 13)
            {
                textBlock1.Text = "JMBG mora imati 13 cifara!";
                dodaj.Visibility = Visibility.Hidden;

                return;
            }

            for (int i = 0; i < textBox.Text.Length; i++)
            {
                if (char.IsLetter(textBox.Text[i]) || char.IsPunctuation(textBox.Text[i]) || char.IsSymbol(textBox.Text[i]) || char.IsWhiteSpace(textBox.Text[i]))
                {
                    textBlock1.Text = "JMBG sme sadrzati samo brojeve!";
                    dodaj.Visibility = Visibility.Hidden;

                    return;
                }
            }

            textBlock1.Text = "";

            if (textBlock.Text == "" && textBlock1.Text == "" && textBlock2.Text == "" && textBlock3.Text == "" && textBlock4.Text == "")
                dodaj.Visibility = Visibility.Visible;

            string datumRodjenja = "";
            for (int i = 0; i < 2; i++)
            {
                datumRodjenja += textBox1.Text[i];
            }

            datumRodjenja += '/';

            for (int i = 2; i < 4; i++)
            {
                datumRodjenja += textBox1.Text[i];
            }

            datumRodjenja += '/';

            if (textBox1.Text[4] == '9')
            {
                datumRodjenja += '1';
            }
            else if (textBox1.Text[4] == '0')
            {
                datumRodjenja += '2';
            }

            for (int i = 4; i < 7; i++)
            {
                datumRodjenja += textBox1.Text[i];
            }

            textBox5.Text = datumRodjenja;
        }

        //IME CLANA KLUBA
        private void TextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;

            if (textBox2.Text.Length > 30)
            {
                textBlock2.Text = "Ime clana kluba ne sme biti duze od 30 karaktera!";
                dodaj.Visibility = Visibility.Hidden;

                return;
            }

            textBlock2.Text = "";

            if (textBlock.Text == "" && textBlock1.Text == "" && textBlock2.Text == "" && textBlock3.Text == "" && textBlock4.Text == "")
                dodaj.Visibility = Visibility.Visible;
        }


        //PREZIME CLANA KLUBA
        private void TextBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;

            if (textBox3.Text.Length > 30)
            {
                textBlock3.Text = "Prezime clana kluba ne sme biti duze od 30 karaktera!";
                dodaj.Visibility = Visibility.Hidden;

                return;
            }

            textBlock3.Text = "";

            if (textBlock.Text == "" && textBlock1.Text == "" && textBlock2.Text == "" && textBlock3.Text == "" && textBlock4.Text == "")
                dodaj.Visibility = Visibility.Visible;
        }

        //KORISNICKO IME
        private void TextBox4_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;

            if (textBox2.Text.Length > 30)
            {
                textBlock2.Text = "Korisnicko ime clana kluba ne sme biti duze od 30 karaktera!";
                dodaj.Visibility = Visibility.Hidden;

                return;
            }

            textBlock2.Text = "";

            if (textBlock.Text == "" && textBlock1.Text == "" && textBlock2.Text == "" && textBlock3.Text == "" && textBlock4.Text == "")
                dodaj.Visibility = Visibility.Visible;
        }

        private void Dodaj_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "" || textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || comboBox1.Text == "")
            {
                textBlockUspeh.Text = "Neka polja su prazna, popunite ih!";
                textBlockUspeh.Foreground = Brushes.White;

                return;
            }

            int sfr = Convert.ToInt32(textBox.Text);
            string jmbg = textBox1.Text;
            string imeClanaKluba = textBox2.Text;
            string prezimeClanaKluba = textBox3.Text;
            string korisnickoIme = textBox4.Text;
            string datumRodjenja = textBox5.Text;

            string posetilac = comboBox1.Text;
            string[] reci = posetilac.Split(' ');
            int brojacKarte = Convert.ToInt32(reci[2]);

            int prolaz = DodavanjeUBazu.DodajClanaKluba(sfr, jmbg, imeClanaKluba, prezimeClanaKluba, korisnickoIme, datumRodjenja, brojacKarte);

            if (prolaz == 0)
            {
                textBlockUspeh.Text = "Vec postoji clan kluba sa id-jem: " + sfr;
                textBlockUspeh.Foreground = Brushes.White;
            }
            else if (prolaz == 1)
            {
                textBlockUspeh.Text = "Vec postoji clan kluba sa korisnickim imenom: " + korisnickoIme;
                textBlockUspeh.Foreground = Brushes.White;
            }
            else if (prolaz == 2)
            {
                textBlockUspeh.Text = "Uspesno ste dodali clana kluba sa sifrom: " + sfr;
                textBlockUspeh.Foreground = Brushes.Black;
            }
            else
            {
                textBlockUspeh.Text = "Desila se neka greska!";
                textBlockUspeh.Foreground = Brushes.White;
            }
        }

        private void Vrati_se_Click(object sender, RoutedEventArgs e)
        {
            ClanKlubaView view = new ClanKlubaView();
            this.Close();
            view.ShowDialog();
        }
    }
}
