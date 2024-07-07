using StockOptima.Models.Database;
using JetBrains.Annotations;

namespace StockOptima.Operations
{
    public class ProductsListOperation
    {
        [CanBeNull]
        public string Query { get; set; }
        public Product[] Products { get; set; }
    }
}