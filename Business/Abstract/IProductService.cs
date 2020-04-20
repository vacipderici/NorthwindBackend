using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IProductService
    {
        List<Product> GetList();
        List<Product> GetListByCategory(int categoryId);

        void Add(Product product);

        void Delete(Product product);
        void Update(Product product);

        Product GetById(int productId);

    }
}
