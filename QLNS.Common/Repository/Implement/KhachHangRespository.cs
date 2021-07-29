using QLNS.Data.Context;
using QLNS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.Common.Repository.Implement
{
    public class KhachHangRespository
    {
        private DBContext db = new DBContext();
        public IEnumerable<M_KHACH_HANG> GetAll()
        {
            var data = db.M_KHACH_HANG.ToList();
            return data;
        }

        public bool Insert(M_KHACH_HANG kh)
        {
            db.M_KHACH_HANG.Add(kh);
            db.SaveChanges();
            return true;
        }
    }
}
