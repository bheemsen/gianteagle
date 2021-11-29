using Gianteagle.BAL.IServices;
using Gianteagle.Entities;
using Gianteagle.Utilities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Gianteagle.BAL.Services
{
    public class ProductService : IProductService
    {
        private static List<Product> products = new List<Product>();

        private readonly IConfiguration configuration;
        public ProductService(IConfiguration config)
        {
            this.configuration = config;
        }
        public Product GetProduct(long upcCode)
        {
            return products.FirstOrDefault(p => p.UPC == upcCode);
        }

        public List<Product> GetProducts()
        {

            return products.Count > 0 ? products : FillProducts();
        }

        private List<Product> FillProducts()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("StoreNumber", 4);
            dict.Add("UPC", 14);
            dict.Add("WeightorPriceRequired", 1);
            dict.Add("QuantityAllowed", 1);
            dict.Add("PriceRequiredFlag", 1);
            dict.Add("NotForSaleFlag", 1);
            dict.Add("Tax1RateFlag", 1);
            dict.Add("Tax2RateFlag", 1);
            dict.Add("FoodStampFlag", 1);
            dict.Add("EMPoints", 1);
            dict.Add("ItemType", 1);
            dict.Add("PricingMethod", 1);
            dict.Add("Department", 3);
            dict.Add("Familymembers", 6);
            dict.Add("MPGroup", 2);
            dict.Add("SaleQuantity", 2);
            dict.Add("Price", 10);
            dict.Add("LinkTo", 4);
            dict.Add("ItemName", 18);
            dict.Add("RestrictedSale", 2);
            dict.Add("WICFlag", 1);
            dict.Add("ItemAddedFlag", 1);
            dict.Add("Tare", 5);
            dict.Add("FoodPerks", 1);
            dict.Add("QHPFlag", 1);
            dict.Add("RXFlag", 1);
            dict.Add("LargeLinkedTo", 14);
            dict.Add("ProductRecallFlag", 1);
            dict.Add("Space", 1);
            dict.Add("CRLF", 2);

            var fileLines = FileUtility.ReadFile(configuration.GetValue<string>("DatFilePath"));
            fileLines.ForEach(line =>
            {
                Dictionary<string, int> dictSub = new Dictionary<string, int>();
                var previousIndex = 0;
                var product = new Product();
                products.Add(product);
                foreach (var item in dict)
                {
                    dictSub.Add(item.Key, item.Value + previousIndex);

                    var value = previousIndex >= line.Length ? "" : line.Substring(previousIndex, item.Value);

                    var productType = product.GetType();
                    var propType = productType.GetProperty(item.Key);

                    if (propType.PropertyType == typeof(string))
                    {
                        propType.SetValue(product, value, null);
                    }
                    else if (propType.PropertyType == typeof(Int32))
                    {
                        propType.SetValue(product, Convert.ToInt32(value), null);

                    }
                    else if (propType.PropertyType == typeof(Int64))
                    {
                        propType.SetValue(product, Convert.ToInt64(value), null);
                    }
                    else if (propType.PropertyType == typeof(char))
                    {
                        propType.SetValue(product, Convert.ToChar(value), null);
                    }
                    previousIndex = previousIndex + item.Value;
                }
            });
            return products;
        }
        
        public void RefreshProducts()
        {
            
            products = new List<Product>();
        }
    }
}