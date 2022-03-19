﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Concrete.EntityFramework.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Name).IsRequired();
            builder.Property(c => c.Name).HasMaxLength(70);
            builder.Property(c => c.Description).HasMaxLength(500);
            builder.Property(c => c.CreatedByName).IsRequired();
            builder.Property(c => c.CreatedByName).HasMaxLength(50);
            builder.Property(c => c.ModifiedByName).IsRequired();
            builder.Property(c => c.ModifiedByName).HasMaxLength(50);
            builder.Property(c => c.CreatedDate).IsRequired();
            builder.Property(c => c.ModifiedDate).IsRequired();
            builder.Property(c => c.IsActive).IsRequired();
            builder.Property(c => c.IsDeleted).IsRequired();
            builder.Property(c => c.Note).HasMaxLength(500);
            builder.ToTable("Categories");

            builder.HasData
                (new Article
            {
                Id=1,
                Name="C#",
                Description="C# ile ilgili en güncel bilgiler",
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitialCreate",
                CreatedDate = DateTime.Now,
                ModifiedByName = "InitialCreate",
                ModifiedDate = DateTime.Now,
                Note = "C # Blog Kategorisi",

            },
               new Article
               {
                   Id = 2,
                   Name = "C++",
                   Description = "C++ ile ilgili en güncel bilgiler",
                   IsActive = true,
                   IsDeleted = false,
                   CreatedByName = "InitialCreate",
                   CreatedDate = DateTime.Now,
                   ModifiedByName = "InitialCreate",
                   ModifiedDate = DateTime.Now,
                   Note = "C ++ Blog Kategorisi",

               },
               new Article
               {
                   Id = 3,
                   Name = "JavaScript",
                   Description = "JavaScript ile ilgili en güncel bilgiler",
                   IsActive = true,
                   IsDeleted = false,
                   CreatedByName = "InitialCreate",
                   CreatedDate = DateTime.Now,
                   ModifiedByName = "InitialCreate",
                   ModifiedDate = DateTime.Now,
                   Note = "JavaScript Blog Kategorisi",

               }

            );


        }
    }
}
