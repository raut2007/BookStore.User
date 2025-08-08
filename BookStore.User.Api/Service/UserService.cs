using BookStore.User.Api.Domain.Model;
using BookStore.User.Api.Repository;

namespace BookStore.User.Api.Service
{
    public class UserService : IUserService
    {

        private readonly IUserRepository _repo;
        public UserService(IUserRepository repo) => _repo = repo;

        public Task<int> AddUserAsync(UserModel user)
        {
            throw new NotImplementedException();
        }

        public async Task<List<UserResponse>> GetAllUsersAsync()
        {
           return await _repo.GetAllUsersAsync();
        }

        public Task<UserResponse> GetUserByIdAsync()
        {
            throw new NotImplementedException();
        }
    }
}
