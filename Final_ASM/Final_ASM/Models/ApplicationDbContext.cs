using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Final_ASM.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<Final_ASM.Models.Trainee> Trainees { get; set; }

        public System.Data.Entity.DbSet<Final_ASM.Models.Trainer> Trainers { get; set; }

        public System.Data.Entity.DbSet<Final_ASM.Models.Room> Rooms { get; set; }

        public System.Data.Entity.DbSet<Final_ASM.Models.Staff> Staffs { get; set; }

        public System.Data.Entity.DbSet<Final_ASM.Models.Course> Courses { get; set; }

        public System.Data.Entity.DbSet<Final_ASM.Models.Topic> Topics { get; set; }

        public System.Data.Entity.DbSet<Final_ASM.Models.Admin> Admins { get; set; }

        public System.Data.Entity.DbSet<Final_ASM.Models.Enrollment> Enrollments { get; set; }
    }
}