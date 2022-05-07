using Project.CORE.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class EventComment:BaseEntity
    {
        //This class is using for many to many relation.
        public int EventID { get; set; }
        public int CommentID { get; set; }

        //Relational Properties
        public virtual Event Event { get; set; }
        public virtual Comment Comment { get; set; }

    }
}
