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
    public class CommandAnswer : ICommand
    {
        #region properties

        public QuizViewModel ViewModel { get; set; }
        public event EventHandler CanExecuteChanged { add { } remove { } }
        #endregion
        #region constructor

        public CommandAnswer(QuizViewModel viewModel)
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
            string param = (string)parameter;

            if (ViewModel.QuizManager.BewerteAntwort(ViewModel.AktiveFrage, int.Parse(parameter.ToString())))
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
