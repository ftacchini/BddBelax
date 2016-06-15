using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectoParaElCurso1.Models
{
    public static class InMemoryDb
    {
        private static List<OperationResult> Operations = new List<OperationResult>();

        public static void Add(OperationResult operation)
        {
            Operations.Insert(0, operation);
        }

        public static IEnumerable<OperationResult> Get(int count)
        {
            return Operations.Take(count);
        }
    }
}