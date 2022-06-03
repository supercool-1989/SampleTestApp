using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleTestWebAPI.Modals
{
    public class OfferService
    {
        private List<Product> Inventory { get; set; }

        private List<Product> InvestoryData
        {
            get
            {
                return new List<Product>{
                    new Product("p1", 000, "p1 desc"),
                    new Product("p2", 200, "p2 desc"),
                    new Product("p3", 300, "p3 desc"),
                    new Product("p4", 400, "p4 desc"),
                    new Product("p5", 500, "p5 desc"),
                    new Product("p6", 600, "p6 desc")
                    };
            }
        }

        OfferService()
        {
            Inventory = InvestoryData;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await Task.FromResult(Inventory);
        }

        public async Task<List<Product>> GetTodaysOffers()
        {
            return await Task.FromResult(Inventory.Take(3).ToList());
        }        
    }
}
