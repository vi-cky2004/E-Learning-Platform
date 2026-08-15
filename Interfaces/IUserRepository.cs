using E_Learning_Platform.Data;
using E_Learning_Platform.Models;

namespace E_Learning_Platform.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllUsersAsync();

        Task<User?> GetUserByIdAsync(int id);

        Task<User> AddUserAsync(User user);

        Task<User> UpdateUserAsync(User user);

        Task<bool> DeleteUserAsync(int id);

    }
}
