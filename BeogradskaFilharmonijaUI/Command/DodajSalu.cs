﻿using BeogradskaFilharmonijaUI.View;
using BeogradskaFilharmonijaUI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BeogradskaFilharmonijaUI.Command
{
    class DodajSalu : ICommand
    {
        private SalaModel viewModel;
        private SalaView viewClose;

        public event EventHandler CanExecuteChanged;

        public DodajSalu(SalaModel param, SalaView param2)
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
            DodajSaluView view = new DodajSaluView();
            viewClose.Close();
            view.ShowDialog();
        }
    }
}
