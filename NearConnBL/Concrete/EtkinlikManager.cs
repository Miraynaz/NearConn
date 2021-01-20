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
    public class EtkinlikManager : IEtkinlikService
    {
        private IEtkinlikDal _etkinlikDal;
        public EtkinlikManager(IEtkinlikDal etkinlikDal)
        {
            _etkinlikDal = etkinlikDal;
        }
        public void Create(tbl_Etkinlik entity)
        {
            _etkinlikDal.Create(entity);
        }

        public void Delete(tbl_Etkinlik entity)
        {
            _etkinlikDal.Delete(entity);
        }

        public List<tbl_Etkinlik> GetAll(Expression<Func<tbl_Etkinlik, bool>> filter=null)
        {
            return _etkinlikDal.GetAll(filter).ToList();
        }

      

        public tbl_Etkinlik GetById(int id)
        {
            return _etkinlikDal.GetById(id);
        }

        public tbl_Etkinlik GetTbl_EtkinlikDetails(int id)
        {
            return _etkinlikDal.GetTbl_EtkinlikDetails(id);
        }

        public void Update(tbl_Etkinlik entity)
        {
            _etkinlikDal.Update(entity);
        }
    }
}
