using E_Learning_Platform.Interfaces;

namespace E_Learning_Platform.Service
{
    public class UserService
    {
        protected readonly IUserRepository _userRepo;
        public UserService(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }
    }
}
