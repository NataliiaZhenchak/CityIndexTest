using System;
using System.Collections.Generic;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace CityIndex.Droid.Services
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class UserRepository
    {
        public static UserRepository Current { get; private set; } = new UserRepository();

        List<User> _users = new List<User>
        {
            new User{FirstName = "Bob", LastName = "Bobby", Email = "bob@mail.com", Password = "1234"},
            new User{FirstName = "Tom", LastName = "Tommy", Email = "tom@mail.com", Password = "1234"},
            new User{FirstName = "Sara", LastName = "Scary", Email = "sara@mail.com", Password = "1234"}
        };

        public IEnumerable<User> GetUsers()
        {
            return _users;
        }
    }


}