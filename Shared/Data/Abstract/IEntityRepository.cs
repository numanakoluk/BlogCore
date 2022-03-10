using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Data.Abstract
{
    public interface IEntityRepository<T>
    {
        //Predicate filtre params ile birden fazla parametre alabilir.Kullanıcıyı getirdik.Kullanıcın makalelerini de getir derken params ve bir dizi yoladım.Arrayismi includeProperties.
        Task<T> GetAsync(Expression<Func<T,bool>> predicate, params Expression<Func<T,object>>[] includeProperties);
    }
}
