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

        public void lindaOut( DrainageMine.Model.Tuple tuple )
        {
            dao.addTuple(tuple);
        }

        public void lindaAdd( string filter, DrainageMine.Model.Tuple tuple )
        {
            dao.updateTuple(filter, tuple.Arguments);
        }


        public DrainageMine.Model.Tuple lindaIn(string filter){
            while (dao.getTuple(filter) == null);
            DrainageMine.Model.Tuple tuple = dao.getTuple(filter);
            dao.deleteTuple(tuple);
            return tuple;
        }

        public DrainageMine.Model.Tuple lindaRead(string filter)
        {
            while (dao.getTuple(filter) == null);
            return dao.getTuple(filter);
        }

        public Tuple lindaReadP(string filter)
        {
            return dao.getTuple(filter);
        }
    }
}
