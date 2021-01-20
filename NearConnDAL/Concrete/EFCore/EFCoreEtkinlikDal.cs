using Microsoft.EntityFrameworkCore;
using NearConnDAL.Abstract;
using NearConnEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace NearConnDAL.Concrete.EFCore
{
    public class EFCoreEtkinlikDal : EFCoreGenericRepository<tbl_Etkinlik, NearConnContext>, IEtkinlikDal
    {
        public tbl_Etkinlik GetTbl_EtkinlikDetails(int id)
        {
           using (var context=new NearConnContext())
            {
                return context
                    .tbl_Etkinlik.Where(i => i.EtkinlikId == id)
                    .Include(i => i.KullaniciEtkinliks)
                    .ThenInclude(i => i.Kullanici)
                    .FirstOrDefault();
            }
        }
    }
}
