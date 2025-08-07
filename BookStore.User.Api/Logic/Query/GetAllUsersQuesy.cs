using BookStore.User.Api.Domain.Model;
using BookStore.User.Api.Repository;
using BookStore.User.Api.Service;
using MediatR;

namespace BookStore.User.Api.Logic.Query
{
    public record GetAllUsersQuery() : IRequest<List<UserResponse>>;

    // QueryHandlers/GetAllUsersHandler.cs
    public class GetAllUsersHandler : IRequestHandler<GetAllUsersQuery, List<UserResponse>>
    {
        private readonly IUserService _service;
        public GetAllUsersHandler(IUserService service) => _service = service;

        public Task<List<UserResponse>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            var users = _service.GetAllUsersAsync();
            return users;
        }
    }
}
