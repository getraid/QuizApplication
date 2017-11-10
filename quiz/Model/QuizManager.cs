using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quiz.ViewModel;
using quiz.Command;
using System.Windows;

namespace quiz.Model
{
    /// <summary>
    /// Handles basic tasks around the Dictonary and the Fragen/questions.
    /// </summary>
    public class QuizManager
    {
        #region properties

        private Random Random { get; set; }
        private int TempFragenCount { get; set; }
        #endregion
        #region constructor

        public QuizManager()
        {
            Random = new Random();
            TempFragenCount = 0;
        }
        #endregion


        #region methods
        #endregion

        //Only for testing
        //Maybe later the questions can be made in an external file.
        public Dictionary<int, Frage> ErstelleFragen()
        {
            Dictionary<int, Frage> i = new Dictionary<int, Frage>
            {
                { 0, new Frage("https://goo.gl/EyKHvw","Wie heißt diese Kadse", "Peter", "Uwe", "Gertrud", "Der Diktator", 4) },
                { 1, new Frage("https://dw.getraid.com/file/wtvr.jpg","Was ist das für ein Tier", "Ein Igel", "Ein Schmiegel", "Ein Kübel", "Ein Rüpel", 1) }
              };
            return i;
        }


        //Compares if the questionanswer equals the button-content.
        public bool BewerteAntwort(Frage aktuelleFrage, int antwort)
        {
            return aktuelleFrage.KorrekteAntwort == antwort ? true : false;
        }

        public void AktualisierungViewModelNachRichtig(QuizViewModel viewModel)
        {
            viewModel.AktiveFrage = RandomFrage(viewModel);
        }

        //Generate a random question of the Dictonary-pool
        private Frage RandomFrage(QuizViewModel viewModel)
        {

            int randomFrage = Random.Next(viewModel.DictFragen.Count);

            // Saving last Frage doesn't seem to work. Needs fix.

            //if (viewModel.LetzterFragenSchlüssel == randomFrage)
            //{
            //    RandomFrage(viewModel);
            //}
            //else
            //{
            //    viewModel.LetzterFragenSchlüssel = randomFrage;
            //}

            return viewModel.DictFragen[randomFrage];
        }

        [Obsolete]
        private Frage LoopFrage(QuizViewModel viewModel)
        {
            TempFragenCount++;
            if (TempFragenCount == viewModel.DictFragen.Count)
            {
                TempFragenCount = 0;
            }
            return viewModel.DictFragen[TempFragenCount];

        }
    }
}
