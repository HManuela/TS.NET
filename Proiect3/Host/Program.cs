using System;
using System.ServiceModel;
using ServiceWCF;
using WindowsFormsMyPhotos;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Diagnostics;
using System.ServiceModel.Description;


namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Launch WCF server...");
            MyPhotos host = new MyPhotos(typeof(MyPhotos), new Uri("http://localhost:8000/WindowsFormsMyPhotos"));

            foreach (ServiceEndpoint se in host.Description.Endpoints)
                Console.WriteLine("A (address): {0} \nB (binding): {1} \nC(Contract): {2}\n", se.Address, se.Binding.Name, se.Contract.Name);

            host.Open();

            Console.WriteLine("Server in execution. Connections are expected...");
            Console.WriteLine("Press Enter to stop the server!");
            Console.ReadKey();

            host.Close();
        }
    }
}
