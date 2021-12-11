using System.Collections.Generic;
using Sitecore.Data;
using Sitecore.Data.Items;

namespace Music10.Feature.Products.Services
{
    public interface IProductRepository
    {
        IEnumerable<Item> GetProducts(Item parent);
    }
}
