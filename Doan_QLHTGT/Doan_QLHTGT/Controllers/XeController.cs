using Doan_QLHTGT.Models;
using Doan_QLHTGT.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Doan_QLHTGT.Controllers
{
    public class XeController : ApiController
    {
        XeRepository xeRepo = new XeRepository();
        // GET api/values
        public IEnumerable<Xe> Get()
        {
            return xeRepo.findAll();
        }

        // GET api/values/5
        public Xe Get(int id)
        {
            return xeRepo.findById(id);
        }

        // POST api/values
        public void Post([FromBody]Xe xe)
        {
            xeRepo.add(xe);
        }
    }
}