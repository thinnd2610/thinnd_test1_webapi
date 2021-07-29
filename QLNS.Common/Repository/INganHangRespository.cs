using QLNS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.Common.Repository
{
    public interface INganHangRespository
    {
        IEnumerable<DM_NGAN_HANG> GetAll();
        bool Insert(DM_NGAN_HANG nh);
    }
}
