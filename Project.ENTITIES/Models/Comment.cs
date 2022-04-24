using Project.CORE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Comment:BaseEntity
    {
        public int AppUserID { get; set; }
        public string CommentTitle { get; set; }
        public string CommentDescription { get; set; }
        public decimal PriceOffer { get; set; }

        //Relational Properties
        public virtual AppUser AppUser { get; set; }
        public virtual List<EventComment> EventComments { get; set; }
    }
}
