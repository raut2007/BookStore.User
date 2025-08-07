using BookStore.User.Api.Domain.Model;

namespace BookStore.User.Api.Service
{
    public interface IUserService
    {
        Task<List<UserResponse>> GetAllUsersAsync();
        Task<UserResponse> GetUserByIdAsync();
        Task<int> AddUserAsync(UserModel user);
    }
}
