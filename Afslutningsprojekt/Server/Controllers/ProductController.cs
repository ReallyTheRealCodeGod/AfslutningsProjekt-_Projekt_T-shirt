using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Afslutningsprojekt.Server.Controllers
{
    /*The two attributes, Route is using the url to parse information. 
     * And ApiController is indicating that is used to serve API responeses using http*/
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly DataContext _context;

        public ProductController(DataContext context)
        {
           _context = context;
        }

        public DataContext Context { get; }

        /*Used for implementing a get method*/
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProduct()
        {
            /*"Ok" produces status code 200 http response*/
            var products = await _context.Products.ToListAsync();
            return Ok(products);      
        }
    }
}
