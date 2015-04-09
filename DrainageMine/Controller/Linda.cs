using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrainageMine.Model;

namespace DrainageMine.Controller
{
    class Linda
    {

        private DAO dao;

        public Linda()
        {
            dao = new DAO();
        }

        public void lindaOut( LindaTuple tuple )
        {
            dao.addTuple(tuple);
        }

        public void lindaAdd( string filter, LindaTuple tuple )
        {
            dao.updateTuple(filter, tuple.Arguments);
        }


        public LindaTuple lindaIn(string filter){
            while (dao.getTuple(filter) == null);
            LindaTuple tuple = dao.getTuple(filter);
            dao.deleteTuple(tuple);
            return tuple;
        }

        public LindaTuple lindaRead(string filter)
        {
            while (dao.getTuple(filter) == null);
            return dao.getTuple(filter);
        }

        public LindaTuple lindaReadP(string filter)
        {
            return dao.getTuple(filter);
        }
    }
}
