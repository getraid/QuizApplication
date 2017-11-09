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

    {   //Only for testing
        //Maybe later the questions can be made in an external file.
        public Dictionary<int, Frage> ErstelleFragen()
        {
            Dictionary<int, Frage> i = new Dictionary<int, Frage>
            {
                { 0, new Frage("https://goo.gl/EyKHvw", "Peter", "Uwe", "Gertrud", "Owusu", "Owusu") },
                { 1, new Frage("https://dw.getraid.com/file/wtvr.jpg", "Ein Igel", "Ein Schmiegel", "Ein Kübel", "Ein Rüpel", "Ein Igel") }
              };
            return i;
        }

        //Compares if the questionanswer equals the button-content.
        public bool BewerteAntwort(Frage aktuelleFrage, string antwort)
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
            Random random = new Random();
            int randomFrage = random.Next(viewModel.DictFragen.Count);

            return viewModel.DictFragen[randomFrage];
        }
    }
}
