﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Doan_QLHTGT.Models
{
    public class NguoiDangKyXe
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public String Name { get; set; }
        public String Address { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int Status { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }
        public virtual ICollection<Xe> Xes { get; set; }
    }
}