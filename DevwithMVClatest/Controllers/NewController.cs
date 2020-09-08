using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DevwithMVClatest.Models;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
namespace DevwithMVClatest.Controllers
{
    public class NewController : ApiController
    {
        // GET: New
        //public ActionResult Index()
        //{
        //    return View();
        //}


        private testDBEntities _context = new testDBEntities();
        [HttpGet]
        public HttpResponseMessage Get(DataSourceLoadOptions loadOptions)
        {
            var tests = _context.tests.Select(i => new {
                i.Id,
                i.Description
            });

            return Request.CreateResponse(DataSourceLoader.LoadAsync(tests, loadOptions));
          //  return Request.CreateResponse(DataSourceLoader.Load(SampleData.Orders, loadOptions));
        }
        //public async Task<HttpResponseMessage> Get(DataSourceLoadOptions loadOptions)
        //{
        //    var tests = _context.tests.Select(i => new {
        //        i.Id,
        //        i.Description
        //    });

        //    return Request.CreateResponse(await DataSourceLoader.LoadAsync(tests, loadOptions));
        //}

    }
}