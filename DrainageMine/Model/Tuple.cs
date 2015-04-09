using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrainageMine.Controller
{

    class Tuple
    {
        private string tuple;

        public ObjectId Id { get; set; }

        public string Arguments { get; set;}

        public Tuple( List<string> arguments )
        {

            this.Arguments = arguments[0];
            for ( int i=1; i < arguments.Count; i++ ){
                this.Arguments += ", " + arguments[i];
            }
        }

        public Tuple(string tuple)
        {
            this.tuple = tuple;
        }

    }
}
