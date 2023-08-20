using Abhishek.Entities;
using Abhishek.Repositories.Data;
using Abhishek.Service;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
//using Abhishek.Business_Logic_Layer;


namespace Abhishek.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        UserService userService=new UserService();

        [HttpGet]
        public List<User> GetAllUsers()
        {
         return userService.GetAllUsers();
        }
          [HttpGet("{id}")]

            public User GetUser(int userid)
            {
                 return userService.GetUser(userid);

              }
            [HttpPost]
             public bool Post(User user)
             {

                 if (ModelState.IsValid)

                      return userService.Post(user);
                 return false;

               }

        [HttpGet("UserDetails")]
        public List<UserDetails> GetAllUserDetails()
        {
            return userService.GetAllUserDetails();
        }
        [HttpPost("UserDetails")]
        public bool Post(UserDetails userdetails)
        {

            if (ModelState.IsValid)

                return userService.Post(userdetails);
            return false;

        }


        

    }
}
    

