using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiServer;

namespace WebApiServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext dataContext;

        public ValuesController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var allDataItems = this.dataContext.DataItem.AsQueryable().ToList();
            return Ok(allDataItems);
            //return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<DataItem> Get(int id)
        {
            var dataItem = new DataItem("michael", "this is first net core storage call");
            this.dataContext.DataItem.Add(dataItem);
            this.dataContext.SaveChanges();
            return dataItem;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
