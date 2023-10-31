using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul_07
{
    public class Program
    {
        static void Main(string[] args)
        {
            var doc = new BsonDocument
            {
                {"Name", "Gustav"},
                {"Email", "Gustavrosell@gmail.com"},
                {"Tlfnr", "31402442"}
            };

            Persistency persistency = new Persistency();
            persistency.opretansatte(doc);

            // tester:

            Console.WriteLine("---- Opretter ny ansat ----\n");
            persistency.opretansatte(doc);

            Console.WriteLine("---- Får alle ansatte: ----\n");
            var result = persistency.GetAnsatte();
            Console.WriteLine(result);
        }
    }
}