using Microsoft.AspNetCore.Identity;

namespace LeaveManagement.Web.Data
{
    public class Employee : IdentityUser
    {
        public string Firstname { get; set; } = null!;
        public string Lastname { get; set; } = null!;
        public int NationalInsuranceNo { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateJoined { get; set; }
    }
}
