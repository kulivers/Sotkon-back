using System;
using System.Collections.Generic;
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

        [HttpGet]
        public IActionResult Get()
        {
            var a = _backeryService.State;
            return Ok(a);
        }
        
        [HttpPost]
        public IActionResult MakeStep()
        {
            _backeryService.MakeStep(new TimeSpan(1,0,0));
            return Ok();
        }
    }
}