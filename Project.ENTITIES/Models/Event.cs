using Project.CORE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Event:BaseEntity
    {
        public string EventName { get; set; }
        public string EventDescription { get; set; }
        public int CategoryID { get; set; }
        public int AppUserID { get; set; }

        //Relational Properties
        public virtual Category Category { get; set; }
        public virtual AppUser AppUser { get; set; }
        public virtual List<EventComment> EventComments { get; set; }
    }
}
