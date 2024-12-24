using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.BusinessLayer.Concrete
{
    internal class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        
        }

        public void TDelete(Product entity)
        {
            _productDal.Delete(entity);
        }

        public List<Product> TGetAll()
        {
           return _productDal.GetAll();
        }

        public Product TGetById(int id)
        {
           return _productDal.GetById(id);
        }

        public void TInsert(Product entitiy)
        {
            _productDal.Insert(entitiy);
        }

        public void TUpdate(Product entitiy)
        {
            _productDal.Update(entitiy);
        }
    }
}
