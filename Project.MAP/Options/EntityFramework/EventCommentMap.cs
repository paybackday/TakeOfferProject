using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options.EntityFramework
{
    public class EventCommentMap : BaseMap<EventComment>
    {
        public override void Configure(EntityTypeBuilder<EventComment> builder)
        {
            base.Configure(builder);
            builder.Ignore(x => x.ID);
            builder.HasOne(x => x.Event).WithMany(x => x.EventComments).HasForeignKey(x => x.EventID).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Comment).WithMany(x => x.EventComments).HasForeignKey(x => x.CommentID).OnDelete(DeleteBehavior.Restrict);            
            builder.HasKey(x => new
            {
                x.EventID,
                x.CommentID
            });

            
        }
    }
}
