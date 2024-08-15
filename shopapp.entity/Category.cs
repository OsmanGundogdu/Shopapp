using System.Collections.Generic;

namespace shopapp.entity
{
    public class Category
    {
        public string Url { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
        
    }
}