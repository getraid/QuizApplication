using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz.Model
{
    [Serializable]
   public class AnswerToggle
    {
        public bool ToggleAnswer1 { get; set; }
        public bool ToggleAnswer2 { get; set; }
        public bool ToggleAnswer3 { get; set; }
        public bool ToggleAnswer4 { get; set; }

        public AnswerToggle()
        {
            ToggleAnswer1 = true;
            ToggleAnswer2 = false;
            ToggleAnswer3 = false;
            ToggleAnswer4 = false;
        }
    }
}
