using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

        [HttpGet("GetMovies")]
        public IActionResult GetActorsWithMovies()
        {
            return Ok(_unitofwork.Actor.GetActorWithMovies());
        }
    }
}
