using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;


namespace InjectionDependency
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Carga el container "repository" donde declaramos la implementación 
            // de IRepository que queremos utilizar
            IUnityContainer container = new UnityContainer();
            container.LoadConfiguration("repository");

            //Le decimos a Unity que resuelva la implementacion
            MyService service = new MyService(container.Resolve<IRepository>());

            //Llamamos al metodo del servicio

            Console.WriteLine(service.GetData());

            Console.ReadKey();


        }
    }
}
