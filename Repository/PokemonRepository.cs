using CreateDbFromScratch.Data;
using CreateDbFromScratch.Interfaces;
using Microsoft.EntityFrameworkCore;
using PokemonReviewApp.Models;

namespace CreateDbFromScratch.Repository
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly SchoolContext _context;

        public PokemonRepository(SchoolContext context)
        {
            _context = context;
        }

        public ICollection<Pokemon> GetPokemons()
        {
            return _context.Pokemons.OrderBy(p => p.Id).ToList();
        }
    }
}
