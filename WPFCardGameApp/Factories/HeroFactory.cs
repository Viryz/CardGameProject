using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFCardGameApp.Factories
{
    abstract class HeroFactory
    {
        public abstract Models.Decks.Deck CreateDeck();
    }
}
