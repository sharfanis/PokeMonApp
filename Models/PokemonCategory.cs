using Microsoft.EntityFrameworkCore;
using PokemonReviewApp.Models;
using System.ComponentModel.DataAnnotations;

namespace CreateDbFromScratch.Models
{
    public class PokemonCategory
    {
        public int PokemonId { get; set; }
        public int CategoryId { get; set; }
        public Pokemon Pokemon { get; set; }
        public Category Category { get; set; }
    }
}
