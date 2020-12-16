using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Demo_doan.Models
{
    public class Context:DbContext
    {
        public Context() : base(nameOrConnectionString: "DemoQLHTGTConnection")
        {

        }
        public DbSet<NguoiDangKyXe> NguoiDangKyXes { get; set; }
    }
}