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

        private Frage aktiveFrage;

        public Frage GetAktiveFrage()
        {
            return aktiveFrage;
        }

        public void SetAktiveFrage(Frage value)
        {
            aktiveFrage = value;
            //OnPropertyChanged("FrageAenderung");
        }

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

            //link eventhandler
           

            
            DictFragen = QuizManager.ErstelleFragen();

            // Erste aktive Frage ist eine zufällige Frage
            Random random = new Random();
            int randomFrage = random.Next(DictFragen.Count);

            SetAktiveFrage(DictFragen[randomFrage]);
        }

        // Used for updating the GUI, once a new question is pulled
    
        protected virtual void OnPropertyChanged(string frageaenderung)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(frageaenderung));
            //aktionen zum ausführen hier einfügen
            MessageBox.Show("debug");
        }
        
 

        #endregion

    }

}