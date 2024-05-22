using PokemonReviewApp.Models;
using System.ComponentModel.DataAnnotations;

namespace CreateDbFromScratch.Models
{
    public class PokemonOwner
    {
        [Key] 
        public int PokemonId { get; set; }

        public int OwnerId { get; set; }

        public Pokemon Pokemon { get; set; }

        public Category Category { get; set; }
    }
}
