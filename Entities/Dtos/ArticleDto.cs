using Entities.Concrete;
using Shared.Entites.Abstract;
using Shared.Utility.Results.Complex_Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class ArticleDto: DtoGetBase
    {
        public Article Article { get; set; }


    }
}
