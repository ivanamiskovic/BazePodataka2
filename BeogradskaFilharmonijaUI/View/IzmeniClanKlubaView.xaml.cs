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
    public partial class IzmeniClanKlubaView : Window
    {

        public IzmeniClanKlubaView()
        {
            InitializeComponent();
        }
        //jmbg
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;

            if (textBox1.Text.Length != 13)
            {
                textBlock1.Text = "JMBG mora imati 13 cifara!";

                return;
            }

            for (int i = 0; i < textBox.Text.Length; i++)
            {
                if (char.IsLetter(textBox.Text[i]) || char.IsPunctuation(textBox.Text[i]) || char.IsSymbol(textBox.Text[i]) || char.IsWhiteSpace(textBox.Text[i]))
                {
                    textBlock1.Text = "JMBG sme sadrzati samo brojeve!";

                    return;
                }
            }

            textBlock1.Text = "";

            if (textBlock.Text == "" && textBlock1.Text == "" && textBlock2.Text == "" && textBlock3.Text == "" && textBlock4.Text == "")
                izmeni.Visibility = Visibility.Visible;

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
        //ime clana
        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;

            if (textBox2.Text.Length > 30)
            {
                textBlock2.Text = "Ime clana kluba ne sme biti duze od 30 karaktera!";

                return;
            }

            for (int i = 0; i < textBox.Text.Length; i++)
            {
                if (char.IsDigit(textBox.Text[i]) || char.IsPunctuation(textBox.Text[i]) || char.IsSymbol(textBox.Text[i]) || char.IsWhiteSpace(textBox.Text[i]))
                {
                    textBlock2.Text = "Ime clana kluba smije sadrzati samo slova!";
                    //izmeni.Visibility = Visibility.Hidden;

                    return;
                }
            }

            textBlock2.Text = "";

            //if (textBlock.Text == "" && textBlock1.Text == "" && textBlock2.Text == "" && textBlock3.Text == "" && textBlock4.Text == "")
            //izmeni.Visibility = Visibility.Visible;
        }
        //prezime
        private void TextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;

            if (textBox3.Text.Length > 30)
            {
                textBlock3.Text = "Prezime clana kluba ne sme biti duze od 30 karaktera!";
                //izmeni.Visibility = Visibility.Hidden;

                return;
            }

            for (int i = 0; i < textBox.Text.Length; i++)
            {
                if (char.IsDigit(textBox.Text[i]) || char.IsPunctuation(textBox.Text[i]) || char.IsSymbol(textBox.Text[i]) || char.IsWhiteSpace(textBox.Text[i]))
                {
                    textBlock3.Text = "Prezime clana kluba sme sadrzati samo slova!";
                    //izmeni.Visibility = Visibility.Hidden;

                    return;
                }
            }

            textBlock3.Text = "";

            //if (textBlock.Text == "" && textBlock1.Text == "" && textBlock2.Text == "" && textBlock3.Text == "" && textBlock4.Text == "")
            //izmeni.Visibility = Visibility.Visible;
        }
        //korisnicko ime
        private void TextBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;

            if (textBox2.Text.Length > 30)
            {
                textBlock2.Text = "Korisnicko ime clana kluba ne sme biti duze od 30 karaktera!";
                //izmeni.Visibility = Visibility.Hidden;

                return;
            }

            textBlock2.Text = "";

            //if (textBlock.Text == "" && textBlock1.Text == "" && textBlock2.Text == "" && textBlock3.Text == "" && textBlock4.Text == "")
            //izmeni.Visibility = Visibility.Visible;
        }

        private void TextBox4_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;

            if (textBox2.Text.Length > 30)
            {
                textBlock2.Text = "Korisnicko ime clana kluba ne sme biti duze od 30 karaktera!";
                //izmeni.Visibility = Visibility.Hidden;

                return;
            }

            textBlock2.Text = "";

            //if (textBlock.Text == "" && textBlock1.Text == "" && textBlock2.Text == "" && textBlock3.Text == "" && textBlock4.Text == "")
            //izmeni.Visibility = Visibility.Visible;
        }



        private void Izmeni_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                textBlockUspeh.Text = "Neka polja su prazna, molim vas popunite ih!";
                textBlockUspeh.Foreground = Brushes.Red;

                return;
            }

            int sfr = Convert.ToInt32(textBox.Text);
            string jmbg = textBox1.Text;
            string imeck = textBox2.Text;
            string przck = textBox3.Text;
            string korime = textBox4.Text;
            string datrodj = textBox5.Text;

            int prolaz = AzuriranjeUBazi.AzurirajClanKluba(sfr, jmbg, imeck, przck, korime, datrodj);

            if (prolaz == 0)
            {
                textBlockUspeh.Text = "Uspesno ste izmenili clana kluba sa sifrom: " + sfr;
                textBlockUspeh.Foreground = Brushes.Green;
            }
            else if (prolaz == 1)
            {
                textBlockUspeh.Text = "Vec postoji korisnicko ime: " + korime;
                textBlockUspeh.Foreground = Brushes.Green;
            }
            else if (prolaz == 2)
            {
                textBlockUspeh.Text = "Desila se greska!";
                textBlockUspeh.Foreground = Brushes.Red;
            }

           
        }

        private void Vrati_se_Click(object sender, RoutedEventArgs e)
        {
            ClanKlubaView view = new ClanKlubaView();
            this.Close();
            view.ShowDialog();
        }

        private void TextBox5_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
