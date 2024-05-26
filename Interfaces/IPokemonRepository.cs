using PokemonReviewApp.Models;

namespace CreateDbFromScratch.Interfaces
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();

    }
}
