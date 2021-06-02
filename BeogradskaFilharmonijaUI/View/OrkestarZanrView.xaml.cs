using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace BeogradskaFilharmonijaUI.View
{
    public partial class OrkestarZanrView : Window
    {
        public OrkestarZanrView()
        {
            InitializeComponent();
        }

        //ZANR
        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;

            if (textBox.Text.Length > 30)
            {
                textBlock.Text = "Ime zanra ne sme biti duze od 30 karaktera!";
                pronadji.Visibility = Visibility.Hidden;

                return;
            }

            textBlock.Text = "";

            if (textBlock.Text == "")
                pronadji.Visibility = Visibility.Visible;
        }
        //pronadji
        private void pronadji_Click(object sender, RoutedEventArgs e)
        {

            if (textBox.Text == "")
            {
                textBlock1.Text = "Neka polja su prazna, popunite ih!";

                return;
            }

            string zanr = textBox.Text;

        }
    }
}
