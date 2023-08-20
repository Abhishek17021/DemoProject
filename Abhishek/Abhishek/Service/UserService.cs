using Abhishek.Entities;
using Abhishek.Repositories.Data;
using System.Collections.Generic;

namespace Abhishek.Service
{
    public class UserService
    {
        UserData userdata = new UserData();
        public List<User> GetAllUsers()
         {
            return userdata.GetAllUsers();
         }

        public List<UserDetails> GetAllUserDetails()
        {
            return userdata.GetUserDetails();
        }

        public User GetUser(int userid)
        {
            if (userdata == null)
            {
                throw new Exception("Entered User doesnot exist");
            }
            return userdata.GetUser(userid);
        }
        public bool Post(User users)
        {
            return userdata.Post(users);
        }

        public bool Post(UserDetails userdetails)
        {
            return userdata.Post(userdetails);
        }


    }
}
