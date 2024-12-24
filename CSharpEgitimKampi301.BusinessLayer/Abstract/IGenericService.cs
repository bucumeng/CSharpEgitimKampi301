using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.BusinessLayer.Abstract
{
    public interface IGenericService <T> where T : class
    {
        void TInsert(T entitiy);
        void TUpdate(T entitiy);
        void TDelete(T entity);
        List<T> TGetAll();
        T TGetById(int id);

        //Presentationda çağırmak için bunları kullanıcaz
        // data access e tamamen erişim sağlanmayacak bir köprü görevi görerek bağlantı kuracağız.
        // data access katmanındaki metotlarla business layer katmanındaki metotlar karışmasın diye t ekledik başına.
    }
}
