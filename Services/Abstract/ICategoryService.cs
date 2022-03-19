using Entities.Concrete;
using Entities.Dtos;
using Shared.Utility.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstract
{
    public interface ICategoryService
    {
        Task<IDataResult<Article>> Get(int categoryId);
        Task<IDataResult<IList<Article>>> GetAll();
        Task<IDataResult<IList<Article>>> GetAllByNonDeleted();

        //ViewModel dto
        Task<IResult> Add(CategoryAddDto categoryAddDto, string createdByName);

        Task<IResult> Update(CategoryUpdateDto categoryUpdateDto, string modifiedByName);

        //Active Passive
        Task<IResult> Delete(int categoyId, string modifiedByName);

        //Veritabanı silme.
        Task<IResult> HardDelete(int categoryId);
    }
}
