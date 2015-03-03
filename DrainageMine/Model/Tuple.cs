using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrainageMine.Model
{

    class Tuple
    {

        private string arguments;

        public string Arguments
        {
            get { return arguments; }
            set { arguments = value; }
        }

        public Tuple( List<string> arguments )
        {

            this.arguments = arguments[0];
            for ( int i=1; i < arguments.Count-1; i++ ){
                this.arguments += ", " + arguments[i];
            }
        }

    }
}
