using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Loginnn.Models
{
    public class User
    {
        public int Id { get; set; }
        //[Required(ErrorMessage = "Phai co username")]
        //[StringLength(10, MinimumLength = 3, ErrorMessage = "Chieu dai khong dung")]
        [Display(Name = "username")]
        public string username {  get; set; }

        //[Required(ErrorMessage = "Phai co password")]
        //[StringLength(10, MinimumLength = 3, ErrorMessage = "Chieu dai khong dung")]
        [Display(Name = "password")]
        public string password {  get; set; }
    }

    public class UsDBContext : DbContext 
    {
        public DbSet<User> Users { get; set; }
    }
}