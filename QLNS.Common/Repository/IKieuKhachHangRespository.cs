using QLNS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.Common.Repository
{
    public interface IKieuKhachHangRespository
    {
        IEnumerable<DM_KIEU_KHACH_HANG> GetAll();
        bool Insert(DM_KIEU_KHACH_HANG kieu);
    }
}
