using Abp.Domain.Entities;

namespace Test.MyProject.Products
{
    public class Product : Entity<int>
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
    }
}
