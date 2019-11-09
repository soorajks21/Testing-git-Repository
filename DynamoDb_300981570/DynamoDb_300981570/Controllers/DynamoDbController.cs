using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DynamoDb.Libs.DynamoDb;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DynamoDb_300981570.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DynamoDbController : ControllerBase
    {
        private readonly IDynamoDbExamples _dynamoDbExamples;

        public DynamoDbController(IDynamoDbExamples dynamoDbExamples)
        {
            _dynamoDbExamples = dynamoDbExamples;
        }

        [Route("createtable")]
        public IActionResult CreateDyanamoDbTable()
        {
            return Ok();
        }
    }
}