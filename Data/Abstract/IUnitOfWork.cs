using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Abstract
{
    //Garbage Collector'e bırakmamak için IDisposable gereksiz veriyi yöneterek önbellekten siliyoruz.
    public interface IUnitOfWork: IDisposable
    {
        IArticleRepository Articles { get; } // unitofwork.Articles

        ICategoryRepository Categories { get; } 

        ICommentRepository Roles { get; }

        IUserRepository Users { get; } //_unitOfWork.Categories.AddAsync();

        //_unitOfWork.Categories.AddAsync(category);
        //_unitOfWork.Users.AddAsync(category);
        //_uniOfWork.SaveAsync() // Tek bir SaveChanges.Transactions yapısı.Eğer bir tanesi hata alırsa(exception) diğer yerleri veri tabanına kayıt etmeyecek.
        Task<int> SaveAsync();


    }
}
