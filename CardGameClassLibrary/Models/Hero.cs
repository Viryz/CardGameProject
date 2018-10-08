using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameClassLibrary.Models
{
    public class Hero
    {
        public Decks.Deck Deck { get; set; }
        public int Magic { get; set; }
        public List<Cards.Card> Board { get; set; }

        public Hero(Factories.HeroFactory factory)
        {

        }

    }
}
