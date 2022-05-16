using Afslutningsprojekt.Shared;

namespace Afslutningsprojekt.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        public List<Product> Products { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /*Here the API should be implemented, so the database is connected to the application*/
        public void LoadProducts()
        {
            throw new NotImplementedException();
        }
    }
}
