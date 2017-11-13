using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz.ViewModel
{
    /// <summary>
    /// A question. This is the core-structure of a question.
    /// It has one picture, 4 answers and one correct answer
    /// </summary>
    [Serializable]
    public class Frage
    {
        public string BildUri { get; set; }
        public string FrageStellung { get; set; } 
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string Name3 { get; set; }
        public string Name4 { get; set; }
        public int KorrekteAntwort { get; set; }

        public Frage() { }

        public Frage(string BildUri, string FrageStellung, string Name1, string Name2, string Name3, string Name4, int KorrekteAntwort)
        {
            this.BildUri = BildUri;
            this.FrageStellung = FrageStellung;
            this.Name1 = Name1;
            this.Name2 = Name2;
            this.Name3 = Name3;
            this.Name4 = Name4;
            this.KorrekteAntwort = KorrekteAntwort;
        }

        public void AddKorrekteAntwort(int korrekteAnt)
        {
            KorrekteAntwort = korrekteAnt;
        }
    }
}
