using Microsoft.AspNetCore.Mvc;
using RickLocalization.Application.Interface;
using RickLocalization.Application.ViewModel;
using System;
using System.Net;

namespace RickLocalization.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MortyController : Controller
    {
        public readonly IMortyAppService _mortyAppService;

        public MortyController(IMortyAppService mortyAppService)
        {
            _mortyAppService = mortyAppService;
        }

        [HttpGet("getMorty")]
        public ActionResult GetMorty(Guid id)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            return Ok(_mortyAppService.GetById(id));
        }

        [HttpPost("createMorty")]
        public ActionResult Create([FromBody] MortyViewModel mortyViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return StatusCode((int)HttpStatusCode.OK, _mortyAppService.Add(mortyViewModel));
        }

        [HttpPut("updateMorty")]
        public ActionResult Update([FromBody] MortyViewModel mortyViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return StatusCode((int)HttpStatusCode.OK, _mortyAppService.Update(mortyViewModel));
        }              

        [HttpDelete("deleteMorty")]
        public ActionResult Delete(Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return StatusCode((int)HttpStatusCode.OK, _mortyAppService.Delete(id));
        }

        [HttpGet("getAllMorties")]
        public IActionResult GetMorties()
        {
            if (!ModelState.IsValid)
                return BadRequest();

            return Ok(_mortyAppService.List());
        }       
    }
}
