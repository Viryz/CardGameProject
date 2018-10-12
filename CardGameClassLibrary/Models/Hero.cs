using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameClassLibrary.Models
{
    public class Hero
    {
        public Deck Deck { get; set; }
        public int Magic { get; set; } // Max: 7.
        public List<Cards.Card> Board { get; set; } // Max: 7.

        public Hero(Factories.HeroFactory factory)
        {
            Deck = factory.CreateDeck();
            Board = new List<Cards.Card>();
        }

    }
}
