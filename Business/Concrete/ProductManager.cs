using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        //Veri erişim katmanını çağıracağız. Burada karşımıza dependcy inj. çıkmakta. sitemi değiştirmek veya iki sistemle(DAL) çalıştığımızda sıkıntı çıkabilir. Yani ORM'i değiştirmek için  bağımlılığı soyutlaştırmak lazım.


        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public Product GetById(int productId)
        {
           return _productDal.Get(p => p.ProductID == productId);
        }

        public List<Product> GetList()
        {
            return _productDal.GetList().ToList();
        }

        public List<Product> GetListByCategory(int categoryId)
        {
            return _productDal.GetList(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
