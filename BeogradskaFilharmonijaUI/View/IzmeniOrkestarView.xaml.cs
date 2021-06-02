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
    public partial class IzmeniOrkestarView : Window
    {
        public IzmeniOrkestarView()
        {
            InitializeComponent();
        }
        //ID
        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;

            if (textBox.Text.Length > 6)
            {
                textBlock.Text = "ID orkestra ne sme biti duzi od 6 cifara!";
                dodaj.Visibility = Visibility.Hidden;

                return;
            }

            for (int i = 0; i < textBox.Text.Length; i++)
            {
                if (char.IsLetter(textBox.Text[i]) || char.IsPunctuation(textBox.Text[i]) || char.IsSymbol(textBox.Text[i]) || char.IsWhiteSpace(textBox.Text[i]))
                {
                    textBlock.Text = "ID orkestra sme sadrzati samo brojeve!";
                    dodaj.Visibility = Visibility.Hidden;

                    return;
                }
            }

            textBlock.Text = "";
            if (textBlock.Text == "" && textBlock1.Text == "" && textBlock2.Text == "")
                dodaj.Visibility = Visibility.Visible;
        }

        //IME
        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;

            if (textBox.Text.Length > 30)
            {
                textBlock1.Text = "Ime orkestra ne sme biti duze od 30 karaktera!";
                dodaj.Visibility = Visibility.Hidden;

                return;
            }

            textBlock1.Text = "";

            if (textBlock.Text == "" && textBlock1.Text == "" && textBlock2.Text == "")
                dodaj.Visibility = Visibility.Visible;
        }

        //brclan
        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;

            if (textBox.Text.Length > 30)
            {
                textBlock2.Text = "Broj clanova ne sme biti duzi od 30 karaktera!";
                dodaj.Visibility = Visibility.Hidden;

                return;
            }

            textBlock2.Text = "";

            if (textBlock.Text == "" && textBlock1.Text == "" && textBlock2.Text == "")
                dodaj.Visibility = Visibility.Visible;
        }

        private void izmeni_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "" || textBox1.Text == "" || textBox2.Text == "")
            {
                textBlockUspeh.Text = "Neka polja su prazna, popunite ih!";
                textBlockUspeh.Foreground = Brushes.Red;

                return;
            }

            int id = Convert.ToInt32(textBox.Text);
            string ime = textBox1.Text;
            int brclan = Convert.ToInt32(textBox2.Text);

            bool prolaz = AzuriranjeUBazi.AzurirajOrkestar(id, ime, brclan);

            if (prolaz == false)
            {
                textBlockUspeh.Text = "Desila se greska!";
                textBlockUspeh.Foreground = Brushes.White;
            }
            else
            {
                textBlockUspeh.Text = "Uspesno ste izmenili orkestar sa id-jem: " + id;
                textBlockUspeh.Foreground = Brushes.Black;
            }
        }

        private void vrati_se_Click(object sender, RoutedEventArgs e)
        {
            OrkestarView view = new OrkestarView();
            this.Close();
            view.ShowDialog();
        }
    }
}
