using System;
using System.Text;
using System.Collections.Generic;

namespace Module12Exercise
{
    public class UserList
    {
        private List<User> users = new List<User>();

        public List<User> GetUsers()
        {
            users.Add(new User() { Login = "Nemesis", Name = "Jill", IsPremium = false });
            users.Add(new User() { Login = "Mr_X", Name = "Claire", IsPremium = true });
            users.Add(new User() { Login = "Plagas", Name = "Leon", IsPremium = true });
            users.Add(new User() { Login = "Ouroboros", Name = "Chris", IsPremium = false });
            users.Add(new User() { Login = "Umbrella", Name = "Albert", IsPremium = true });

            return users;
        }
    }
}
