using System;
using System.Collections.Generic;
using System.Reflection;
using Xunit.Sdk;

namespace completion.bond.tests.Models
{
    public class ProductDataAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[] { new Product { Id = Guid.NewGuid(), ProductName = "Chai", Quantity = 21, IsSale = true } };
            yield return new object[] { new Product { Id = Guid.NewGuid(), ProductName = "Chang", Quantity = 14, IsSale = true } };
            yield return new object[] { new Product { Id = Guid.NewGuid(), ProductName = "Aniseed Syrup", Quantity = 4, IsSale = false } };
            yield return new object[] { new Product { Id = Guid.NewGuid(), ProductName = "Chef Anton's Cajun Seasoning", Quantity = 145, IsSale = true } };
            yield return new object[] { new Product { Id = Guid.NewGuid(), ProductName = "Chef Anton's Gumbo Mix", Quantity = 17, IsSale = true } };
        }
    }
}
