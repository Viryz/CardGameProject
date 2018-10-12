using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameClassLibrary.Models
{
    public class Deck
    {
        public List<Cards.Card> Cards { get; set; }

        private int count; // Max: 20.

        public Deck()
        {
            Cards = new List<Cards.Card>();
        }

    }
}