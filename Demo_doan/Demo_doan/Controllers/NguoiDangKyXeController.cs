﻿using Demo_doan.Models;
using Demo_doan.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Demo_doan.Controllers
{
    public class NguoiDangKyXeController : ApiController
    {
        NguoiDangKyXeRepository ng = new NguoiDangKyXeRepository();
        // GET api/values
        public IEnumerable<NguoiDangKyXe> Get()
        {
            return ng.findAll();
        }

        // GET api/values/5
        public NguoiDangKyXe Get(int id)
        {
            return ng.findById(id);
        }

        // POST api/values
        public void Post([FromBody]NguoiDangKyXe nguoiDangKyXe)
        {
            ng.add(nguoiDangKyXe);
        }

        // PUT api/values/5
        public bool Put([FromBody]NguoiDangKyXe nguoiDangKy)
        {
            return ng.update(nguoiDangKy);
        }

        // DELETE api/values/5
        public bool Delete(int id)
        {
            return ng.delete(id);
        }
    }
}