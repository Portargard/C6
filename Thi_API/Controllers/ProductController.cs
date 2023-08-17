using Microsoft.AspNetCore.Mvc;
using Thi_API.Services;
using Thi_API.Services.IServices;
using Thi_Data.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Thi_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController()
        {
            _productService = new ProductService();
        }
        // GET: api/<ProductController>
        [HttpGet("GetAll")]
        public IEnumerable<Product> Get()
        {
            return _productService.GetAll();
        }

        // GET api/<ProductController>/5
        [HttpGet("GetById/{id}")]
        public Product Get(Guid id)
        {
            return _productService.GetById(id);
        }

        // POST api/<ProductController>
        [HttpPost("Add")]
        public void Post([FromBody] Product value)
        {
            _productService.Add(value);
        }

        // PUT api/<ProductController>/5
        [HttpPut("Update")]
        public void Put([FromBody] Product value)
        {
            _productService.Update(value);
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("Delete/{id}")]
        public void Delete(Guid id)
        {
            _productService.Delete(id);
        }
    }
}
