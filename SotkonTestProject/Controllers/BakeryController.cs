using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace SotkonTestProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BakeryController : ControllerBase
    {
        private readonly IBackeryService _backeryService;

        public BakeryController(IBackeryService backeryService)
        {
            _backeryService = backeryService;
        }


        [HttpGet("init")]
        public async Task Init()
        {
            await _backeryService.InitRandomBans();
            Ok();
        }

        [HttpGet]
        public async Task<IEnumerable<Ban>> Get() => await _backeryService.GetBans();

        [HttpPost]
        public IActionResult MakeStep()
        {
            _backeryService.MakeStepGetNextState(new TimeSpan(1,0,0));
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteAllBans()
        {
            await _backeryService.DeleteAllBans();
            return Ok();
        }
    }
}