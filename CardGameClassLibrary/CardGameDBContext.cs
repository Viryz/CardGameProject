using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameClassLibrary
{
    public class CardGameDBContext : DbContext
    {
        public CardGameDBContext() : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Александр\Desktop\ProjectCardGame\WPFCardGameApp\CardGameDatabase.mdf;Integrated Security=True") {  }

        public DbSet<Models.Cards.Card> Cards { get; set; }
        public DbSet<Models.Fraction> Fractions { get; set; }

    }
}
