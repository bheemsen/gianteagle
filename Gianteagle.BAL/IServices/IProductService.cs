using Gianteagle.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gianteagle.BAL.IServices
{
    public interface IProductService
    {
        Product GetProduct(long upcCode);

        List<Product> GetProducts();

        void RefreshProducts();
    }
}
