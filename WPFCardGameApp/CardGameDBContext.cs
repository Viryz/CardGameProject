using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFCardGameApp
{
    class CardGameDBContext : DbContext
    {
        public CardGameDBContext() : base("GameCardDB") {  }

        public DbSet<Models.Cards.Card> Cards { get; set; }

    }
}
