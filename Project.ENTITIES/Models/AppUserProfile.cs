using Project.CORE.Entities;
using Project.CORE.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class AppUserProfile:BaseEntity
    {
        public int? AppUserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string MobilePhone { get; set; }
        public Gender Gender { get; set; }

        //Relational Properties
        public virtual AppUser AppUser { get; set; }
    }
}
