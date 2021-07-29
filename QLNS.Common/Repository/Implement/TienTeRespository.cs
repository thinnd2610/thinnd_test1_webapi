using QLNS.Data.Context;
using QLNS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.Common.Repository.Implement
{
    public class TienTeRespository
    {
        private DBContext db = new DBContext();
        public IEnumerable<DM_TIEN_TE> GetAll()
        {
            var data = db.DM_TIEN_TE.ToList();
            return data;
        }

        public bool Insert(DM_TIEN_TE tt)
        {
            db.DM_TIEN_TE.Add(tt);
            db.SaveChanges();
            return true;
        }
    }
}
