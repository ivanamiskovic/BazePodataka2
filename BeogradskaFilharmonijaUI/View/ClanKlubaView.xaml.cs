using BeogradskaFilharmonijaUI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BeogradskaFilharmonijaUI.View
{
    public partial class ClanKlubaView : Window
    {
        public ClanKlubaView()
        {
            InitializeComponent();
            this.DataContext = new ClanKlubaModel(this);
        }
    }
}
