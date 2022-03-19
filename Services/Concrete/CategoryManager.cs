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

        public async Task<IDataResult<IList<Category>>> GetAll()
        {
            var categories = await _unitOfWork.Categories.GetAllAsync(null, c => c.Articles);

            //0 tane kategori de isteyebiliriz.
            if (categories.Count>-1)
            {
                return new DataResult<IList<Category>>(ResultStatus.Success, categories);
            }
            return new DataResult<IList<Category>>(ResultStatus.Error, "Hiç Bir Kategori Bulunamadı.",null);
        }

        public async Task<IDataResult<IList<Category>>> GetAllByNonDeleted()
        {
            var categories = await _unitOfWork.Categories.GetAllAsync(c => !c.IsDeleted, c => c.Articles);

            if (categories.Count>-1)
            {
                return new DataResult<IList<Category>>(ResultStatus.Success, categories);

            }
            return new DataResult<IList<Category>>(ResultStatus.Error, "Hiç Bir Kategori Bulunamadı.", null);

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
