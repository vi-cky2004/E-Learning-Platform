using E_Learning_Platform.Interfaces;
using E_Learning_Platform.Models;

namespace E_Learning_Platform.Service
{

    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _repository;

        public AuthService(IAuthRepository repository)
        {
            _repository = repository;
        }

        public async Task<User?> LoginAsync(string email, string password)
        {
            return await _repository.LoginAsync(email, password);
        }

        public async Task<User> RegisterAsync(User user)
        {
            return await _repository.RegisterAsync(user);
        }

        public async Task<bool> EmailExistsAsync(string email)
        {
            return await _repository.EmailExistsAsync(email);
        }
    }
}
