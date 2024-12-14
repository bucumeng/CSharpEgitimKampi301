using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Repositories;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.EntitiyFrameWork
{
    public class EfAdminDal : GenericRepository<Admin>, IAdminDal
    {
    }
}

/*
 Entity e özgü olmayan metotlar ekle , sil listele ve ıd'ye göre getir.
// İçinde a harfi olmayan kullanıcılar bu entitye özgü bir metot

 */