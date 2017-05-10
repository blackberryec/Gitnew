using AutoMapper;
using HaiShop.Model.Models;
using HaiShop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HaiShop.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            //Mapper bản 4. phương thức này sẽ cập nhật sau với mapper bản 5.0
            Mapper.CreateMap<Post, PostViewModel>();
            Mapper.CreateMap<PostCategory, PostCategoryViewModel>();
            Mapper.CreateMap<Tag, TagViewModel>();
        }
    }
}