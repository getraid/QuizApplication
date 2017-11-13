using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using quiz.ViewModel;
using System.Diagnostics;
using quiz.Model;

namespace quiz.Command
{
    public class CommandCreateNewQuestion : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public QuestionCreatorViewModel QuestionCreatorViewModel { get; set; }
        public Frage TempFrage { get; set; }

        public CommandCreateNewQuestion(QuestionCreatorViewModel qc)
        {
            QuestionCreatorViewModel = qc;
            TempFrage = QuestionCreatorViewModel.TempFrage;
        }

        public bool CanExecute(object parameter)
        {
            //Todo write checks to enable the button. If tempfrage isnt filled out yet
            return true;
        }

        public void Execute(object parameter)
        {
            //volle frage erstellen
            HandleToggle.AddAnswerToggleToTempFrage(QuestionCreatorViewModel.TempFrage,QuestionCreatorViewModel.AnswerToggle);
            QuestionCreatorViewModel.FragenList.Add(QuestionCreatorViewModel.TempFrage);
            QuestionCreatorViewModel.TempFrage = null;
            QuestionCreatorViewModel.TempFrage = new Frage();
            QuestionCreatorViewModel.AnswerToggle = null;
            QuestionCreatorViewModel.AnswerToggle = new AnswerToggle();
        }
    }
}
