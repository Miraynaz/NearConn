using NearConnEL;
using System;
using System.Collections.Generic;
using System.Text;

namespace NearConnBL.Abstract
{
    public interface IEtkinlikService:IGenericService<tbl_Etkinlik>
    {
        tbl_Etkinlik GetTbl_EtkinlikDetails(int id);
    }
}
