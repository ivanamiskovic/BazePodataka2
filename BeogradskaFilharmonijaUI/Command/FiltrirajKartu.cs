using BeogradskaFilharmonija;
using BeogradskaFilharmonijaUI.View;
using BeogradskaFilharmonijaUI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BeogradskaFilharmonijaUI.Command
{
    //TODO DODATO
    public class FiltrirajKartu : ICommand
    {
        private KartaModel viewModel;
        private KartaView viewClose;

        public event EventHandler CanExecuteChanged;

        public FiltrirajKartu(KartaModel param, KartaView param2)
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
            string tip = viewClose.tipComboBox.Text;
            string vrednost = viewClose.filterTextBox.Text;

            switch (tip)
            {
                case "Red":
                    int red = Convert.ToInt32(vrednost);
                    viewModel.Lista = FiltrirajKarteZaRed(red);

                    break;

                case "Sediste":
                    int sediste = Convert.ToInt32(vrednost);
                    viewModel.Lista = FiltrirajKarteZaSediste(sediste);

                    break;

                case "Dan":
                    string dan = vrednost;
                    viewModel.Lista = FiltrirajKarteZaDan(dan);

                    break;

                case "Sat":
                    string sat = vrednost;
                    viewModel.Lista = FiltrirajKarteZaSat(sat);

                    break;

                case "Cena":
                    int cena = Convert.ToInt32(vrednost);
                    viewModel.Lista = FiltrirajKarteZaCena(cena);

                    break;

                default:
                    break;
            }
        }

        private List<kartaSet> FiltrirajKarteZaRed(int broj)
        {
            List<kartaSet> povratna = new List<kartaSet>();
            List<kartaSet> karte = viewModel.Lista;

            foreach (var karta in karte)
            {
                if (karta.red == broj)
                {
                    povratna.Add(karta);
                }
            }

            return povratna;
        }

        private List<kartaSet> FiltrirajKarteZaSediste(int broj)
        {
            List<kartaSet> povratna = new List<kartaSet>();
            List<kartaSet> karte = viewModel.Lista;

            foreach (var karta in karte)
            {
                if (karta.sed == broj)
                {
                    povratna.Add(karta);
                }
            }

            return povratna;
        }

        private List<kartaSet> FiltrirajKarteZaDan(string broj)
        {
            List<kartaSet> povratna = new List<kartaSet>();
            List<kartaSet> karte = viewModel.Lista;

            foreach (var karta in karte)
            {
                if (karta.daniz == broj)
                {
                    povratna.Add(karta);
                }
            }

            return povratna;
        }

        private List<kartaSet> FiltrirajKarteZaSat(string broj)
        {
            List<kartaSet> povratna = new List<kartaSet>();
            List<kartaSet> karte = viewModel.Lista;

            foreach (var karta in karte)
            {
                if (karta.satiz == broj)
                {
                    povratna.Add(karta);
                }
            }

            return povratna;
        }

        private List<kartaSet> FiltrirajKarteZaCena(int broj)
        {
            List<kartaSet> povratna = new List<kartaSet>();
            List<kartaSet> karte = viewModel.Lista;

            foreach (var karta in karte)
            {
                if (karta.cen == broj)
                {
                    povratna.Add(karta);
                }
            }

            return povratna;
        }
    }
}
