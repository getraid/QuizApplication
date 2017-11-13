using quiz.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace quiz.Command
{
    public class CommandDeleteQuestion: ICommand
    {
        private QuestionCreatorViewModel ViewModel { get; set; }
        public event EventHandler CanExecuteChanged { add { } remove { } }

        public CommandDeleteQuestion(QuestionCreatorViewModel vm)
        {
            ViewModel = vm;
        }

        public bool CanExecute(object parameter)
        {
            return false;
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
