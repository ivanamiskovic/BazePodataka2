using BeogradskaFilharmonija;
using BeogradskaFilharmonija.dao;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace BeogradskaFilharmonijaUI.View
{
    public partial class DodajSaluView : Window
    {
        public DodajSaluView()
        {
            InitializeComponent();

           
            List<dvoranaSet> lista = CitanjeIzBaze.VratiDvorana();

            foreach (var item in lista)
            {
                string upis = "ID: " + item.iddvor.ToString() + " , " + item.nazdv;
                comboBox1.Items.Add(upis);
            }
        }

        //ID
        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;

            if (textBox.Text.Length > 6)
            {
                textBlock.Text = "ID sale ne sme biti duzi od 6 cifara!";
                dodaj.Visibility = Visibility.Hidden;

                return;
            }

            for (int i = 0; i < textBox.Text.Length; i++)
            {
                if (char.IsLetter(textBox.Text[i]) || char.IsPunctuation(textBox.Text[i]) || char.IsSymbol(textBox.Text[i]) || char.IsWhiteSpace(textBox.Text[i]))
                {
                    textBlock.Text = "ID sale sme sadrzati samo brojeve!";
                    dodaj.Visibility = Visibility.Hidden;

                    return;
                }
            }

            textBlock.Text = "";

            if (textBlock.Text == "" && textBlock1.Text == "" && textBlock2.Text == "")
                dodaj.Visibility = Visibility.Visible;
        }

        //BROJ SEDISTA
        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;

            if (textBox1.Text.Length > 4)
            {
                textBlock1.Text = "Broj sedista sale ne sme biti duzi od 4 cifara!";
                dodaj.Visibility = Visibility.Hidden;

                return;
            }

            for (int i = 0; i < textBox.Text.Length; i++)
            {
                if (char.IsLetter(textBox.Text[i]) || char.IsPunctuation(textBox.Text[i]) || char.IsSymbol(textBox.Text[i]) || char.IsWhiteSpace(textBox.Text[i]))
                {
                    textBlock1.Text = "ID sale sme sadrzati samo brojeve!";
                    dodaj.Visibility = Visibility.Hidden;

                    return;
                }
            }

            textBlock1.Text = "";

            if (textBlock.Text == "" && textBlock1.Text == "" && textBlock2.Text == "")
                dodaj.Visibility = Visibility.Visible;
        }

        //VELICINA scene
        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;

            if (textBox2.Text.Length > 4)
            {
                textBlock2.Text = "Velicina scene ne sme biti duzi od 4 cifara!";
                dodaj.Visibility = Visibility.Hidden;

                return;
            }

            for (int i = 0; i < textBox.Text.Length; i++)
            {
                if (char.IsLetter(textBox.Text[i]) || char.IsPunctuation(textBox.Text[i]) || char.IsSymbol(textBox.Text[i]) || char.IsWhiteSpace(textBox.Text[i]))
                {
                    textBlock2.Text = "ID sale sme sadrzati samo brojeve!";
                    dodaj.Visibility = Visibility.Hidden;

                    return;
                }
            }

            textBlock2.Text = "";

            if (textBlock.Text == "" && textBlock1.Text == "" && textBlock2.Text == "")
                dodaj.Visibility = Visibility.Visible;
        }
        //dodaj
        private void dodaj_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.Text == "" || comboBox1.Text == "")
            {
                textBlockUspeh.Text = "Neka polja su prazna, molim vas popunite ih!";
                textBlockUspeh.Foreground = Brushes.White;

                return;
            }

           // int id = Convert.ToInt32(textBox.Text);
            int sedista = Convert.ToInt32(textBox1.Text);
            string scena = textBox2.Text;
            string dvorana = comboBox1.Text;

            string[] reci = dvorana.Split(' ');
            int idDvorane = Convert.ToInt32(reci[1]);

            bool prolaz = DodavanjeUBazu.DodajSalu(sedista, scena, idDvorane);
            this.Close();

        }
        //vrati se
        private void vrati_se_Click(object sender, RoutedEventArgs e)
        {
            SalaView view = new SalaView();
            this.Close();
            view.ShowDialog();

        }
    }
}
