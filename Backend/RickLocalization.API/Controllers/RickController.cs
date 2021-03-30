using Microsoft.AspNetCore.Mvc;
using RickLocalization.Application.Interface;
using RickLocalization.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace RickLocalization.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RickController : Controller
    {
        public readonly IRickAppService _rickAppService;

        public RickController(IRickAppService rickAppService)
        {
            _rickAppService = rickAppService;
        }

        [HttpGet("getrick")]
        public ActionResult Getrick(Guid id)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            return Ok(_rickAppService.GetById(id));
        }

        [HttpPost("createrick")]
        public ActionResult Create([FromBody] RickViewModel rickViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return StatusCode((int)HttpStatusCode.OK, _rickAppService.Add(rickViewModel));
        }

        [HttpPost("updaterick")]
        public ActionResult Update([FromBody] RickViewModel rickViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return StatusCode((int)HttpStatusCode.OK, _rickAppService.Update(rickViewModel));
        }              

        [HttpDelete("deleterick")]
        public ActionResult Delete(Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return StatusCode((int)HttpStatusCode.OK, _rickAppService.Delete(id));
        }

        [HttpGet("getAllMorties")]
        public IActionResult GetMorties()
        {
            if (!ModelState.IsValid)
                return BadRequest();

            return Ok(_rickAppService.List());
        }
    }
}
