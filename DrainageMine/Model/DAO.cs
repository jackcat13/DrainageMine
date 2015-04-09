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
using DrainageMine.Model;
using System.Windows.Forms;

namespace DrainageMine
{
    class DAO
    {

        SqlConnection conn;
        string connectionString = "mongodb://localhost";
        MongoCollection collection;
        

        public DAO()
        {
            MongoClient client = new MongoClient(connectionString);
            MongoServer server = client.GetServer();
            MongoDatabase database = server.GetDatabase("EspaceTuples");
            collection = database.GetCollection<DrainageMine.Model.Tuple>("tuples");

        }

        public void addTuple(DrainageMine.Model.Tuple tuple){
            collection.Insert(tuple);
            var id = tuple.Id; // Insert will set the Id if necessary (as it was in this example)


        }

        public DrainageMine.Model.Tuple getTuple(string filter)
        {
            try
            {
                var tuple = collection.AsQueryable<DrainageMine.Model.Tuple>().Where(Tuple => Tuple.Arguments.Contains(filter)).First();
                return tuple;

            }
            catch (InvalidOperationException)
            {
                return null;
            }

        }

        public void deleteTuple(DrainageMine.Model.Tuple tuple)
        {
            var query = Query<DrainageMine.Model.Tuple>.EQ(e => e.Id, tuple.Id);
            collection.Remove(query);
        }

        public void updateTuple(string filter, string arguments)
        {
            var tupleAModifier = getTuple(filter);
 
            if (tupleAModifier != null)
            {
                var query = Query<DrainageMine.Model.Tuple>.EQ(e => e.Id, tupleAModifier.Id);
                var update = Update<DrainageMine.Model.Tuple>.Set(e => e.Arguments, arguments); // update modifiers
                collection.Update(query, update);
            }
            else
            
            {
                this.addTuple(new DrainageMine.Model.Tuple(arguments));
            }
        }
    }
}
