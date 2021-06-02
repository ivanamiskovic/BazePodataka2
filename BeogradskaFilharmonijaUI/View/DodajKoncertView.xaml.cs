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
    public partial class DodajKoncertView : Window
    {
        public DodajKoncertView()
        {
            InitializeComponent();

            List<salaSet> sale = CitanjeIzBaze.VratiSale();
            List<orkestarSet> orkestar = CitanjeIzBaze.VratiOrkestre();
            List<sef_dirigentSet> sef_dirigent = CitanjeIzBaze.Vratisefadirigenta();

            foreach (var item in sale)
            {
                CheckBox cb = new CheckBox();
                cb.Content = "ID: " + item.idsal.ToString() ;
                cb.IsChecked = false;
                listBox.Items.Add(cb);
            }

            foreach (var item in orkestar)
            {
                CheckBox cb = new CheckBox();
                cb.Content = "ID: " + item.id.ToString() + " , " + item.imeork + " " + item.brclan;
                cb.IsChecked = false;
                listBox1.Items.Add(cb);
            }

            foreach (var item in sef_dirigent)
            {
                CheckBox cb = new CheckBox();
                cb.Content = "ID: " + item.iddir.ToString() + " , " + item.imed + " " + item.prezdir;
                cb.IsChecked = false;
                listBox2.Items.Add(cb);
            }
        }

        //ID
        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;

            if (textBox.Text.Length > 6)
            {
                textBlock.Text = "ID koncerta ne sme biti duzi od 6 cifara!";
                dodaj.Visibility = Visibility.Hidden;

                return;
            }

            for (int i = 0; i < textBox.Text.Length; i++)
            {
                if (char.IsLetter(textBox.Text[i]) || char.IsPunctuation(textBox.Text[i]) || char.IsSymbol(textBox.Text[i]) || char.IsWhiteSpace(textBox.Text[i]))
                {
                    textBlock.Text = "ID koncerta sme sadrzati samo brojeve!";
                    dodaj.Visibility = Visibility.Hidden;

                    return;
                }
            }

            textBlock.Text = "";

            if (textBlock.Text == "" && textBlock1.Text == "" && textBlock2.Text == "" && textBlock3.Text == "")
                dodaj.Visibility = Visibility.Visible;
        }

        //TRAJANJE
        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;

            if (textBox.Text.Length > 3)
            {
                textBlock1.Text = "Trajanje koncerta ne sme biti duzi od 999 minuta!";
                dodaj.Visibility = Visibility.Hidden;

                return;
            }

            for (int i = 0; i < textBox.Text.Length; i++)
            {
                if (char.IsLetter(textBox.Text[i]) || char.IsPunctuation(textBox.Text[i]) || char.IsSymbol(textBox.Text[i]) || char.IsWhiteSpace(textBox.Text[i]))
                {
                    textBlock1.Text = "ID koncerta sme sadrzati samo brojeve!";
                    dodaj.Visibility = Visibility.Hidden;

                    return;
                }
            }

            textBlock1.Text = "";

            if (textBlock.Text == "" && textBlock1.Text == "" && textBlock2.Text == "" && textBlock3.Text == "")
                dodaj.Visibility = Visibility.Visible;
        }
        //NAZIV
        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;

            if (textBox.Text.Length > 30)
            {
                textBlock2.Text = "Naziv koncerta ne sme biti duze od 30 karaktera!";
                dodaj.Visibility = Visibility.Hidden;

                return;
            }

            textBlock2.Text = "";

            if (textBlock.Text == "" && textBlock1.Text == "" && textBlock2.Text == "" && textBlock3.Text == "")
                dodaj.Visibility = Visibility.Visible;
        }

        //ZANR
        private void textBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;

            if (textBox.Text.Length > 30)
            {
                textBlock3.Text = "Zanr koncerta ne sme biti duzi od 30 karaktera!";
                dodaj.Visibility = Visibility.Hidden;

                return;
            }

            textBlock3.Text = "";

            if (textBlock.Text == "" && textBlock1.Text == "" && textBlock2.Text == "" && textBlock3.Text == "")
                dodaj.Visibility = Visibility.Visible;
        }

        private void dodaj_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "" || textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                textBlockUspeh.Text = "Neka polja su prazna, molim vas popunite ih!";
                textBlockUspeh.Foreground = Brushes.Red;

                return;
            }

            int id = Convert.ToInt32(textBox.Text);
            int trajanje = Convert.ToInt32(textBox1.Text);
            string naziv = textBox2.Text;
            string zanr = textBox3.Text;

            List<int> idSale = PomocnaKlasa.IDListBox(listBox);
            List<int> idOrkestar = PomocnaKlasa.IDListBox(listBox1);
            List<int> idSefdirigient = PomocnaKlasa.IDListBox(listBox2);

            int prolaz = DodavanjeUBazu.DodajKoncert(id, trajanje, naziv, zanr, idSale, idOrkestar, idSefdirigient);

            if (prolaz == 0)
            {
                textBlockUspeh.Text = "Morate izabrati najmanje 1 salu";
                textBlockUspeh.Foreground = Brushes.White;
            }
            else if (prolaz == 1)
            {
                textBlockUspeh.Text = "Morate izabrati namanje 1 orkestar";
                textBlockUspeh.Foreground = Brushes.White;
            }
            else if (prolaz == 2)
            {
                textBlockUspeh.Text = "Morate izabrati najmanje 1 sefa dirigenta";
                textBlockUspeh.Foreground = Brushes.White;
            }
            else if (prolaz == 3)
            {
                textBlockUspeh.Text = "Vec postoji koncert sa id-jem: " + id;
                textBlockUspeh.Foreground = Brushes.White;
            }
            else if (prolaz == 4)
            {
                textBlockUspeh.Text = "Desila greska!";
                textBlockUspeh.Foreground = Brushes.White;
            }
            else
            {
                textBlockUspeh.Text = "Uspesno ste dodali koncerta sa id-jem: " + id;
                textBlockUspeh.Foreground = Brushes.Black;
            }
        }

        private void vrati_se_Click(object sender, RoutedEventArgs e)
        {
            KoncertView view = new KoncertView();
            this.Close();
            view.ShowDialog();

        }
    }
}
