using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpacekKMCEightToTen.Services;

namespace SpacekKMCEightToTen.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GuessItController : ControllerBase
    {
        private readonly GuessItService _guessItService;

        public GuessItController(GuessItService guessItService){
            _guessItService = guessItService;
        }

        [HttpGet]
        [Route("Easy/{easyUserGuess}")]

        public string GuessItEasy(string easyUserGuess)
        {
            return _guessItService.GuessItEasy(easyUserGuess);
        }
    }
}