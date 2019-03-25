using System.Linq;

namespace CityIndex.Droid.Services
{
    public class UserLoginService
    {
        public static UserLoginService Current { get; private set; } = new UserLoginService();

        public User CurrentUser { get; private set; }

        UserRepository _userRepo = new UserRepository();

        public bool TryLogin(string email, string password)
        {
            var u = _userRepo.GetUsers().FirstOrDefault(user => user.Email == email && user.Password == password);
            if(u != null)
            {
                CurrentUser = u;
                return true;
            }

            CurrentUser = null;
            return false;
        }

        public void Logout()
        {
            CurrentUser = null;
        }
    }


}