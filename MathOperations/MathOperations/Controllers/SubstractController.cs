using ProjectoParaElCurso1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ProjectoParaElCurso1.Controllers
{
    public class SubstractController : ApiController
    {
        public IHttpActionResult PostSubstract(Operation operation)
        {
            var result = operation.Number1 - operation.Number2;
            var operationResult = new OperationResult { Operation = operation, Result = result, Operator = "-" };
            InMemoryDb.Add(operationResult);

            return Ok(operationResult.Result);
        }
    }
}