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
        #region properties
        public event PropertyChangedEventHandler PropertyChanged;

        public QuizViewModel()
        {
            Init();
        }

        public Dictionary<int, Frage> DictFragen { get; private set; }
        public CommandButtonOne CommandButtonOne { get; set; }
        public CommandButtonTwo CommandButtonTwo { get; set; }
        public CommandButtonThree CommandButtonThree { get; set; }
        public CommandButtonFour CommandButtonFour { get; set; }
        public QuizManager QuizManager { get; set; }
        public Frage AktiveFrage { get; set; }

        #endregion

        #region methods

        private void Init()
        {
            QuizManager = new QuizManager();

            DictFragen = QuizManager.ErstelleFragen();

            // Erste aktive Frage ist eine zufällige Frage
            Random random = new Random();
            int randomFrage = random.Next(DictFragen.Count);

            AktiveFrage = DictFragen[randomFrage];
        }
        protected virtual void OnPropertyChanged()
        {

        }


        #endregion

    }

}