using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviesManagement.DataAccess.Context;
using MoviesManagement.Domain.Entities;
using MoviesManagement.Domain.Repository;
using System.Data;

namespace MoviesManagemet.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        private readonly IUnitOfWorkRepository _unitofwork;
        private readonly MoviesManagementDbContext _context;

        public ActorController(IUnitOfWorkRepository unitofwork, MoviesManagementDbContext context)
        {
            _unitofwork = unitofwork;
            _context = context;
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
