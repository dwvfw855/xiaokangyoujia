using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mk.Chain.Core.IServices;
using Mk.Chain.Core.Models;

namespace Mk.Chain.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //private readonly IChargeLogsServices _ChargeLogsServices;

        //private readonly ITaskServices _TaskServices;
        
        public ValuesController()
        {
           // _FILESServices = FILESServices;


        }
        // GET api/values
        [HttpGet]
        public ActionResult Get()
        {

            // List<ChargeLogs>   List= _ChargeLogsServices.Getlist();
           
            return Ok();



        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
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
