using Entities.Entites.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Data.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        //Predicate filtre params ile birden fazla parametre alabilir.Kullanıcıyı getirdik.Kullanıcın makalelerini de getir derken params ve bir dizi yoladım.Arrayismi includeProperties.
        Task<T> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties); // var kullanici = repository.GetAsync(k=>k.Id==15);

        //Birden çok bir listeye ihtiyacımız olursa.Predicate null ise tüm article gelsin gelmzse filtreye göre yüklüyor olucaz.
        Task<IList<T>> GetAllAsync(Expression<Func<T,bool>> predicate=null, params Expression<Func<T,object>> [] includeProperties);

        Task AddAsync(T entity);

        Task UpdateAsync(T entiy);

        Task DeleteAsync(T entity);

        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);

        Task<int> CountAsync(Expression<Func<T, bool>> predicate);

    }
}
