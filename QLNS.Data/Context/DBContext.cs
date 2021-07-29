using QLNS.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.Data.Context
{
    public class DBContext:DbContext
    {
        public DBContext(): base("ConnectionString") { }
        public DbSet<M_KHACH_HANG> M_KHACH_HANG { get; set; }
        public DbSet<DM_KIEU_KHACH_HANG> DM_KIEU_KHACH_HANG { get; set; }
        public DbSet<DM_NGAN_HANG> DM_NGAN_HANG { get; set; }
        public DbSet<DM_TIEN_TE> DM_TIEN_TE { get; set; }
    }
}
