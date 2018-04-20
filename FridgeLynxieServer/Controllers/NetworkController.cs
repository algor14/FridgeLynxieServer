using LynxieDatabaseProvider2.Models;
using LynxieDatabaseProvider2.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FridgeLynxieServer.Controllers
{
    public class NetworkController : ApiController
    {
        private NetworkDatabaseRepository repo;

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        public IHttpActionResult GiveMeNetwork(string name, string pass)
        {
            var repo = new NetworkDatabaseRepository();
            var networkToReturn = repo.GetNetworkByName(name, pass);
            if (networkToReturn != null)
                return Content<Network>(HttpStatusCode.Found, networkToReturn);
            else
                return Content<Network>(HttpStatusCode.NotFound, null);
        }
        // GET api/<controller>/5
        //[HttpGet]
        //public IHttpActionResult GetNetwork(string name, string pass)
        //{
        //    var repo = new NetworkDatabaseRepository();
        //    var networkToReturn = repo.GetNetworkByName(name, pass);
        //    if (networkToReturn != null)
        //        return Content<Network>(HttpStatusCode.Found, networkToReturn);
        //    else
        //        return Content<Network>(HttpStatusCode.NotFound, null);
        //}

        // POST api/<controller>
        [HttpPost]
        public IHttpActionResult CreateNewNetwork([FromBody]Network item)
        {
            repo = new NetworkDatabaseRepository();
            Network networkToReturn = repo.CreateNewNetwork(item);
            return Content<Network>(HttpStatusCode.Created, networkToReturn);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}