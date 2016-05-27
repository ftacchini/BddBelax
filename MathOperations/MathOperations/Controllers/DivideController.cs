using ProjectoParaElCurso1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectoParaElCurso1.Controllers
{
    public class DivideController : ApiController
    {
        public IHttpActionResult PostDivide(Operation operation)
        {
            return Ok(operation.Number1 / operation.Number2);
        }
    }
}
