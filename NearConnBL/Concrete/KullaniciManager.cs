using NearConnBL.Abstract;
using NearConnDAL.Abstract;
using NearConnEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace NearConnBL.Concrete
{
    public class KullaniciManager : IKullaniciService
    {
        private IKullaniciDal _kullaniciDal;
        public void Create(tbl_Kullanici entity)
        {
            _kullaniciDal.Create(entity);
        }

        public void Delete(tbl_Kullanici entity)
        {
            _kullaniciDal.Delete(entity);
        }

        public List<tbl_Kullanici> GetAll(Expression<Func<tbl_Kullanici, bool>> filter = null)
        {
            return _kullaniciDal.GetAll(filter).ToList();
        }

        public tbl_Kullanici GetById(int id)
        {
            return _kullaniciDal.GetById(id);
        }

        public void Update(tbl_Kullanici entity)
        {
            _kullaniciDal.Update(entity);
        }
    }
}
