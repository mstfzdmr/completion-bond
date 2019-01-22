# completion-bond
The same is repeated until the data reaches the final destination resulting.


#### Example usage:

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
    bool InsertProduct(Product product);
}

public class ProductService : IProductService
{
    public bool InsertProduct(Product product)
    {
        //sequence of operations 
        return true;
    }
}

private void ExecutableMethod(Product product)
{
    _productService.InsertProduct(product);
}

var result = _productService.InsertProduct(product);
if (!result)
{
    //enqueue - keep trying 
    new Action<Product>(ExecutableMethod).Invoke(product);
    var productQueue = new Generator<Product>(ExecutableMethod);
    productQueue.Create(product);
}

```
