using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NSAS_PROJECT.Core.Features.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace NSAS_PROJECT.Web.Extensions
{
    public static class EntityTypeBuilderExtensions
    {
        public static ReferenceOwnershipBuilder<T, Address> OwnsAddress<T>(this EntityTypeBuilder<T> entityTypeBuilder, Expression<Func<T, Address>> addressExpression) where T : class
        {
            var owned = entityTypeBuilder.OwnsOne(addressExpression);
            owned.Property(x => x.Addressline1).HasMaxLength(64);
            owned.Property(x => x.AddressLine2).HasMaxLength(64);
            owned.Property(x => x.City).HasMaxLength(64);
            owned.Property(x => x.State).HasMaxLength(2);
            owned.Property(x => x.ZipCode).HasMaxLength(5);
            return owned;
        }
    }
}
