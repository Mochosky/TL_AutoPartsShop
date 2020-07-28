using System;

namespace AutoPartsShop.Models
{
    public abstract class BaseEntity
    {
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}