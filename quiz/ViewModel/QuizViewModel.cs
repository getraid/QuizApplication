using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quiz.Command;
using quiz.Model;
using System.Windows.Forms;

namespace quiz.ViewModel
{
    /// <summary>
    /// This class handels all 
    /// </summary>
    public class QuizViewModel : INotifyPropertyChanged
    {
        #region constructor

        public QuizViewModel()
        {
            Init();
        }
        #endregion

        #region properties

        public event PropertyChangedEventHandler PropertyChanged;
        public Dictionary<int, Frage> DictFragen { get; private set; }
        public CommandButtonOne CommandButtonOne { get; set; }
        public CommandButtonTwo CommandButtonTwo { get; set; }
        public CommandButtonThree CommandButtonThree { get; set; }
        public CommandButtonFour CommandButtonFour { get; set; }
        public QuizManager QuizManager { get; set; }

        // Can't get the AktiveFrage { get; set; } to be opened/extended to write the OnPropertyChanged("somethingChanged") on set.
        // GUI won't work with expanding it like: https://dw.getraid.com/file/pnbv.txt
        public Frage AktiveFrage { get; set; }

        #endregion

        #region methods

        private void Init()
        {
            //init new objs

            CommandButtonOne = new CommandButtonOne(this);
            CommandButtonTwo = new CommandButtonTwo(this);
            CommandButtonThree = new CommandButtonThree(this);
            CommandButtonFour = new CommandButtonFour(this);
            QuizManager = new QuizManager();

            //Generates all questions and puts them in DictFragen Dictonary
            DictFragen = QuizManager.ErstelleFragen();

            // First question is random.
            AktiveFrage = QuizManager.RandomFrage(this);
        }

        // Used for updating the GUI, once a new question is pulled
        // Not working, because of unchangablity of AktiveFrage.
        protected virtual void OnPropertyChanged(string fix)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(fix));
            MessageBox.Show("debug");
           
        }

        #endregion

    }

}