using E_Learning_Platform.Data;
using E_Learning_Platform.Interfaces;
using E_Learning_Platform.Models;
using Microsoft.EntityFrameworkCore;

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
            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.Email == email);

            if (user == null)
                return null;

            bool validPassword = BCrypt.Net.BCrypt.Verify(
                password,
                user.Password);

            if (!validPassword)
                return null;

            return user;
        }


        public async Task<User> RegisterAsync(User user)
        {
            user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);

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
