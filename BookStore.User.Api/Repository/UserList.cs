using BookStore.User.Api.Domain.Model;

namespace BookStore.User.Api.Repository
{
    public class UserList
    {
            public static List<UserModel> Users = new List<UserModel>()
            { 
                new UserModel { Id = 101,FirstName = "Vishal", LastName="Raut", IsActive = true, IsDeleted=false, CreatedBy = 1, CreatedDate = DateTime.Now, UpdatedBy = 1, UpdatedDate = DateTime.Now },
                new UserModel { Id = 102,FirstName = "Amol", LastName="More", IsActive = true, IsDeleted=false, CreatedBy = 1, CreatedDate = DateTime.Now, UpdatedBy = 1, UpdatedDate = DateTime.Now },
                new UserModel { Id = 103,FirstName = "ABCD", LastName="EFG", IsActive = true, IsDeleted=false, CreatedBy = 1, CreatedDate = DateTime.Now, UpdatedBy = 1, UpdatedDate = DateTime.Now },
            };
    }
}
