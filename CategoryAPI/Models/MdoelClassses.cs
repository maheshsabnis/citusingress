﻿using System;
using System.Collections.Generic;
using System.Threading;

namespace CategoryAPI.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }

    public class CategoriesDb : List<Category>
    {
        public CategoriesDb()
        {
            Add(new Category() { CategoryId=201,CategoryName="C1"});
            Add(new Category() { CategoryId = 202, CategoryName = "C2" });
        }
    }
}
