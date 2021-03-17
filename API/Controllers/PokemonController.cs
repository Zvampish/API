using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [ApiController]
    [Route("api/pokemon")]
    public class PokemonController: ControllerBase
    {

        static List<Pokemon> pokemons = new List<Pokemon>()
        {
            new Pokemon() {Name = "Pikachu"},
            new Pokemon() {Name = "Shroomish"}
        };

        
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(pokemons[0]);
        }

    }
}
