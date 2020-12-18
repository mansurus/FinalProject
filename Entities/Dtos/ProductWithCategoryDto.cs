using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class ProductWithCategoryDto
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
