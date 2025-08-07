using BookStore.User.Api.Domain.Model;

namespace BookStore.User.Api.Repository
{
    public interface IUserRepository
    {
        Task<List<UserResponse>> GetAllUsersAsync();
        Task<UserResponse> GetUserByIdAsync();
        Task<int> AddUserAsync(UserModel user);
    }
}
