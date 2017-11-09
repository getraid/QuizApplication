using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quiz.Command;
using quiz.Model;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace quiz.ViewModel
{
    /// <summary>
    /// This class ties all together
    /// </summary>
    public class QuizViewModel : INotifyPropertyChanged
    {

        #region properties

        public event PropertyChangedEventHandler PropertyChanged;
        public Dictionary<int, Frage> DictFragen { get; private set; }
        public CommandButtonOne CommandButtonOne { get; set; }
        public CommandButtonTwo CommandButtonTwo { get; set; }
        public CommandButtonThree CommandButtonThree { get; set; }
        public CommandButtonFour CommandButtonFour { get; set; }
        public QuizManager QuizManager { get; set; }

        private Frage aktiveFrage;
        public Frage AktiveFrage
        {
            get { return aktiveFrage; }
            set
            {
                aktiveFrage = value;
                //This fires the propertyChangedEvent to update the GUI
                OnPropertyChanged();
            }
        }
        #endregion

        #region constructor

        public QuizViewModel()
        {
            //Initializes all new objects
            Init();
        }
        #endregion

        #region methods

        /// <summary>
        /// Allocate all new objects, Create a random question through the QuizManager and sets it as active question(AktiveFrage)
        /// </summary>
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
            QuizManager.AktualisierungViewModelNachRichtig(this);
        }

        // Used for updating the GUI, once a new question is pulled in AktiveFrage
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

    }

}