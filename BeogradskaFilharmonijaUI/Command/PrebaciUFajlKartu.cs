using BeogradskaFilharmonija;
using BeogradskaFilharmonijaUI.View;
using BeogradskaFilharmonijaUI.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Serialization;

namespace BeogradskaFilharmonijaUI.Command
{
    //TODO DODATO
    public class PrebaciUFajlKartu : ICommand
    {
        private KartaModel viewModel;
        private KartaView viewClose;

        public event EventHandler CanExecuteChanged;

        public PrebaciUFajlKartu(KartaModel param, KartaView param2)
        {
            this.viewModel = param;
            this.viewClose = param2;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            //TODO PREPRAVITI KOD SEBE NA KOMPU
            string putanja = @"C:\Users\Ivana\Desktop\NE BRISI\BeogradskaFilharmonija\ispis.txt";

            using (TextWriter tw = new StreamWriter(putanja, false))
            {
                foreach (var karta in viewModel.Lista)
                {
                    tw.WriteLine($"Karta => ID: {karta.br}, Red: {karta.red}, Sediste: {karta.sed}, Dan: {karta.daniz}, Sat: {karta.satiz}, Cena: {karta.cen}");
                }
                tw.Close();

            }
        }
    }
}
