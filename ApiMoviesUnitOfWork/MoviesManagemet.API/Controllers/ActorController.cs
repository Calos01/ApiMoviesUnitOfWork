using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviesManagement.Domain.Entities;
using MoviesManagement.Domain.Repository;

namespace MoviesManagemet.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        private readonly IUnitOfWorkRepository _unitofwork;

        public ActorController(IUnitOfWorkRepository unitofwork)
        {
            _unitofwork = unitofwork;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_unitofwork.Actor.GetAll());
            //return Ok(_unitofwork.Movie.GetAll());
        }

        //[HttpGet("GetMovies")]
        //public IActionResult GetActorsWithMovies()
        //{
        //    return Ok(_unitofwork.Actor.GetActorWithMovies());
        //}

        [HttpGet("GetMoviesActor")]
        public IActionResult GetMoviesWithActor()
        {
            return Ok(_unitofwork.Movie.GetMoviesWithActor());
        }

        [HttpPost("AddActor")]
        public IActionResult AddActor(Actor actor)
        {
            if (actor != null)
            {
                _unitofwork.Actor.Add(actor);
                _unitofwork.Save();
                return Ok("Insertado");
            }
            return BadRequest();
        }
    }
}
