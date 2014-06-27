using System.Collections.Generic;
using System.Web.Http;
using VStorm.Models;

namespace VStorm.Controllers
{

    public class ValuesController : ApiController
    {
        private readonly IValuesProvider _provider;

        public ValuesController(IValuesProvider provider)
        {
            _provider = provider;
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            return _provider.GetValues();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
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