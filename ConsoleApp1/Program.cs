using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Client client = new Client();
            client.CreateDate = DateTime.Now;
            client.Dob = new DateTime(1988, 11, 01);
            client.Email = "";

        }
    }
}
