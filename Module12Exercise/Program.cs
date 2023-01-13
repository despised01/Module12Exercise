using System;
using System.Text;

namespace Module12Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            UserList userList = new UserList();
            Ads ads = new Ads();

            foreach (var user in userList.GetUsers())
            {
                Console.WriteLine($"Здравствуйте, {user.Name}!");

                if (!user.IsPremium)
                    ads.ShowAds();

                Console.WriteLine();
            }
        }
    }
}