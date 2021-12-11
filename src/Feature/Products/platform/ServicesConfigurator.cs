﻿using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using Sitecore.LayoutService.Serialization.ItemSerializers;

namespace Music10.Feature.Products
{
    public class ServicesConfigurator : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<Services.IProductRepository, Services.ProductRepository>();
        }
    }
}