using completion.bond.core;
using completion.bond.tests.Models;
using completion.bond.tests.Services;
using Moq;
using System;
using Xunit;
using Xunit.Abstractions;

namespace completion.bond.tests
{
    public class GeneratorTests
    {
        private readonly IProductService _productService;
        private readonly Mock<ITestOutputHelper> _testOutputHelper;
        public GeneratorTests()
        {
            _testOutputHelper = new Mock<ITestOutputHelper>();

            _productService = new ProductService(_testOutputHelper.Object);
        }

        [Theory, ProductData]
        public void Create_ProductModelValues_ShouldEngineRunMethodExecute(Product product)
        {
            new Action<Product>(ExecutableMethod).Invoke(product);

            var productQueue = new Generator<Product>(ExecutableMethod);

            productQueue.Create(product);
        }

        private void ExecutableMethod(Product product)
        {
            _productService.InsertProduct(product);
        }
    }
}