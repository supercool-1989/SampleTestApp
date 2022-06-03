using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SampleTestWebAPI.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleTestWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductAPIController : ControllerBase
    {    
        private readonly OfferService _offer;
        public ProductAPIController(OfferService offer)
        {
            _offer = offer;
        }

        [HttpGet]
        public async Task<List<Product>> GetTodaysOffers()
        {
            var result = await _offer.GetTodaysOffers();
            return result;
        }

        [HttpGet]
        public async Task<List<Product>> GetAllProducts()
        {
            var result = await _offer.GetAllProducts();
            return result.ToList().OrderBy(p => p.Price).Take(3).ToList();
        }

        [HttpGet]
        public async Task<Product> GetAllProductsData()
        {
            var result = await _offer.GetAllProducts();
            return result.OrderBy(p => p.Price).ToArray()[1];
        }

        [HttpPost]
        public bool AddProduct()
        {
            //call service method.
            return true;
        }
    }
}
