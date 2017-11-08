using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using quiz.ViewModel;

namespace quiz.Command
{
    public class CommandButtonFour : ICommand
    {
        public QuizViewModel ViewModel { get; set; }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
        public CommandButtonFour(QuizViewModel viewModel)
        {
            this.ViewModel = viewModel;
        }
    }
}
