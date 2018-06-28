using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace _15.Blog_ASP.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string FullName { get; set; }
    }
}
