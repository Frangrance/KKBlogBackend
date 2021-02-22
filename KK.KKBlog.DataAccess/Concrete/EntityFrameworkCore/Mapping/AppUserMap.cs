using System;
using System.Collections.Generic;
using System.Text;
using KK.KKBlog.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KK.KKBlog.DataAccess.Concrete.EntityFrameworkCore.Mapping
{
    public class AppUserMap : IEntityTypeConfiguration<AppUser>  // FLUENT APİ
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();

            builder.Property(I => I.UserName).HasMaxLength(50).IsRequired();
            builder.Property(I => I.Password).HasMaxLength(50).IsRequired();
            builder.Property(I => I.Email).HasMaxLength(50);
            builder.Property(I => I.FirstName).HasMaxLength(50);
            builder.Property(I => I.LastName).HasMaxLength(50);

            builder.HasMany(I => I.Blogs)
                .WithOne(I => I.AppUser)
                .HasForeignKey(I => I.AppUserId);

        }
    }
}
