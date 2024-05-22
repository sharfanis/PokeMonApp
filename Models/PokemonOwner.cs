using PokemonReviewApp.Models;

namespace CreateDbFromScratch.Models
{
    public class PokemonOwner
    {
        public int PokemonId { get; set; }

        public int OwnerId { get; set; }

        public Pokemon Pokemon { get; set; }

        public Category Category { get; set; }
    }
}
