using BeogradskaFilharmonijaUI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BeogradskaFilharmonijaUI.View
{
    public partial class PosetilacView : Window
    {
        public PosetilacView()
        {
            InitializeComponent();
            this.DataContext = new PosetilacModel(this);
        }
    }
}
