﻿using HaiShop.Data.Infrastructure;
using HaiShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaiShop.Data.Repositories
{
    public interface IPageRepository
    {

    }
    public class PageRepository : RepositoryBase<Page>,IPageRepository
    {
        public PageRepository(IDbFactory dbFactory)
            : base (dbFactory)
        {

        }
    }
}
