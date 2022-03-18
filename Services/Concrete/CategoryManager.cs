using Data.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using Services.Abstract;
using Shared.Utility.Results.Abstract;
using Shared.Utility.Results.Complex_Types;
using Shared.Utility.Results.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Concrete
{
    public class CategoryManager : ICategoryService
    {

        private readonly IUnitOfWork _unitOfWork;

        public CategoryManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<IResult> Add(CategoryAddDto categoryAddDto, string createdByName)
        {
            throw new NotImplementedException();

        }

        public Task<IResult> Delete(int categoyId)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<Category>> Get(int categoryId)
        {
            //ınclude articles
            var category= await _unitOfWork.Categories.GetAsync(c => c.Id == categoryId,c=>c.Articles);

            if (category!=null)
            {
                return  new  DataResult<Category>(ResultStatus.Success,category);
            }
            return new DataResult<Category>(ResultStatus.Error,"Böyle Bir Kategori Bulunamadı.",null);
        }

        public Task<IDataResult<IList<Category>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<IList<Category>>> GetAllByNonDeleted()
        {
            throw new NotImplementedException();
        }

        public Task<IResult> HardDelete(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Update(CategoryUpdateDto categoryUpdateDto, string modifedByName)
        {
            throw new NotImplementedException();
        }
    }
}
