﻿using Entities.Concrete;
using Shared.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class CategoryDto:DtoGetBase
    {
        public Category Category { get; set; }

    }
}
