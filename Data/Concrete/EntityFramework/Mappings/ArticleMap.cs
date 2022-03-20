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
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(a => a.Title).HasMaxLength(100);
            builder.Property(a => a.Title).IsRequired(true);
            builder.Property(a => a.Content).IsRequired();
            builder.Property(a => a.Content).HasColumnType("NVARCHAR(MAX)");
            builder.Property(a => a.Date).IsRequired();
            builder.Property(a => a.SeoAuthor).IsRequired();
            builder.Property(a => a.SeoAuthor).HasMaxLength(50);
            builder.Property(a => a.SeoDescription).HasMaxLength(150);
            builder.Property(a => a.SeoDescription).IsRequired();
            builder.Property(a => a.SeoTags).IsRequired();
            builder.Property(a => a.SeoTags).HasMaxLength(70);
            builder.Property(a => a.ViewCount).IsRequired();
            builder.Property(a => a.CommentCount).IsRequired();
            builder.Property(a => a.Thumbnail).IsRequired();
            builder.Property(a => a.Thumbnail).HasMaxLength(250);

            //Değiştirmek istediğimizde ortak alanlar için.
            builder.Property(a => a.CreatedByName).IsRequired();
            builder.Property(a => a.CreatedByName).HasMaxLength(50);
            builder.Property(a => a.ModifiedByName).IsRequired();
            builder.Property(a => a.ModifiedByName).HasMaxLength(50);
            builder.Property(a => a.CreatedDate).IsRequired();
            builder.Property(a => a.ModifiedDate).IsRequired();
            builder.Property(a => a.IsActive).IsRequired();
            builder.Property(a => a.IsDeleted).IsRequired();
            builder.Property(a => a.Note).HasMaxLength(500);
            builder.HasOne<Category>(a => a.Category).WithMany(c => c.Articles).HasForeignKey(a => a.CategoryId);
            builder.HasOne<User>(a => a.User).WithMany(u => u.Articles).HasForeignKey(a => a.UserId);
            builder.ToTable("Articles");

            builder.HasData
                (new Article
            {
                 Id=1,
                 CategoryId=1,
                 Title="C# 5.0 Yenilikler",
                 Content= "C# ile uygulama geliştirirken bir sınıf başka bir sınıftan inherit olduğunda ve base sınıfın bir metodunu override ettiğinizde, o metodun dönüş tipi base sınıftaki metodun dönüş tipiyle aynı olmak zorundaydı. Bu durum C# 9 ile birlikte değişti ve artık override edilen metodların base sınıftaki metottan farklı dönüş tipine sahip olmasına olanak tanındı.",
                 Thumbnail="Default.jpg",
                 SeoDescription= "C# 5.0 Yenilikler",
                 SeoTags="C #, C#9, .NET5",
                 SeoAuthor="Numan Akoluk",
                 Date=DateTime.Now,
                 IsActive = true,
                 IsDeleted = false,
                 CreatedByName = "InitialCreate",
                 CreatedDate = DateTime.Now,
                 ModifiedByName = "InitialCreate",
                 ModifiedDate = DateTime.Now,
                 Note = "C# 5.0 Yenilikler",
                 UserId=1,
                 ViewCount= 100,
                 CommentCount=1


                },
                new Article
                {

                    Id = 2,
                    CategoryId = 2,
                    Title = "C++ 11 Yenilikler",
                    Content = "C++ dilinde gittikçe zorlaşmış, üçüncü parti kütüphane desteği olmadan güncel problemlere çözüm sunamayan eski kalmış bir dil haline gelmişti. C++ geliştiricileri, Boost gibi kütüphaneler olmadan diğer yazılım dillerinin sağladığı özellikler ile yarışamaz bir durumdaydılar.",
                    Thumbnail = "Default.jpg",
                    SeoDescription = "C++ 11 Yenilikler",
                    SeoTags = "C ++, C++11, Yenilikler",
                    SeoAuthor = "Numan Akoluk",
                    Date = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "C++ 11  Yenilikler",
                    UserId = 1,
                    ViewCount = 295,
                    CommentCount = 1
                },
                new Article
                {

                    Id = 3,
                    CategoryId = 3,
                    Title = "JavaScript 2022 Yenilikleri",
                    Content = "ECMAScript'in en popüler uygulaması, Node.js gibi çalışma zamanları aracılığıyla web tarayıcıları ve bulut ortamları tarafından desteklenen dil olan JavaScript'tir. İşte ES2021'deki ana değişikliklere genel bir bakış.",
                    Thumbnail = "Default.jpg",
                    SeoDescription = "JavaScript 2022 Yenilikleri",
                    SeoTags = "JavaScript, 2022, Yenilikler",
                    SeoAuthor = "Numan Akoluk",
                    Date = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "JavaScript 2022 Yenilikleri",
                    UserId = 1,
                    ViewCount = 12,
                    CommentCount = 1
                }


                );
                
        }
    }
}
