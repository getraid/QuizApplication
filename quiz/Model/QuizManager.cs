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
            //auslagern in datei?
            Frage tempFrage = new Frage("https://goo.gl/EyKHvw", "Peter", "Uwe", "Gertrud", "Owusu", "Owusu");
            Dictionary<int, Frage> i = new Dictionary<int, Frage>();
            i.Add(1, tempFrage);
            return i;
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
