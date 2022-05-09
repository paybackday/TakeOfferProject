using Project.CORE.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CORE.DtoS
{
    public class AppUserDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public Guid ActivationCode { get; set; }
        public bool Active { get; set; }
        public UserRole Role { get; set; }
    }
}
