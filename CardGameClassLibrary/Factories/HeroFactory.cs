using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameClassLibrary.Factories
{
    public abstract class HeroFactory
    {
        public abstract Models.Decks.Deck CreateDeck();
    }
}
