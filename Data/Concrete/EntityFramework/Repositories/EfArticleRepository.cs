﻿using Data.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Shared.Data.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Concrete.EntityFramework.Repositories
{
    public class EfArticleRepository : EfEntityRepositoryBase<Article>, IArticleRepository
    {
        //Tek bir base sınıf ile hepsini eklemiş oluyoruz.Dependiec Inj yapma sebebim IArticleRepository arayüzünde özel olarak bir şey implemente ettiğimde buraya direk yansıtmak istemem.
        public EfArticleRepository(DbContext context) : base(context)
        {

        }
    }
}
