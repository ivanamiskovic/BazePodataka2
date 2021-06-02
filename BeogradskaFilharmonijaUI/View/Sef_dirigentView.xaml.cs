using BeogradskaFilharmonijaUI.Command;
using BeogradskaFilharmonijaUI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BeogradskaFilharmonijaUI.View
{
    public partial class Sef_dirigentView : Window
    {
        public Sef_dirigentView()
        {
            InitializeComponent();
            this.DataContext = new Sef_dirigentModel(this);
        }
    }
}
