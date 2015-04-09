using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.GridFS;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrainageMine.Model
{
    class DAO
    {

        string connectionString = "mongodb://localhost";
        MongoCollection collection;
        

        public DAO()
        {
            MongoClient client = new MongoClient(connectionString);
            MongoServer server = client.GetServer();
            MongoDatabase database = server.GetDatabase("EspaceTuples");
            collection = database.GetCollection<LindaTuple>("tuples");

        }

        public void addTuple(LindaTuple tuple){
            try
            {
                collection.Insert(tuple.Arguments);
                var id = tuple.Id; // Insert will set the Id if necessary (as it was in this example)
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }

        public LindaTuple getTuple(string filter)
        {
            try
            {
                var tuple = collection.AsQueryable<LindaTuple>().Where(Tuple => Tuple.Arguments.Contains(filter)).First();
                return tuple;

            }
            catch (InvalidOperationException)
            {
                return null;
            }

        }

        public void deleteTuple(LindaTuple tuple)
        {
            var query = Query<LindaTuple>.EQ(e => e.Id, tuple.Id);
            collection.Remove(query);
        }

        public void updateTuple(string filter, string arguments)
        {
            var tupleAModifier = getTuple(filter);
 
            if (tupleAModifier != null)
            {
                var query = Query<LindaTuple>.EQ(e => e.Id, tupleAModifier.Id);
                var update = Update<LindaTuple>.Set(e => e.Arguments, arguments); // update modifiers
                collection.Update(query, update);
            }
            else
            
            {
                this.addTuple(new LindaTuple(arguments));
            }
        }
    }
}
