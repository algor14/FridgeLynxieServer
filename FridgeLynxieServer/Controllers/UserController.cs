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
    public class UserController : ApiController
    {
        private NetworkDatabaseRepository repo;

        // GET api/<controller>
        public IHttpActionResult Get()
        {
            var us = new User()
            {
                Name = "test1",
                //UserId = 23440984,
                NetworkId = 10
            };
            repo = new NetworkDatabaseRepository();
            var userToReturn = repo.CreateNewUser(us);
            return Content<User>(HttpStatusCode.OK, us);
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            //return "value";

            var us = new User()
            {
                Name = "test1",
                UserId = 230984
            };

            return Ok<string>("всьо харашо)");
        }

        // POST api/<controller>
        [HttpPost]
        public IHttpActionResult CreateNewUser([FromBody]User user)
        {
            repo = new NetworkDatabaseRepository();
            var userToReturn = repo.CreateNewUser(user);
            //var responseMessage = new HttpResponseMessage();
            //responseMessage.StatusCode = HttpStatusCode.Created;
            return Content<User>(HttpStatusCode.Created, userToReturn);
            //return Content<string>(HttpStatusCode.Created,"fdgdhffghfgjhfgjfgkkfghndyjutjmnghjgjghjg");
            //return Ok<User>(userToReturn);
            //return Ok<string>($"{userToReturn.UserId} some huuuuge message and bla-bla-bla");

            //var message = Request.CreateResponse(HttpStatusCode.Created, userToReturn);
            //message.Headers.Location = new Uri(Request.RequestUri + userToReturn.UserId.ToString());
            //return message;

        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete]
        public IHttpActionResult DeleteUser(int id)
        {
            if (id <= 0)
                return BadRequest("Not a valid user id");

            repo = new NetworkDatabaseRepository();
            repo.DeleteUser(id);
            repo.DeleteUsersNetwork(id);
            return Ok();
        }
    }
}