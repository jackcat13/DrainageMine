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
            dao.addTuple(tuple.Arguments);
        }

        public void lindaAdd( string filter, Tuple tuple )
        {
            dao.updateTuple(filter, tuple.Arguments);
        }


        public string lindaIn(string filter){
            while (dao.getTuple(filter) == "No tuple found");
            string tuple = dao.getTuple(filter);
            dao.deleteTuple(filter);
            return tuple;
        }

        public string lindaRead(string filter)
        {
            while (dao.getTuple(filter) == "No tuple found") ;
            return dao.getTuple(filter);
        }

    }
}
