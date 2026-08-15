using E_Learning_Platform.Data;
using E_Learning_Platform.Interfaces;
using E_Learning_Platform.Models;

namespace E_Learning_Platform.Repository
{
    public class AuthRepository:IAuthRepository
    {
        private readonly AppDbContext _context;

        public AuthRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<User?> LoginAsync(string email, string password)
        {
            return  _context.Users
                .FirstOrDefault(u =>
                    u.Email == email &&
                    u.Password == password);
        }

        public async Task<User> RegisterAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<bool> EmailExistsAsync(string email)
        {
            return  _context.Users
                .Any(u => u.Email == email);
        }
    }
}
