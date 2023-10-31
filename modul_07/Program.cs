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
        }
    }
}