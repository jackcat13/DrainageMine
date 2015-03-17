using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrainageMine.Model
{
    class Linda
    {

        private DAO dao;

        public Linda()
        {
            dao = new DAO();
        }

        public void lindaOut( Tuple tuple )
        {
            dao.addTuple(tuple);
        }

        public void lindaAdd( string filter, Tuple tuple )
        {
            dao.updateTuple(filter, tuple.Arguments);
        }


        public Tuple lindaIn(string filter){
            while (dao.getTuple(filter) == null);
            Tuple tuple = dao.getTuple(filter);
            dao.deleteTuple(tuple);
            return tuple;
        }

        public Tuple lindaRead(string filter)
        {
            while (dao.getTuple(filter) == null);
            return dao.getTuple(filter);
        }

    }
}
