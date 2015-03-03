using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrainageMine.Model
{
    class Linda
    {

        DAO dao;

        public Linda()
        {
            dao = new DAO();
        }

        public void lindaOut( Tuple tuple )
        {
            dao.addTuple(tuple.Arguments);
        }

        public void lindaAdd( string filter, Tuple tuple )
        {
            dao.updateTuple(filter, tuple.Arguments);
        }


    }
}
