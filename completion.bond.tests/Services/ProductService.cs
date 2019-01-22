using completion.bond.tests.Models;
using Xunit.Abstractions;

namespace completion.bond.tests.Services
{
    public class ProductService : IProductService
    {
        private readonly ITestOutputHelper _outputHelper;
        public ProductService(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        public void InsertProduct(Product product)
        {
            _outputHelper.WriteLine($"ProductId : {product.Id} - ProductName : {product.ProductName} - Quantity : {product.Quantity} - IsSale : {product.IsSale}");
        }
    }
}
