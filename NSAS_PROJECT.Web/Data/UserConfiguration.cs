using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NSAS_PROJECT.Core.Features.Users;
using NSAS_PROJECT.Web.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSAS_PROJECT.Web.Data
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.Email).HasMaxLength(64);
            builder.HasIndex(x => x.Email).IsUnique();
            builder.OwnsAddress(x => x.Address);
        }
    }
}
