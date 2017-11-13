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
        [Obsolete]
        public Dictionary<int, Frage> ErstelleFragen()
        {
            Dictionary<int, Frage> i = new Dictionary<int, Frage>
            {
                 {0, new Frage("https://i.imgur.com/ReZsV6N.jpg","Was für ein Tier ist das?", "Frosch", "Antilope", "Zierlicher Widderbock", "Ameise", 4) },
                 {1, new Frage("https://i.imgur.com/FIpZXb0.jpg","Was ist das?!", "Ein Igel", "Ein Schmiegel", "Ein Kübel", "Ein Rüpel", 1) },
                 {2, new Frage("https://i.imgur.com/9slf062.jpg","Welcher Graskäfer mag das sein?", "Zierlicher Widderbock", "Grashüpfer", "Eine Gottesanbeterin ", "Eine Laugenantilope", 1) },
                 {3, new Frage("https://i.imgur.com/uITJ7gQ.jpg","Zu welchem Baum gehört das Blatt?", "Eiche", "Birke", "Buche", "Japanischer Kuchenbaum", 3) }
              };
            return i;
        }

        //Frage will be created in a list instead of a Dictonary. 
        public List<Frage> CreateFragen()
        {
            List<Frage> temp = new List<Frage>()
            {
                { new Frage("https://i.imgur.com/ReZsV6N.jpg","Was für ein Tier ist das?", "Frosch", "Antilope", "Zierlicher Widderbock", "Ameise", 4) },
                { new Frage("https://i.imgur.com/FIpZXb0.jpg","Was ist das?!", "Ein Igel", "Ein Schmiegel", "Ein Kübel", "Ein Rüpel", 1) },
                { new Frage("https://i.imgur.com/9slf062.jpg","Welcher Graskäfer mag das sein?", "Zierlicher Widderbock", "Grashüpfer", "Eine Gottesanbeterin ", "Eine Laugenantilope", 1) },
                {new Frage("https://i.imgur.com/uITJ7gQ.jpg","Zu welchem Baum gehört das Blatt?", "Eiche", "Birke", "Buche", "Japanischer Kuchenbaum", 3) }
            };
            return temp;
        }

        public void AddFragen(List<Frage> currentList, string url, string frage, string antwort1, string antwort2, string antwort3, string antwort4, int richtigeAntw)
        {
            currentList.Add(new Frage(url, frage, antwort1, antwort2, antwort3, antwort4, richtigeAntw));
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

        //Generate a random question of the list-pool
        private Frage RandomFrage(QuizViewModel viewModel)
        {

            int randomFrage = Random.Next(viewModel.FragenList.Count);

            if (TempFragenCount == randomFrage)
            {
                randomFrage++;
                if (randomFrage >= viewModel.FragenList.Count)
                {
                    randomFrage = 0;
                }
            }
            TempFragenCount = randomFrage;


            return viewModel.FragenList[randomFrage];
        }

        [Obsolete]
        private Frage LoopFrage(QuizViewModel viewModel)
        {
            TempFragenCount++;
            if (TempFragenCount == viewModel.FragenList.Count)
            {
                TempFragenCount = 0;
            }
            return viewModel.FragenList[TempFragenCount];

        }
    }
}
