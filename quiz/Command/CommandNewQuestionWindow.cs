using quiz.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace quiz.Command
{
    public class CommandNewQuestionWindow : ICommand
    {
        #region properties

        public QuizViewModel viewModel;
        public event EventHandler CanExecuteChanged { add { } remove { } }

        public delegate void TransferViewModel(QuizViewModel Data);
        public static event TransferViewModel NotifyVMReady;

        #endregion
        #region constructor

        public CommandNewQuestionWindow(QuizViewModel viewModel)
        {
            this.viewModel = viewModel;
        }
        #endregion

        #region methods


        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            // Need to share viewmodel or at least question list<Frage> between two forms. 
            QuestionCreator qc = new QuestionCreator
            {
                DataContext = this.viewModel
            };

            RaiseEvent();

            qc.Show();
        }

        protected virtual void RaiseEvent()
        {
            NotifyVMReady?.DynamicInvoke(viewModel);
        }

        #endregion
    }
}
