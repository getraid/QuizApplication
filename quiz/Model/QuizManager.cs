using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quiz.ViewModel;
using quiz.Command;
namespace quiz.Model
{
    public class QuizManager
    {
        public Dictionary<int, Frage> ErstelleFragen()
        {
            return null;
        }

        public bool BewerteAntwort(Frage aktuelleFrage, string antwort)
        {
            return false;
        }
        public void AktualisierungViewModelNachRichtig(QuizViewModel viewModel)
        {

        }

        private Frage RandomFrage()
        {
            return null;
        }
    }
}
