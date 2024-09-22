
namespace Catalog.API.Products.GetProductById
{
    public record GetProductByIdRequest(Guid Id) : IQuery<GetProductByIdResult>;
    public record GetProductByIdResponse(Product Products);
    public class GetProductByIdEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            throw new NotImplementedException();
        }
    }
}
