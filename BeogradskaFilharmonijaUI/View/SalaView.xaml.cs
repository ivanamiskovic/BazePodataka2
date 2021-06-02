using BeogradskaFilharmonijaUI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BeogradskaFilharmonijaUI.View
{
    public partial class SalaView : Window
    {
        public SalaView()
        {
            InitializeComponent();
            this.DataContext = new SalaModel(this);

        }
    }
}
