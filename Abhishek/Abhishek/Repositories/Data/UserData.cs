using Abhishek.Entities;
using System.Text.Json;

namespace Abhishek.Repositories.Data
{
    public class UserData
    {
        

        public List<User> GetAllUsers()
        {
           string ReadAllUsers = System.IO.File.ReadAllText(@"C:\Users\parom\source\repos\Abhishek\Abhishek\Repositories\Data\UserEntry.json");
           return JsonSerializer.Deserialize<List<User>>(ReadAllUsers);
        }

        public List<UserDetails> GetUserDetails()
        {
            string ReadAllUserDetails = System.IO.File.ReadAllText(@"C:\Users\parom\source\repos\Abhishek\Abhishek\Repositories\Data\UserDetails.json");
            return JsonSerializer.Deserialize<List<UserDetails>>(ReadAllUserDetails);
        }


        public bool Post(User user)
        {
            string ReadAllUser = System.IO.File.ReadAllText(@"C:\Users\parom\source\repos\Abhishek\Abhishek\Repositories\Data\UserEntry.json");
            var UserUpdated = JsonSerializer.Deserialize<List<User>>(ReadAllUser);

            var usercheck = (from e in UserUpdated where e.UserName.Equals(user.UserName) select e).Count();
            if (usercheck > 0)
               return false;
            var maxIduser = (from e in UserUpdated orderby e.UserId descending select e.UserId).FirstOrDefault();
            user.UserId = maxIduser + 1;

            var adduser = new User()
            {
                UserId = user.UserId,
                UserName = user.UserName,
                Password = user.Password,
                
                

            };
            
            
            UserUpdated.Add(adduser);

            string json = JsonSerializer.Serialize(UserUpdated);
            File.WriteAllText(@"C:\Users\parom\source\repos\Abhishek\Abhishek\Repositories\Data\UserEntry.json", json);

            //File.WriteAllText(@"C:\Users\parom\source\repos\Abhishek\Abhishek\Repositories\Data\UserDetails.json", json);

            return true;
        }

        public bool Post(UserDetails userdetails)
        {
            string ReadAllUser1 = System.IO.File.ReadAllText(@"C:\Users\parom\source\repos\Abhishek\Abhishek\Repositories\Data\UserDetails.json");
            var userUpdated1 = JsonSerializer.Deserialize<List<UserDetails>>(ReadAllUser1);

            var usercheck = (from e in userUpdated1 where e.UserName.Equals(userdetails.UserName) select e).Count();
            if (usercheck > 0)
                return false;
            var maxIduser = (from e in userUpdated1 orderby e.UserId descending select e.UserId).FirstOrDefault();
            userdetails.UserId = maxIduser + 1;

            var adduserDetails = new UserDetails() {

                UserId = userdetails.UserId,
                UserName=userdetails.UserName,
                Password=userdetails.Password,
                FirstName = userdetails.FirstName,
                LastName = userdetails.LastName,
                UserEmail = userdetails.UserEmail,
                IsStudent = userdetails.IsStudent,
                Role = userdetails.Role,
               
           
            };

            userUpdated1.Add(adduserDetails);
        

            string json1 = JsonSerializer.Serialize(userUpdated1);
            File.WriteAllText(@"C:\Users\parom\source\repos\Abhishek\Abhishek\Repositories\Data\UserDetails.json", json1);
            //File.WriteAllText(@"C:\Users\parom\source\repos\Abhishek\Abhishek\Repositories\Data\UserEntry.json", json1);
            return true;
        }

        public User GetUser(int userid)
        {

            string ReadAllUser = System.IO.File.ReadAllText(@"C:\Users\parom\source\repos\Abhishek\Abhishek\Repositories\Data\UserEntry.json");
            var UserUpdated = JsonSerializer.Deserialize<List<User>>(ReadAllUser);
           var user = UserUpdated.Find(x => x.UserId== userid);

            return user;
        }

            
        }
    }

