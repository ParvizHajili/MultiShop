﻿using Core.Entities;

namespace Entities.Concrete
{
    public class CategorySub : IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }
        public bool IsDeleted { get; set; }
    }
}
