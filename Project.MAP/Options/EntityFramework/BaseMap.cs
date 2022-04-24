using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.CORE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options.EntityFramework
{
    public abstract class BaseMap<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(x => x.CreatedDate).HasColumnName("Created Date");
            builder.Property(x => x.DeletedDate).HasColumnName("Deleted Date");
            builder.Property(x => x.ModifiedDate).HasColumnName("Modified Date");
            builder.Property(x => x.Status).HasColumnName("Status");
        }
    }
}
