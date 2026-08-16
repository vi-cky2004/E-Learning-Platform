using E_Learning_Platform.Interfaces;
using E_Learning_Platform.Models;

namespace E_Learning_Platform.Service
{
    public class UserService:IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            return await _repository.GetAllUsersAsync();
        }

        public async Task<User?> GetUserByIdAsync(int id)
        {
            return await _repository.GetUserByIdAsync(id);
        }

        public async Task<User> AddUserAsync(User user)
        {
            return await _repository.AddUserAsync(user);
        }

        public async Task<User?> UpdateUserAsync(User user)
        {
            return await _repository.UpdateUserAsync(user);
        }

        public async Task<bool> DeleteUserAsync(int id)
        {
            return await _repository.DeleteUserAsync(id);
        }
    }
}
