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
    public partial class DodajDvoranaView : Window
    {
        public DodajDvoranaView()
        {
            InitializeComponent();
        }

        //ID
        
        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;

            if (textBox.Text.Length > 6)
            {
                textBlock.Text = "ID dvorane ne sme biti duzi od 6 cifara!";
                dodaj.Visibility = Visibility.Hidden; //sakrije vidljivost dugmeta dodaj

                return;
            }

            for (int i = 0; i < textBox.Text.Length; i++)
            {
                if (char.IsLetter(textBox.Text[i]) || char.IsPunctuation(textBox.Text[i]) || char.IsSymbol(textBox.Text[i]) || char.IsWhiteSpace(textBox.Text[i]))
                {
                    textBlock.Text = "ID dvorane sme sadrzati samo brojeve!";
                    dodaj.Visibility = Visibility.Hidden;

                    return;
                }
            }

            textBlock.Text = "";

            if (textBlock.Text == "" && textBlock1.Text == "" && textBlock2.Text == "" && textBlock3.Text == "" && textBlock4.Text == "")
                dodaj.Visibility = Visibility.Visible;
        }
       
        //MESTO
        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;

            if (textBox.Text.Length > 30)
            {
                textBlock1.Text = "Mesto dvorane ne sme biti duze od 30 karaktera!";
                dodaj.Visibility = Visibility.Hidden;

                return;
            }

            textBlock1.Text = "";

            if (textBlock.Text == "" && textBlock1.Text == "" && textBlock2.Text == "" && textBlock3.Text == "" && textBlock4.Text == "")
                dodaj.Visibility = Visibility.Visible;
        }

        //NAZIV
        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;

            if (textBox.Text.Length > 30)
            {
                textBlock2.Text = "Naziv dvorane ne sme biti duzi od 30 karaktera!";
                dodaj.Visibility = Visibility.Hidden;

                return;
            }

            textBlock2.Text = "";

            if (textBlock.Text == "" && textBlock1.Text == "" && textBlock2.Text == "" && textBlock3.Text == "" && textBlock4.Text == "")
                dodaj.Visibility = Visibility.Visible;
        }

        //ULICA
        private void textBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;

            if (textBox.Text.Length > 30)
            {
                textBlock3.Text = "Ulica dvorane ne sme biti duza od 30 karaktera!";
                dodaj.Visibility = Visibility.Hidden;

                return;
            }

            textBlock3.Text = "";

            if (textBlock.Text == "" && textBlock1.Text == "" && textBlock2.Text == "" && textBlock3.Text == "" && textBlock4.Text == "")
                dodaj.Visibility = Visibility.Visible;
        }

        //BROJ
        private void textBox4_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;

            if (textBox.Text.Length > 6)
            {
                textBlock4.Text = "Broj ulice dvorane ne sme biti duzi od 6 cifara!";
                dodaj.Visibility = Visibility.Hidden;

                return;
            }

            for (int i = 0; i < textBox.Text.Length; i++)
            {
                if (char.IsLetter(textBox.Text[i]) || char.IsPunctuation(textBox.Text[i]) || char.IsSymbol(textBox.Text[i]) || char.IsWhiteSpace(textBox.Text[i]))
                {
                    textBlock4.Text = "Broj ulice dvorane sme sadrzati samo brojeve!";
                    dodaj.Visibility = Visibility.Hidden;

                    return;
                }
            }

            textBlock4.Text = "";

            if (textBlock.Text == "" && textBlock1.Text == "" && textBlock2.Text == "" && textBlock3.Text == "" && textBlock4.Text == "")
                dodaj.Visibility = Visibility.Visible;
        }

        private void dodaj_Click(object sender, RoutedEventArgs e)
        {
            if ( textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                textBlockUspeh.Text = "Neka polja su prazna, popunite ih!";
                textBlockUspeh.Foreground = Brushes.Red;

                return;
            }

            //int id = Convert.ToInt32(textBox.Text);
            string mesto = textBox1.Text;
            string naziv = textBox2.Text;
            string ulica = textBox3.Text;
            int broj = Convert.ToInt32(textBox4.Text);
            bool prolaz = DodavanjeUBazu.DodajDvoranu(mesto, naziv, ulica, broj);
            this.Close();
          /*  if (prolaz == false)
            {
                textBlockUspeh.Text = "Vec postoji dvorana sa id-jem: " + id;
                textBlockUspeh.Foreground = Brushes.White;
            }
            else
            {
                textBlockUspeh.Text = "Uspesno ste dodali dvoranu sa id-jem: " + id;
                textBlockUspeh.Foreground = Brushes.Black;
            }
          */
        }

        private void vrati_se_Click(object sender, RoutedEventArgs e)
        {
            DvoranaView view = new DvoranaView();
            this.Close();
            view.ShowDialog();

        }
    }
}
