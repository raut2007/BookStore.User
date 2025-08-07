using BookStore.User.Api.Domain.Model;

namespace BookStore.User.Api.Repository
{
    public class UserRepository: IUserRepository
    {
        public Task<int> AddUserAsync(UserModel user)
        {
            throw new NotImplementedException();
        }

        public async Task<List<UserResponse>> GetAllUsersAsync()
        {
            var activeUsers = UserList.Users
            .Where(u => u.IsActive && !u.IsDeleted)
            .Select(u => new UserResponse
            {
                Id = u.Id,
                Name = u.FirstName + " "+ u.LastName
            })
            .ToList();
    
            return activeUsers;
        }

        public Task<UserResponse> GetUserByIdAsync()
        {
            throw new NotImplementedException();
        }
    }
}
