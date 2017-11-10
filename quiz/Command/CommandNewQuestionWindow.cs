﻿using quiz.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace quiz.Command
{
    public class CommandNewQuestionWindow : ICommand
    {
        public QuizViewModel viewModel;
        public event EventHandler CanExecuteChanged { add { } remove { } }
        public CommandNewQuestionWindow(QuizViewModel viewModel)
        {
            this.viewModel = viewModel;
        }


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



            qc.Show();
        }
    }
}
