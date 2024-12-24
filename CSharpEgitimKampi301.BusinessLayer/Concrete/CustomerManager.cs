using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System.Collections.Generic;


namespace CSharpEgitimKampi301.BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public void TDelete(Customer entity)
        {
            _customerDal.Delete(entity);
        }

        public List<Customer> TGetAll()
        {
            // if(yetki varsa)
            // {
            // listeleme yap
            // }
           // else {
           //  uyarı ver
           // }

            return _customerDal.GetAll();
        }

        public Customer TGetById(int id)
        {
            return _customerDal.GetById(id);
        }

        public void TInsert(Customer entitiy)
        {
            if (entitiy.CustomerName != " " && entitiy.CustomerSurname.Length >= 3 && entitiy.CustomerCity != null && entitiy.CustomerSurname != "" && entitiy.CustomerName.Length <= 36)
            {
                _customerDal.Insert(entitiy);
            }
            else
            {
                // hata mesajı
            }
        }
      
        public void TUpdate(Customer entitiy)
        {
            _customerDal.Update(entitiy);
        }

     
  
    }
}
