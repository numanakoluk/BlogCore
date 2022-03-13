using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Concrete.EntityFramework.Mappings
{
    public class CommentMap : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Text).IsRequired();
            builder.Property(c => c.Text).HasMaxLength(1000);
            builder.HasOne<Article>(c => c.Article).WithMany(a => a.Comments).HasForeignKey(c => c.ArticleId);
            builder.Property(c => c.CreatedByName).IsRequired();
            builder.Property(c => c.CreatedByName).HasMaxLength(50);
            builder.Property(c => c.ModifiedByName).IsRequired();
            builder.Property(c => c.ModifiedByName).HasMaxLength(50);
            builder.Property(c => c.CreatedDate).IsRequired();
            builder.Property(c => c.ModifiedDate).IsRequired();
            builder.Property(c => c.IsActive).IsRequired();
            builder.Property(c => c.IsDeleted).IsRequired();
            builder.Property(c => c.Note).HasMaxLength(500);
            builder.ToTable("Comments");

            builder.HasData(
                new Comment
            {
                Id=1,
                ArticleId=1,
                Text= "Yazılıma ilginiz varsa, yazılım alanında kendinizi geliştirmek istiyorsanız, ya da bir programlama dili öğreneceksiniz ama nerden başlayacağınızı bilmiyorsanız; Size yardımcı olmak için biz hep burdayız. Lifeacode olarak kendimizi sürekli geliştiriyoruz ve her geçen gün büyüyen bir yazılım eğitim platformuyuz. Güncel yazılım eğitimlerini ya da yazılım hakkında merak ettiklerinizi biz öğreniyoruz ve sizinle paylaştığımız için son derece mutluyuz.",
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitialCreate",
                CreatedDate = DateTime.Now,
                ModifiedByName = "InitialCreate",
                ModifiedDate = DateTime.Now,
                Note = "C # Makale yorumu",
                

            },
               new Comment
            {
                Id=2,
                ArticleId=2,
                Text= "Yazılıma ilginiz varsa, yazılım alanında kendinizi geliştirmek istiyorsanız, ya da bir programlama dili öğreneceksiniz ama nerden başlayacağınızı bilmiyorsanız; Size yardımcı olmak için biz hep burdayız. Lifeacode olarak kendimizi sürekli geliştiriyoruz ve her geçen gün büyüyen bir yazılım eğitim platformuyuz. Güncel yazılım eğitimlerini ya da yazılım hakkında merak ettiklerinizi biz öğreniyoruz ve sizinle paylaştığımız için son derece mutluyuz.",
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitialCreate",
                CreatedDate = DateTime.Now,
                ModifiedByName = "InitialCreate",
                ModifiedDate = DateTime.Now,
                Note = "C++ Makale yorumu",
                

            },
              new Comment
            {
                Id=3,
                ArticleId=2,
                Text= "Yazılıma ilginiz varsa, yazılım alanında kendinizi geliştirmek istiyorsanız, ya da bir programlama dili öğreneceksiniz ama nerden başlayacağınızı bilmiyorsanız; Size yardımcı olmak için biz hep burdayız. Lifeacode olarak kendimizi sürekli geliştiriyoruz ve her geçen gün büyüyen bir yazılım eğitim platformuyuz. Güncel yazılım eğitimlerini ya da yazılım hakkında merak ettiklerinizi biz öğreniyoruz ve sizinle paylaştığımız için son derece mutluyuz.",
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitialCreate",
                CreatedDate = DateTime.Now,
                ModifiedByName = "InitialCreate",
                ModifiedDate = DateTime.Now,
                Note = "JavaScript Makale yorumu",
                

            }
                
                );
        }
    }
}
