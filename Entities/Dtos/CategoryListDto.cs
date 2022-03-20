﻿using Entities.Concrete;
using Shared.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class CategoryListDto: DtoGetBase
    {
        public IList<Category> Categories { get; set; }

    }
}
