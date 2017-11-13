using quiz.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz.Model
{
    public static class HandleToggle
    {
        public static void AddAnswerToggleToTempFrage(Frage TempFrage, AnswerToggle AnswerToggle)
        {
            int i = TurnTogglesToNumber(AnswerToggle);
            try
            {
                TempFrage.AddKorrekteAntwort(i);
            }
            catch (Exception)
            {
                throw;
            }
           
        }

        private static int TurnTogglesToNumber(AnswerToggle AnswerToggle)
        {
            if (AnswerToggle.ToggleAnswer1)
            {
                return 1;
            }
            else if (AnswerToggle.ToggleAnswer2)
            {
                return 2;
            }
            else if (AnswerToggle.ToggleAnswer3)
            {
                return 3;
            }
            else if (AnswerToggle.ToggleAnswer4)
            {
                return 4;
            }
            else
            {
                return 0;
            }

        }



    }

}
