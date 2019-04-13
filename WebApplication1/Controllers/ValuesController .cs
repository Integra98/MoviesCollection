using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Contracts;

namespace WebApplication1.Controllers

{
    [Route("api/movies")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IRepositoryWrapper _repository;

        public ValuesController(IRepositoryWrapper repoWrapper)
        {
            _repository = repoWrapper;
        }
  
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var owners = _repository.Movie.FindAll();

                return Ok(owners);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
