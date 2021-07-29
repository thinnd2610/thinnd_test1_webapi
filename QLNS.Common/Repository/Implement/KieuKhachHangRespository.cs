using QLNS.Data.Context;
using QLNS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.Common.Repository.Implement
{
    public class KieuKhachHangRespository
    {
        private DBContext db = new DBContext();
        public IEnumerable<DM_KIEU_KHACH_HANG> GetAll()
        {
            var data = db.DM_KIEU_KHACH_HANG.ToList();
            return data;
        }

        public bool Insert(DM_KIEU_KHACH_HANG kieu)
        {
            db.DM_KIEU_KHACH_HANG.Add(kieu);
            db.SaveChanges();
            return true;
        }
    }
}
