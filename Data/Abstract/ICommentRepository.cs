﻿using Entities.Concrete;
using Shared.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Abstract
{
    public interface ICommentRepository : IEntityRepository<Comment>
    {
    }
}
