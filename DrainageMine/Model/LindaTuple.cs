using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrainageMine.Model
{

    class LindaTuple
    {
        private string tuple;

        public ObjectId Id { get; set; }

        public string Arguments { get; set;}

        public LindaTuple( List<string> arguments )
        {

            this.Arguments = arguments[0];
            for ( int i=1; i < arguments.Count; i++ ){
                this.Arguments += "," + arguments[i];
            }
        }

        public LindaTuple(string tuple)
        {
            this.tuple = tuple;
        }



    }
}
