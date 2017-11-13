using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace quiz.ViewModel.Command
{
    public class CommandChangeType : ICommand
    {
        private QuestionCreatorViewModel ViewModel { get; set; }
        public event EventHandler CanExecuteChanged { add { } remove { } }

        public CommandChangeType(QuestionCreatorViewModel vm)
        {
            ViewModel = vm;
        }



        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ViewModel.TempFrage.KorrekteAntwort = int.Parse((string)parameter);
            MessageBox.Show(ViewModel.TempFrage.KorrekteAntwort + "");
        }
    }
}
