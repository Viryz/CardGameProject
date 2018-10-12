using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGameClassLibrary.Models;

namespace CardGameClassLibrary.Factories
{
    public class EgyptHeroFactory : HeroFactory
    {
        public override Deck CreateDeck()
        {
            Deck deck = new Deck();
            Models.Cards.Card card;
            using (CardGameDBContext db = new CardGameDBContext())
            {
                card = db.Cards.FirstOrDefault(c => (c.IdFraction == 1) && (c as Models.Cards.SworderCard) != null);
            }
            for (int i = 0; i < 20; i++)
                deck.Cards.Add(card.Clone() as Models.Cards.Card);

            return deck;
        }
    }
}
