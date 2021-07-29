using QLNS.Data.Context;
using QLNS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.Common.Repository.Implement
{
    public class NganHangRespository
    {
        private DBContext db = new DBContext();
        public IEnumerable<DM_NGAN_HANG> GetAll()
        {
            var data = db.DM_NGAN_HANG.ToList();
            return data;
        }

        public bool Insert(DM_NGAN_HANG nh)
        {
            db.DM_NGAN_HANG.Add(nh);
            db.SaveChanges();
            return true;
        }
    }
}
