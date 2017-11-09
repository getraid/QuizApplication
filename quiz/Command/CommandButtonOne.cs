using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using quiz.ViewModel;
using System.Diagnostics;

namespace quiz.Command
{
    public class CommandButtonOne : ICommand
    {
        #region properties

        public QuizViewModel ViewModel { get; set; }
        public event EventHandler CanExecuteChanged { add { } remove { } }
        #endregion
        #region constructor

        public CommandButtonOne(QuizViewModel viewModel)
        {
            this.ViewModel = viewModel;
        }
        #endregion

        #region methods


        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Debug.Print(parameter.ToString());

            if (ViewModel.QuizManager.BewerteAntwort(ViewModel.AktiveFrage, (string)parameter))
            {
                ViewModel.QuizManager.AktualisierungViewModelNachRichtig(ViewModel);
            }
            else
            {
                //show wrong
            }
        }
        #endregion


    }
}
