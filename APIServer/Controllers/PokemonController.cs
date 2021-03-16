using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace APIServer.Controllers
{

    [ApiController]
    [Route("api/pokemon")]
    public class PokemonController: ControllerBase
    {

        List<Pokemon> pokemons = new List<Pokemon>() 
        {
            new Pokemon() {Name = "Pikachu"},
            new Pokemon() {Name = "Snorlax"}
        };

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(pokemons[0]);
        }

    }
}
