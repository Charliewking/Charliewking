using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.AspNetCore.Mvc;
using MTGDatabase.Models;
using Microsoft.WindowsAzure.Storage.Table;
using MTGCardDatabase.Models;
using CWKAngular.Utilities;

namespace CWKAngular.Controllers
{
    [Produces("application/json")]
    [Route("api/Accomplishment")]
    public class AccomplishmentController : Controller
    {
        private readonly DocumentsUtility util = new DocumentsUtility();
        private readonly WebConfiguration config;
        private readonly TableContinuationToken token;
        //private TableStorageUtility _utility;

        // GET: api/Accomplishment
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            TableQuerySegment<CardEntity> returnValue = await util.GetCloudTable(config.cardTableName).ExecuteQuerySegmentedAsync(new TableQuery<CardEntity>().Take(100), token);

            CollectionReturnObject returnObject = new CollectionReturnObject
            {
                ReturnList = returnValue.ToList(),
                Token = returnValue.ContinuationToken
            };

            return Ok(returnObject);
        }

        // GET: api/Accomplishment/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Accomplishment
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Accomplishment/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
