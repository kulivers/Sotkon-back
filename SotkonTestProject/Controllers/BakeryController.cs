using System.Collections.Generic;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace SotkonTestProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BakeryController : ControllerBase
    {
        private readonly IBackeryService _backeryService;

        public BakeryController(IBackeryService backeryService)
        {
            _backeryService = backeryService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var a = _backeryService.State;
            return Ok("im alive");
        }
    }
}