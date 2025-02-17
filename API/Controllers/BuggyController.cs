using Microsoft.AspNetCore.Mvc;
namespace API.Controllers
{
    public class BuggyController : BaseApiController
    {
        [HttpGet("not-found")]
        public IActionResult GetNotFound()
        {
            return NotFound();
        }
        [HttpGet("bad-request")]
        public IActionResult GetBadRequest()
        {
            return BadRequest("This was not a good request");
        }
        [HttpGet("unauthorized")]
        public IActionResult GetUnauthorized()
        {
            return Unauthorized();
        }
        [HttpGet("validation-error")]
        public IActionResult GetValidationError()
        {
            ModelState.AddModelError("Problem1", "This is first error");
            ModelState.AddModelError("Problem2", "This is second error");
            return ValidationProblem();
        }
        [HttpGet("server-error")]
        public IActionResult GetServerError()
        {
            throw new Exception("This is some server error");
        }
    }
}