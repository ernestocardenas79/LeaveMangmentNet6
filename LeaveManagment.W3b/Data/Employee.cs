using Microsoft.AspNetCore.Identity;

namespace LeaveManagment.W3b.Data
{
    public class Employee : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBith { get; set; }
        public DateTime DateJoined { get; set; }
    }
}
