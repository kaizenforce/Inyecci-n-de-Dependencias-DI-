using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;

namespace InjectionDependency
{
    public class MyService
    {

        private readonly IRepository _repository;

       public MyService(IRepository repository)
        {

            _repository = repository;

        }

        public string GetData(){
            return _repository.GetData();
        }

        public bool Save() {
            return _repository.Save();
        }
    }
}
