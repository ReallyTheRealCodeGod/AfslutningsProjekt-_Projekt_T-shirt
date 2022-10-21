using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

/*Fatcontrollers vs. ThinControllers 
 Thincontrollers: the controller only handles the data from the client to the service layer
 Fatcontrollers: the controller handles eveything.
 I want a Service layer that handles the datamanipulation vs. having the controller doing the
 data from the client and manipulating the data. 
 */

namespace Afslutningsprojekt.Server.Controllers
{
    /*The two attributes, Route is using the url to parse information. 
     * And ApiController is indicating that is used to serve API responeses using http*/
    /*    [Route("api/[controller]")]
        [ApiController]
        public class ProductController : ControllerBase
        {
            private readonly DataContext _context;

            public ProductController(DataContext context)
            {
               _context = context;
            }

            public DataContext Context { get; }

            *//*Used for implementing a get method*//*
            [HttpGet]
            public async Task<ActionResult<List<Product>>> GetProduct()
            {
                *//*"Ok" produces status code 200 http response*//*
                var products = await _context.Products.ToListAsync();
                return Ok(products);      
            }
        }*/


    /*The two attributes, Route is using the url to parse information. 
    * And ApiController is indicating that is used to serve API responeses using http*/
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public DataContext Context { get; }

        /*        Used for implementing a get method
        */
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProduct()
        {
            /*"Ok" produces status code 200 http response*/

            var result = await _productService.GetProductsAsync();
            return Ok(result);
        }
    }
}
