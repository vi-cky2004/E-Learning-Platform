using E_Learning_Platform.Models;

namespace E_Learning_Platform.Interfaces
{
    public interface IAuthService
    {
        Task<User?> LoginAsync(string email, string password);

        Task<User> RegisterAsync(User user);

        Task<bool> EmailExistsAsync(string email);
    }
}
