using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleTestWebAPI.Modals
{
    public class Offer
    {
        public string OfferName { get; }
        public List<Product> Products { get; }

        Offer(string offerName, List<Product> products)
        {
            OfferName = offerName;
            Products = products;
        }
    }
}
