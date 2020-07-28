using System.Collections.Generic;

using AutoPartsShop.Interfaces;
using AutoPartsShop.Models;

namespace AutoPartsShop.Repositories
{
    public class CategoryRepository : ICategory
    {
        public IEnumerable<Category> GetCategories => new List<Category>
        {
                new Category
                {
                    CategoryId=1,
                    Name="Engine",
                    Description="Engine related parts."
                },

                new Category
                {
                    CategoryId=2,
                    Name="Suspension",
                    Description="Suspension related parts."},

                new Category
                {
                    CategoryId=3,
                    Name="Brakes",
                    Description="Braking system related parts."
                }
        };
    }
}
