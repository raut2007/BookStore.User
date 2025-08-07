using BookStore.User.Api.Domain;
using BookStore.User.Api.Domain.Model;
using BookStore.User.Api.Logic.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookStore.User.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UserController(IMediator mediator) => _mediator = mediator;

        [HttpGet("all")]
        public async Task<IActionResult> GetAllUsers()
        {
            var result = await _mediator.Send(new GetAllUsersQuery());
            return Ok(new Response<List<UserResponse>>(result != null, result,  result.Count == 0 ? "No data found" : ""));
        }
    }
}
