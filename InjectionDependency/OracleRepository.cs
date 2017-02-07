using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InjectionDependency
{
    public class OracleRepository : IRepository
    {

        public string GetData()
        {
            return "Get Data from Oracle repository.";
        }

        public bool Save()
        {
            return false;
        }

    }
}
