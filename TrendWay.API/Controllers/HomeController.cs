using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TrendWay.BLL.Repositories;
using TrendWay.BOL.Entities;

namespace TrendWay.API.Controllers
{
    public class HomeController : ApiController
    {
        Repository<Brand> repoBrand = new Repository<Brand>();

        [HttpGet]
        public IEnumerable<Brand>GetBrands()
        {
            return repoBrand.GetAll().ToList();
        }
    }
}
