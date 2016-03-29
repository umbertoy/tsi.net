using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    static class MongoDBUtil
    {
        public static IMongoDatabase getMongoDB()
        {
            SqlConnectionStringBuilder connectionString = new SqlConnectionStringBuilder(ConfigurationManager.ConnectionStrings["MongoDB"].ConnectionString);
            MongoClient mc = new MongoClient(connectionString.DataSource);
            IMongoDatabase database = mc.GetDatabase(connectionString.InitialCatalog);
            return database;
        }


        public static Int32 getNextSequence(String sequenceName)
        {
            IMongoDatabase database = MongoDBUtil.getMongoDB();
            IMongoCollection<BsonDocument> collection = database.GetCollection<BsonDocument>("SequenceCollection");

            var cmd = collection.Database.RunCommand<BsonDocument>(new BsonDocument("eval", "getNextSequence(\""+sequenceName+"\")"));

            return Convert.ToInt32(cmd["retval"].AsDouble);
        }
    }
}
