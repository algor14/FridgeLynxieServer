using LynxieDatabaseProvider2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FridgeLynxieServer.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void CreateFoodItem([FromBody]FoodItem item)
        {
            System.Diagnostics.Debug.WriteLine(item.ToString());

            //repo = new HomeAssistantDatabaseRepository();
            //repo.CreateNewFoodItem(item);
            //db.Books.Add(book);
            //db.SaveChanges();
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
