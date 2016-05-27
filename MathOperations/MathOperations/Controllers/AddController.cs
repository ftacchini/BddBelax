using ProjectoParaElCurso1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectoParaElCurso1.Controllers
{
    public class AddController : ApiController
    {
        public IHttpActionResult PostAdd(Operation operation)
        {
            return Ok(operation.Number1 + operation.Number2);
        }
    }
}
