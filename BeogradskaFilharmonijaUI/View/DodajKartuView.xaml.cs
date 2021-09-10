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
    public partial class DodajKartuView : Window
    {
        public DodajKartuView()
        {
            InitializeComponent();

            List<izvodjenjeSet> lista = CitanjeIzBaze.VratiIzvodjenje();

            foreach (var item in lista)
            {
                string upis = "IDSale: " + item.sala_idsal_izvodjenje.ToString() + " , IDKoncerta: " + item.koncert_idkon_izvodjenje.ToString();
                comboBox1.Items.Add(upis);
            }
        }

        //ID
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;

            if (textBox.Text.Length > 6)
            {
                textBlock.Text = "ID karte ne sme biti duzi od 6 cifara!";
                dodaj.Visibility = Visibility.Hidden;

                return;
            }

            for (int i = 0; i < textBox.Text.Length; i++)
            {
                if (char.IsLetter(textBox.Text[i]) || char.IsPunctuation(textBox.Text[i]) || char.IsSymbol(textBox.Text[i]) || char.IsWhiteSpace(textBox.Text[i]))
                {
                    textBlock.Text = "ID karte sme sadrzati samo brojeve!";
                    dodaj.Visibility = Visibility.Hidden;

                    return;
                }
            }

            textBlock.Text = "";

            if (textBlock.Text == "" && textBlock1.Text == "" && textBlock2.Text == "" && textBlock3.Text == "" && textBlock4.Text == "" && textBlock5.Text == "")
                dodaj.Visibility = Visibility.Visible;
        }


        //RED
        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;

            if (textBox1.Text.Length > 4)
            {
                textBlock1.Text = "Broj reda sale ne sme biti duzi od 4 cifara!";
                dodaj.Visibility = Visibility.Hidden;

                return;
            }

            for (int i = 0; i < textBox.Text.Length; i++)
            {
                if (char.IsLetter(textBox.Text[i]) || char.IsPunctuation(textBox.Text[i]) || char.IsSymbol(textBox.Text[i]) || char.IsWhiteSpace(textBox.Text[i]))
                {
                    textBlock1.Text = "Red sale sme sadrzati samo brojeve!";
                    dodaj.Visibility = Visibility.Hidden;

                    return;
                }
            }

            textBlock1.Text = "";

            if (textBlock.Text == "" && textBlock1.Text == "" && textBlock2.Text == "" && textBlock3.Text == "" && textBlock4.Text == "" && textBlock5.Text == "")
                dodaj.Visibility = Visibility.Visible;
        }


        //BROJ SEDISTA
        private void TextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;

            if (textBox2.Text.Length > 4)
            {
                textBlock2.Text = "Redni broj sedista ne sme biti duzi od 5 cifara!";
                dodaj.Visibility = Visibility.Hidden;

                return;
            }

            for (int i = 0; i < textBox.Text.Length; i++)
            {
                if (char.IsLetter(textBox.Text[i]) || char.IsPunctuation(textBox.Text[i]) || char.IsSymbol(textBox.Text[i]) || char.IsWhiteSpace(textBox.Text[i]))
                {
                    textBlock2.Text = "Redni broj sedista sme sadrzati samo brojeve!";
                    dodaj.Visibility = Visibility.Hidden;

                    return;
                }
            }

            textBlock2.Text = "";

            if (textBlock.Text == "" && textBlock1.Text == "" && textBlock2.Text == "" && textBlock3.Text == "" && textBlock4.Text == "" && textBlock5.Text == "")
                dodaj.Visibility = Visibility.Visible;
        }


        //DAN IZVODJENJA
        private void TextBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;

            if (textBox3.Text.Length > 10)
            {
                textBlock3.Text = "Naziv dana ne sme biti duzi od 10 karaktera!";
                dodaj.Visibility = Visibility.Hidden;

                return;
            }

            for (int i = 0; i < textBox.Text.Length; i++)
            {
                if (char.IsNumber(textBox.Text[i]) || char.IsWhiteSpace(textBox.Text[i]))
                {
                    textBlock3.Text = "Naziv dana sme sadrzati samo slova!";
                    dodaj.Visibility = Visibility.Hidden;

                    return;
                }
            }

            textBlock3.Text = "";

            if (textBlock.Text == "" && textBlock1.Text == "" && textBlock2.Text == "" && textBlock3.Text == "" && textBlock4.Text == "" && textBlock5.Text == "")
                dodaj.Visibility = Visibility.Visible;
        }

        private bool IsValidTimeFormat(string input)
        {
            TimeSpan time;
            return TimeSpan.TryParse(input, out time);
        }

        //SAT Izvodjenja
        private void TextBox4_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;

            if (textBox4.Text.Length > 5)
            {
                textBlock4.Text = "Vreme prikazivanja ne sme imati vise od 5 karaktera";
                dodaj.Visibility = Visibility.Hidden;

                return;
            }

            bool uspesnoVrijeme = IsValidTimeFormat(textBox.Text);
            if (uspesnoVrijeme == true)
            {
                textBlock4.Text = "";
                if (textBlock.Text == "" && textBlock1.Text == "" && textBlock2.Text == "" && textBlock3.Text == "" && textBlock4.Text == "" && textBlock5.Text == "")
                    dodaj.Visibility = Visibility.Visible;
                return;
            }
            else
            {
                textBlock4.Text = "Vreme prikazivanja moze biti samo u formatu vremena";
                dodaj.Visibility = Visibility.Hidden;

                return;
            }

        }
        //cena
        private void TextBox5_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;

            if (textBox5.Text.Length > 4)
            {
                textBlock5.Text = "Cena karte ne sme biti duzi od 4 cifara!";
                dodaj.Visibility = Visibility.Hidden;

                return;
            }

            for (int i = 0; i < textBox.Text.Length; i++)
            {
                if (char.IsLetter(textBox.Text[i]) || char.IsPunctuation(textBox.Text[i]) || char.IsSymbol(textBox.Text[i]) || char.IsWhiteSpace(textBox.Text[i]))
                {
                    textBlock5.Text = "Cena karte sme sadrzati samo brojeve!";
                    dodaj.Visibility = Visibility.Hidden;

                    return;
                }
            }

            textBlock5.Text = "";

            if (textBlock.Text == "" && textBlock1.Text == "" && textBlock2.Text == "" && textBlock3.Text == "" && textBlock4.Text == "" && textBlock5.Text == "")
                dodaj.Visibility = Visibility.Visible;
        }

        private void Dodaj_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || comboBox1.Text == "")
            {
                textBlockUspeh.Text = "Neka polja su prazna, popunite ih!";
                textBlockUspeh.Foreground = Brushes.Red;
                this.Close();
                return;
            }

           // int id = Convert.ToInt32(textBox.Text);
            int red = Convert.ToInt32(textBox1.Text);
            int brojSedista = Convert.ToInt32(textBox2.Text);
            string danIzvodjenja = textBox3.Text;
            string satIzvodjenja = textBox4.Text;
            float cena = float.Parse(textBox5.Text);

            string projekcija = comboBox1.Text;
            string[] reci = projekcija.Split(' ');
            int idSale = Int32.Parse(reci[1]);
            int idKoncerta = Int32.Parse(reci[4]);

            bool prolaz = DodavanjeUBazu.DodajKartu(red, brojSedista, danIzvodjenja, satIzvodjenja, cena, idSale, idKoncerta);
            this.Close();
            /*  if (prolaz == false)
            {
                textBlockUspeh.Text = "Vec postoji karta sa id-jem: " + id;
                textBlockUspeh.Foreground = Brushes.White;
            }
            else
            {
                textBlockUspeh.Text = "Uspesno ste dodali kartu sa id-jem: " + id;
                textBlockUspeh.Foreground = Brushes.Black;
            }
          */
        }

        private void Vrati_se_Click(object sender, RoutedEventArgs e)
        {
            KartaView view = new KartaView();
            this.Close();
            view.ShowDialog();

        }
    }
}
