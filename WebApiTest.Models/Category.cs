namespace WebApiTest.Models
{
    using System;
    using System.Collections.Generic;
    public class Category
    {
        public Category()
        {
            Products = new List<Product>();
        }
        public int CategoryID { get; set; }
        
        public string CategoryName { get; set; }
        
        public string Description { get; set; }
        
        public virtual ICollection<Product> Products { get; set; }
    }
}
