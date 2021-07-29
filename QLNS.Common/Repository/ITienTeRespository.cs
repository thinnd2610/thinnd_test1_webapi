using QLNS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.Common.Repository
{
    public interface ITienTeRespository
    {
        IEnumerable<DM_TIEN_TE> GetAll();
        bool Insert(DM_TIEN_TE tt);
    }
}
