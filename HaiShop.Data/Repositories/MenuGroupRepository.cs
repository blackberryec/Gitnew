﻿using HaiShop.Data.Infrastructure;
using HaiShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaiShop.Data.Repositories
{
    public interface IMenuGroupRepository
    {

    }
    public class MenuGroupRepository : RepositoryBase<MenuGroup>,IMenuGroupRepository
    {
        public MenuGroupRepository(IDbFactory dbFactory) 
            : base (dbFactory)
        {

        }
    }
}