﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz.ViewModel
{
    public class Frage
    {
        public string BildUri { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string Name3 { get; set; }
        public string Name4 { get; set; }
        public string KorrekteAntworten { get; set; }

        public Frage(string BildUri, string Name1, string Name2, string Name3, string Name4, string KorrekteAntworten)
        {
            this.BildUri = BildUri;
            this.Name1 = Name1;
            this.Name2 = Name2;
            this.Name3 = Name3;
            this.Name4 = Name4;
            this.KorrekteAntworten = KorrekteAntworten;
        }
    }
}