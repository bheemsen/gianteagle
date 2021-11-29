using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gianteagle.Entities
{
    public class Product
    {
        public int StoreNumber { get; set; }
        public long UPC { get; set; }
        public char WeightorPriceRequired { get; set; }
        public char QuantityAllowed { get; set; }
        public char PriceRequiredFlag { get; set; }
        public char NotForSaleFlag { get; set; }
        public char Tax1RateFlag { get; set; }
        public char Tax2RateFlag { get; set; }
        public char FoodStampFlag { get; set; }
        public char EMPoints { get; set; }
        public int ItemType { get; set; }
        public int PricingMethod { get; set; }
        public int Department { get; set; }
        public int Familymembers { get; set; }
        public string MPGroup { get; set; }
        public int SaleQuantity { get; set; }
        public int Price { get; set; }
        public int LinkTo { get; set; }
        public string ItemName { get; set; }
        public int RestrictedSale { get; set; }
        public char WICFlag { get; set; }
        public char ItemAddedFlag { get; set; }
        public int Tare { get; set; }
        public char FoodPerks { get; set; }
        public char QHPFlag { get; set; }
        public char RXFlag { get; set; }
        public long LargeLinkedTo { get; set; }
        public char ProductRecallFlag { get; set; }
        public char Space { get; set; }
        public string CRLF { get; set; }

    }
}
