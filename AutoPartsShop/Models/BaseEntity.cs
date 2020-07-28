using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoPartsShop.Models
{
    public abstract class BaseEntity
    {
        public DateTime Created { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Modified { get; set; }
    }
}