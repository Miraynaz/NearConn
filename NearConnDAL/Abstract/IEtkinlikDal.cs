using NearConnEL;
using System;
using System.Collections.Generic;
using System.Text;

namespace NearConnDAL.Abstract
{
    public interface IEtkinlikDal:IRepository<tbl_Etkinlik>
    {
        tbl_Etkinlik GetTbl_EtkinlikDetails(int id);
    }
}
