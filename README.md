# completion-bond
The same is repeated until the data reaches the final destination resulting.



```csharp
public class Product
{
    public Guid Id { get; set; }
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public bool IsSale { get; set; }
}

public interface IProductService
{
    void InsertProduct(Product product);
}

public class ProductService : IProductService
{
    public void InsertProduct(Product product)
    {        
    }
}

private void ExecutableMethod(Product product)
{
    _productService.InsertProduct(product);
}

new Action<Product>(ExecutableMethod).Invoke(product);
var productQueue = new Generator<Product>(ExecutableMethod);
productQueue.Create(product);
```
