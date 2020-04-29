using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Multi_MemoryGame.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CardsController : ControllerBase
    {
        [HttpGet]
        public List<Card> Get()
        {
            List<Card> Cards = new List<Card>();

            Cards.Add(new Card("Valami"));

            return Cards;
        }
    }
}
