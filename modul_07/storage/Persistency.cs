using System;
using MongoDB.Bson;
using MongoDB.Driver;

namespace modul_07
{
    public class Persistency
    {
        // KIG HER: hvis du igang med at stjæle min kode fra GitHub:
        // Her indsætter du egen string samt password fra MongoDB // whatever SQL-program du bruger
        // I MongoDB: Deployment --> Database --> find din database --> Connect --> MongoDB for VS Code --> kopier streng og indsæt password
        private string connectionString = "mongodb+srv://gustavrosell:Gustav41541@dbdesign.q2bkeja.mongodb.net/";

        // HUSK: Using MongoDB.Driver; Using MongoDB.Bson;
        IMongoClient dbClient;
        IMongoDatabase database;
        IMongoCollection<BsonDocument> collection;


        // Constructor
        public Persistency()
        {
            dbClient = new MongoClient();
            database = dbClient.GetDatabase("ansattedb");
            collection = database.GetCollection<BsonDocument>("projects");
        }

        public void opretansatte(BsonDocument ansatte)
        {
            collection.InsertOne(ansatte);
        }

        public List<BsonDocument> GetAnsatte()
        {
            return collection.Find(new BsonDocument()).ToList();
        }
    }
}