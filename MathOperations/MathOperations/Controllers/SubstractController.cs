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
            return Ok(operation.Number1 - operation.Number2);
        }
    }
}