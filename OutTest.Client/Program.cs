using OutTest.Client.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutTest.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client client = new Service.Service1Client();
            string s1, s2, s3;
            var response = client.GetData(out s1, out s2, out s3);
            Console.WriteLine($"{response} - {s1} - {s2} - {s3}");
            Console.ReadLine();
        }
    }
}
