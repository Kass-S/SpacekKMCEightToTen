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
    public class EightBallController : ControllerBase
    {
        private readonly EightBallService _eightBallService;

        public EightBallController(EightBallService eightBallService){
            _eightBallService = eightBallService;
        }

        [HttpGet]
        [Route("magic/{question}")]

        public string EightBall(string question){
            return _eightBallService.EightBall(question);
        }
    }
}