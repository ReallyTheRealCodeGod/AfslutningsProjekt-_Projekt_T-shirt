using Afslutningsprojekt.Shared;

namespace Afslutningsprojekt.Client.Services.ProductService
{
    public interface IProductService
    {
        List<Product> Products { get; set; }
        void LoadProducts();
    }
}
