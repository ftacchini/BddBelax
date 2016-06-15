using ProjectoParaElCurso1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ProjectoParaElCurso1.Controllers
{
    public class HistoryController : ApiController
    {
        public IEnumerable<OperationResult> GetHistory(int count)
        {
            return InMemoryDb.Get(count);
        }
    }
}