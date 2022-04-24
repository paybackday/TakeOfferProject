using Project.CORE.Entities;
using Project.CORE.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class AppUser:BaseEntity
    {
        public AppUser()
        {
            ActivationCode = Guid.NewGuid();
            Role = UserRole.Member;
        }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public Guid ActivationCode { get; set; }
        public bool Active { get; set; }
        public UserRole Role { get; set; }

        //Relational Properties
        public virtual AppUserProfile Profile { get; set; }
        public virtual List<Event> Events { get; set; }
        public virtual List<Comment> Comments { get; set; }

    }
}
