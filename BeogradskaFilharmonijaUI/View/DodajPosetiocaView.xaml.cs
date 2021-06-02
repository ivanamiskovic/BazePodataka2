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
    public partial class DodajPosetiocaView : Window
    {
        public DodajPosetiocaView()
        {
            InitializeComponent();

            List<kartaSet> karte = CitanjeIzBaze.VratiSlobodneKarte();

            foreach (var item in karte)
            {
                CheckBox cb = new CheckBox();
                cb.Content = "ID: " + item.br.ToString() + " , cena: " + item.cen.ToString() + " , red: " + item.red.ToString() + " , broj sedista: " + item.sed.ToString();
                cb.IsChecked = false;
                listBox.Items.Add(cb);
            }
        }

        //ID
        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;

            if (textBox.Text.Length > 6)
            {
                textBlock.Text = "ID posetioca ne sme biti duzi od 6 cifara!";
                dodaj.Visibility = Visibility.Hidden;

                return;
            }

            for (int i = 0; i < textBox.Text.Length; i++)
            {
                if (char.IsLetter(textBox.Text[i]) || char.IsPunctuation(textBox.Text[i]) || char.IsSymbol(textBox.Text[i]) || char.IsWhiteSpace(textBox.Text[i]))
                {
                    textBlock.Text = "ID posetioca sme sadrzati samo brojeve!";
                    dodaj.Visibility = Visibility.Hidden;

                    return;
                }
            }

            textBlock.Text = "";

            if (textBlock.Text == "")
                dodaj.Visibility = Visibility.Visible;
        }

        private void dodaj_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "")
            {
                textBlockUspeh.Text = "Neka polja su prazna, popunite ih!";
                textBlockUspeh.Foreground = Brushes.White;

                return;
            }

            int brojac = Convert.ToInt32(textBox.Text);

            // List<int> idKarte = PomocnaKlasa.IDListBox(listBox);

            List<int> idKarte = PomocnaKlasa.IDListBox(listBox);
            int prolaz = DodavanjeUBazu.DodajPosetioca(brojac, idKarte);

            if (prolaz == 0)
            {
                textBlockUspeh.Text = "Morate izabrati najmanje 1 kartu";
                textBlockUspeh.Foreground = Brushes.Red;
            }
            else if (prolaz == 1)
            {
                textBlockUspeh.Text = "Vec postoji posetilac sa brojacem: " + brojac;
                textBlockUspeh.Foreground = Brushes.Red;
            }
            else if (prolaz == 2)
            {
                textBlockUspeh.Text = "Uspesno ste dodali posetioca sa brojacem: " + brojac;
                textBlockUspeh.Foreground = Brushes.Green;
            }
            else
            {
                textBlockUspeh.Text = "Desila se greska!";
                textBlockUspeh.Foreground = Brushes.Red;
            }

            listBox.Items.Clear();
            List<kartaSet> karte = CitanjeIzBaze.VratiSlobodneKarte();

            foreach (var item in karte)
            {
                CheckBox cb = new CheckBox();
                cb.Content = "ID: " + item.br.ToString() + " , cena: " + item.cen.ToString() + " , red: " + item.red.ToString() + " , broj sedista: " + item.sed.ToString();
                cb.IsChecked = false;
                listBox.Items.Add(cb);
            }
        }

        private void vrati_se_Click(object sender, RoutedEventArgs e)
        {
            PosetilacView view = new PosetilacView();
            this.Close();
            view.ShowDialog();

        }
    }

}
