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
        public CommandButtonOne CommandButtonOne { get; set; }
        public CommandButtonTwo CommandButtonTwo { get; set; }
        public CommandButtonFour CommandButtonThree { get; set; }
        public QuizManager QuizManager { get; set; }
        public Frage AktiveFrage { get; set; }

        #endregion

        #region methods

        private void Init() { }
        protected virtual void OnPropertyChanged() { }

        #endregion

    }
}
