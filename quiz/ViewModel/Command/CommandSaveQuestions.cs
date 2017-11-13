﻿using quiz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace quiz.ViewModel.Command
{
    public class CommandSaveQuestions : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public QuizViewModel QuizViewModel { get; set; }

        public List<Frage> List { get; set; }

        public CommandSaveQuestions(QuizViewModel quizViewModel)
        {
            QuizViewModel = quizViewModel;
            List = QuizViewModel.FragenList;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {

          
        }
    }
}
