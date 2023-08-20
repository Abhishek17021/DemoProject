using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Abhishek.Entities
{
    public class UserDetails
    {
     
     public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        
        public string UserEmail { get; set; }

        [Required]
        
        public Role Role { get; set; }
        public Boolean IsStudent { get; set; }

        public int UserId { get;set; }
        public string UserName { get; set; }
        public string Password { get; set; }


     }
   
    }

