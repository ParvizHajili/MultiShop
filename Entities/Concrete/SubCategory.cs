﻿using Core.Entities;

namespace Entities.Concrete
{
    public class SubCategory : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
    }
}