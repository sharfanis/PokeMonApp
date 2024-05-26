using CreateDbFromScratch.Repository;
using Microsoft.AspNetCore.Mvc;
using PokemonReviewApp.Models;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace CreateDbFromScratch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class PokemonController : Controller
    {
        private readonly PokemonRepository _pokemonRepository;

        public PokemonController(PokemonRepository pokemonRepository)
        {
            _pokemonRepository = pokemonRepository;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Pokemon>))]
        public IActionResult GetPokemons()
        {
            var pokemon = _pokemonRepository.GetPokemons();

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);

            }

            return Ok(pokemon);

        }
    }

}
