using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Abstract
{
   public interface ICategoryDal : IGenericDal<Category>
    {
        //Category sınıfı için ekleme silme ıd ye gore getirme işlemlerini hazır hale getirmiş oldum.
    }
}
