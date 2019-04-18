﻿using GWebsite.AbpZeroTemplate.Core.Models;

namespace GWebsite.AbpZeroTemplate.Application.Share.Categories.Dto
{
    /// <summary>
    /// <model cref="Category"></model>
    /// </summary>
    public class CategoryForViewDto
    {
        //tên danh mục tài sản
        public string Name { get; set; }
        //ghi chú danh mục tài sản
        public string Note { get; set; }
    }
}