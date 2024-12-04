using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {

        void Insert(T entitiy);
        void Update(T entitiy);
        void Delete(int id);
        List<T> GetAll();
        T GetById(int id);
        
        //silme ekleme ıd ye gore getirme işlemleri
    }
}
