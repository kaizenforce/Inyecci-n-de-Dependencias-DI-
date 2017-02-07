using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InjectionDependency
{
   public class SQLRepository : IRepository
    {

        public string GetData() { 
            return "Get Data from SQL repository.";
        }


        public bool Save()
        {
            return true;
        }

    }
}
