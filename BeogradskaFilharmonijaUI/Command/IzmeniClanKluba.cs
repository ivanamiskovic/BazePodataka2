using BeogradskaFilharmonijaUI.View;
using BeogradskaFilharmonijaUI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;

namespace BeogradskaFilharmonijaUI.Command
{ 
 public class IzmeniClanKluba : ICommand
{
    private ClanKlubaModel viewModel;
    private ClanKlubaView viewClose;

    public event EventHandler CanExecuteChanged;

    public IzmeniClanKluba(ClanKlubaModel param, ClanKlubaView param2)
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
            IzmeniClanKlubaView view = new IzmeniClanKlubaView();

            if (viewModel.Izabrani == null)
            {
                viewClose.textBlockIspis.Text = "Da biste izmenili clana kluba, prvo morate izabrati jednog iz liste!";
                viewClose.textBlockIspis.Foreground = Brushes.Red;

                return;
            }
            else
            {
                view.textBox.Text = viewModel.Izabrani.sfr.ToString();
                view.textBox1.Text = viewModel.Izabrani.jmbg.ToString();
                view.textBox2.Text = viewModel.Izabrani.korime.ToString();
                view.textBox3.Text = viewModel.Izabrani.datrodj.ToString();
                view.textBox4.Text = viewModel.Izabrani.imeck.ToString();
                view.textBox5.Text = viewModel.Izabrani.prezck.ToString();

                viewClose.Close();
                view.ShowDialog();
            }
        }
    }
}
