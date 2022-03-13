﻿// <auto-generated />
using System;
using Data.Concrete.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(BlogContext))]
    partial class BlogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Entities.Concrete.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CommentCount")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)");

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("SeoAuthor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SeoDescription")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("SeoTags")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("Thumbnail")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("ViewCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CommentCount = 1,
                            Content = "C# ile uygulama geliştirirken bir sınıf başka bir sınıftan inherit olduğunda ve base sınıfın bir metodunu override ettiğinizde, o metodun dönüş tipi base sınıftaki metodun dönüş tipiyle aynı olmak zorundaydı. Bu durum C# 9 ile birlikte değişti ve artık override edilen metodların base sınıftaki metottan farklı dönüş tipine sahip olmasına olanak tanındı.",
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 3, 13, 17, 6, 3, 295, DateTimeKind.Local).AddTicks(892),
                            Date = new DateTime(2022, 3, 13, 17, 6, 3, 294, DateTimeKind.Local).AddTicks(9635),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 3, 13, 17, 6, 3, 295, DateTimeKind.Local).AddTicks(1326),
                            Note = "C# 5.0 Yenilikler",
                            SeoAuthor = "Numan Akoluk",
                            SeoDescription = "C# 5.0 Yenilikler",
                            SeoTags = "C #, C#9, .NET5",
                            Thumbnail = "Default.jpg",
                            Title = "C# 5.0 Yenilikler",
                            UserId = 1,
                            ViewCount = 100
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            CommentCount = 1,
                            Content = "C++ dilinde gittikçe zorlaşmış, üçüncü parti kütüphane desteği olmadan güncel problemlere çözüm sunamayan eski kalmış bir dil haline gelmişti. C++ geliştiricileri, Boost gibi kütüphaneler olmadan diğer yazılım dillerinin sağladığı özellikler ile yarışamaz bir durumdaydılar.",
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 3, 13, 17, 6, 3, 295, DateTimeKind.Local).AddTicks(2307),
                            Date = new DateTime(2022, 3, 13, 17, 6, 3, 295, DateTimeKind.Local).AddTicks(2306),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 3, 13, 17, 6, 3, 295, DateTimeKind.Local).AddTicks(2309),
                            Note = "C++ 11  Yenilikler",
                            SeoAuthor = "Numan Akoluk",
                            SeoDescription = "C++ 11 Yenilikler",
                            SeoTags = "C ++, C++11, Yenilikler",
                            Thumbnail = "Default.jpg",
                            Title = "C++ 11 Yenilikler",
                            UserId = 1,
                            ViewCount = 295
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            CommentCount = 1,
                            Content = "ECMAScript'in en popüler uygulaması, Node.js gibi çalışma zamanları aracılığıyla web tarayıcıları ve bulut ortamları tarafından desteklenen dil olan JavaScript'tir. İşte ES2021'deki ana değişikliklere genel bir bakış.",
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 3, 13, 17, 6, 3, 295, DateTimeKind.Local).AddTicks(2314),
                            Date = new DateTime(2022, 3, 13, 17, 6, 3, 295, DateTimeKind.Local).AddTicks(2313),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 3, 13, 17, 6, 3, 295, DateTimeKind.Local).AddTicks(2315),
                            Note = "JavaScript 2022 Yenilikleri",
                            SeoAuthor = "Numan Akoluk",
                            SeoDescription = "JavaScript 2022 Yenilikleri",
                            SeoTags = "JavaScript, 2022, Yenilikler",
                            Thumbnail = "Default.jpg",
                            Title = "JavaScript 2022 Yenilikleri",
                            UserId = 1,
                            ViewCount = 12
                        });
                });

            modelBuilder.Entity("Entities.Concrete.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 3, 13, 17, 6, 3, 297, DateTimeKind.Local).AddTicks(4860),
                            Description = "C# ile ilgili en güncel bilgiler",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 3, 13, 17, 6, 3, 297, DateTimeKind.Local).AddTicks(4868),
                            Name = "C#",
                            Note = "C # Blog Kategorisi"
                        },
                        new
                        {
                            Id = 2,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 3, 13, 17, 6, 3, 297, DateTimeKind.Local).AddTicks(4878),
                            Description = "C++ ile ilgili en güncel bilgiler",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 3, 13, 17, 6, 3, 297, DateTimeKind.Local).AddTicks(4879),
                            Name = "C++",
                            Note = "C ++ Blog Kategorisi"
                        },
                        new
                        {
                            Id = 3,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 3, 13, 17, 6, 3, 297, DateTimeKind.Local).AddTicks(4883),
                            Description = "JavaScript ile ilgili en güncel bilgiler",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 3, 13, 17, 6, 3, 297, DateTimeKind.Local).AddTicks(4884),
                            Name = "JavaScript",
                            Note = "JavaScript Blog Kategorisi"
                        });
                });

            modelBuilder.Entity("Entities.Concrete.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ArticleId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArticleId = 1,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 3, 13, 17, 6, 3, 299, DateTimeKind.Local).AddTicks(630),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 3, 13, 17, 6, 3, 299, DateTimeKind.Local).AddTicks(638),
                            Note = "C # Makale yorumu",
                            Text = "Yazılıma ilginiz varsa, yazılım alanında kendinizi geliştirmek istiyorsanız, ya da bir programlama dili öğreneceksiniz ama nerden başlayacağınızı bilmiyorsanız; Size yardımcı olmak için biz hep burdayız. Lifeacode olarak kendimizi sürekli geliştiriyoruz ve her geçen gün büyüyen bir yazılım eğitim platformuyuz. Güncel yazılım eğitimlerini ya da yazılım hakkında merak ettiklerinizi biz öğreniyoruz ve sizinle paylaştığımız için son derece mutluyuz."
                        },
                        new
                        {
                            Id = 2,
                            ArticleId = 2,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 3, 13, 17, 6, 3, 299, DateTimeKind.Local).AddTicks(647),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 3, 13, 17, 6, 3, 299, DateTimeKind.Local).AddTicks(648),
                            Note = "C++ Makale yorumu",
                            Text = "Yazılıma ilginiz varsa, yazılım alanında kendinizi geliştirmek istiyorsanız, ya da bir programlama dili öğreneceksiniz ama nerden başlayacağınızı bilmiyorsanız; Size yardımcı olmak için biz hep burdayız. Lifeacode olarak kendimizi sürekli geliştiriyoruz ve her geçen gün büyüyen bir yazılım eğitim platformuyuz. Güncel yazılım eğitimlerini ya da yazılım hakkında merak ettiklerinizi biz öğreniyoruz ve sizinle paylaştığımız için son derece mutluyuz."
                        },
                        new
                        {
                            Id = 3,
                            ArticleId = 2,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 3, 13, 17, 6, 3, 299, DateTimeKind.Local).AddTicks(652),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 3, 13, 17, 6, 3, 299, DateTimeKind.Local).AddTicks(653),
                            Note = "JavaScript Makale yorumu",
                            Text = "Yazılıma ilginiz varsa, yazılım alanında kendinizi geliştirmek istiyorsanız, ya da bir programlama dili öğreneceksiniz ama nerden başlayacağınızı bilmiyorsanız; Size yardımcı olmak için biz hep burdayız. Lifeacode olarak kendimizi sürekli geliştiriyoruz ve her geçen gün büyüyen bir yazılım eğitim platformuyuz. Güncel yazılım eğitimlerini ya da yazılım hakkında merak ettiklerinizi biz öğreniyoruz ve sizinle paylaştığımız için son derece mutluyuz."
                        });
                });

            modelBuilder.Entity("Entities.Concrete.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 3, 13, 17, 6, 3, 300, DateTimeKind.Local).AddTicks(5613),
                            Description = "Admin Tüm Haklara Sahip",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 3, 13, 17, 6, 3, 300, DateTimeKind.Local).AddTicks(5621),
                            Name = "Admin",
                            Note = "Admin Rolüdür."
                        });
                });

            modelBuilder.Entity("Entities.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("USER_EMAIL");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("VARBINARY(500)");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("RoleId");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 3, 13, 17, 6, 3, 305, DateTimeKind.Local).AddTicks(4272),
                            Description = "İlk Admin Kullanıcı",
                            Email = "numanrail80@gmail.com",
                            FirstName = "Numan",
                            IsActive = true,
                            IsDeleted = false,
                            LastName = "Tunga",
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 3, 13, 17, 6, 3, 305, DateTimeKind.Local).AddTicks(4281),
                            Note = "Admin Kullanıcısı.",
                            PasswordHash = new byte[] { 48, 49, 57, 50, 48, 50, 51, 97, 55, 98, 98, 100, 55, 51, 50, 53, 48, 53, 49, 54, 102, 48, 54, 57, 100, 102, 49, 56, 98, 53, 48, 48 },
                            Picture = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSX4wVGjMQ37PaO4PdUVEAliSLi8-c2gJ1zvQ&usqp=CAU",
                            RoleId = 1,
                            Username = "numanakoluk"
                        });
                });

            modelBuilder.Entity("Entities.Concrete.Article", b =>
                {
                    b.HasOne("Entities.Concrete.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.User", "User")
                        .WithMany("Articles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Concrete.Comment", b =>
                {
                    b.HasOne("Entities.Concrete.Article", "Article")
                        .WithMany("Comments")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");
                });

            modelBuilder.Entity("Entities.Concrete.User", b =>
                {
                    b.HasOne("Entities.Concrete.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Entities.Concrete.Article", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("Entities.Concrete.Category", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("Entities.Concrete.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Entities.Concrete.User", b =>
                {
                    b.Navigation("Articles");
                });
#pragma warning restore 612, 618
        }
    }
}
