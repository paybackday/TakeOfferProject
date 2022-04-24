using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options.EntityFramework
{
    public class EventMap:BaseMap<Event>
    {
        public override void Configure(EntityTypeBuilder<Event> builder)
        {
            base.Configure(builder);
            builder.HasOne(e => e.Category).WithMany(c => c.Events).HasForeignKey("CategoryID");
            builder.HasOne(e => e.AppUser).WithMany(au => au.Events).HasForeignKey("AppUserID");
        }
    }
}
