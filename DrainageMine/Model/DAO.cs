using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.GridFS;
using MongoDB.Driver.Linq;
using DrainageMine.Controller;
using System.Windows.Forms;

namespace DrainageMine
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
            collection = database.GetCollection<DrainageMine.Controller.Tuple>("tuples");

        }

        public void addTuple(DrainageMine.Controller.Tuple tuple){
            collection.Insert(tuple);
            var id = tuple.Id; // Insert will set the Id if necessary (as it was in this example)


        }

        public DrainageMine.Controller.Tuple getTuple(string filter)
        {
            try
            {
                var tuple = collection.AsQueryable<DrainageMine.Controller.Tuple>().Where(Tuple => Tuple.Arguments.Contains(filter)).First();
                return tuple;

            }
            catch (InvalidOperationException)
            {
                return null;
            }

        }

        public void deleteTuple(DrainageMine.Controller.Tuple tuple)
        {
            var query = Query<DrainageMine.Controller.Tuple>.EQ(e => e.Id, tuple.Id);
            collection.Remove(query);
        }

        public void updateTuple(string filter, string arguments)
        {
            var tupleAModifier = getTuple(filter);
 
            if (tupleAModifier != null)
            {
                var query = Query<DrainageMine.Controller.Tuple>.EQ(e => e.Id, tupleAModifier.Id);
                var update = Update<DrainageMine.Controller.Tuple>.Set(e => e.Arguments, arguments); // update modifiers
                collection.Update(query, update);
            }
            else
            
            {
                this.addTuple(new DrainageMine.Controller.Tuple(arguments));
            }
        }
    }
}
