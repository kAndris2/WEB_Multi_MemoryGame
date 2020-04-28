using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multi_MemoryGame
{
    public class Card
    {
        public String Face { get; set; }
        public String Back 
        {
            get { return "back fas fa-question fa-10x"; }
            private set { }
        }

        public Card(string face)
        {
            Face = face;
        }
    }
}
