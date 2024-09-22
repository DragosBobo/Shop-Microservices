namespace Catalog.API.Excetions
{
    public class ProductNotFoundException : Exception
    {
        public ProductNotFoundException() : base("Product not found!") 
        {
            
        }
    }
}
