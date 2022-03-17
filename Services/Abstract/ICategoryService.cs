﻿using Entities.Concrete;
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
        Task<IDataResult<Category>> Get(int categoryId);
        Task<IDataResult<IList<Category>>> GetAll();

        //ViewModel dto
        Task<IResult> Add(CategoryAddDto categoryAddDto, string createdByName);

        Task<IResult> Update(CategoryUpdateDto categoryUpdateDto, string modifedByName);

        //Active Passive
        Task<IResult> Delete(int categoyId);

        //Veritabanı silme.
        Task<IResult> HardDelete(int categoryId);
    }
}