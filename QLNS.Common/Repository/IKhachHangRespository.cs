using QLNS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.Common.Repository
{
    public interface IKhachHangRespository
    {
        IEnumerable<M_KHACH_HANG> GetAll();
        bool Insert(M_KHACH_HANG kh);
    }
}
