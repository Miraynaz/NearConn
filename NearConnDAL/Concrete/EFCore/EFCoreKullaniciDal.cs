using NearConnDAL.Abstract;
using NearConnEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace NearConnDAL.Concrete.EFCore
{
    public class EFCoreKullaniciDal : EFCoreGenericRepository<tbl_Kullanici,NearConnContext>,IKullaniciDal
    {
       
    }
}
