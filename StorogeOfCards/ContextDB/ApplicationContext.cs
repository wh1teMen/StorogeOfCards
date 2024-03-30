using Microsoft.EntityFrameworkCore;
using StorogeOfCards.Model;

namespace StorogeOfCards.ContextDB
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        public DbSet<Card> Cards =>Set<Card>();
        public DbSet<Deck> Decks =>Set<Deck>();


    }
}
