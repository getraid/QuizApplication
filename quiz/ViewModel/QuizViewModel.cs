using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quiz.Command;
using quiz.Model;
namespace quiz.ViewModel
{
    public class QuizViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public QuizViewModel()
        {

        }
        #region properties
        public Dictionary<int, Frage> DictFragen { get; private set; }
        public CommandButtonOne commandButtonOne { get; set; }
        public CommandButtonTwo commandButtonTwo { get; set; }
        public CommandButtonFour commandButtonThree { get; set; }
        public QuizManager QuizManager { get; set; }
        public Frage aktiveFrage { get; set; }

        #endregion

        #region methods

        private void init() { }
        protected virtual void OnPropertyChanged() { }

        #endregion

    }
}
