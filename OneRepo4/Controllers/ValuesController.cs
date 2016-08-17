using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OneRepo.Controllers;

namespace OneRepo4.Controllers
{
    public class ValuesController : ApiController
    {
        private RepoItemContext context;

        ValuesController()
        {
            context = new RepoItemContext();
        }

        // GET api/values
        public IEnumerable<RepoItem> Get()
        {
            return context.RepoItems;
        }

        // GET api/values/5
        public RepoItem Get(int id)
        {
            return context.RepoItems.SingleOrDefault(r => r.Id == id);
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
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