﻿using System;
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
            while (dao.getTuple(filter) == null) { System.Threading.Thread.Sleep(1000); }
            LindaTuple tuple = dao.getTuple(filter);

            dao.deleteTuple(tuple);
            return tuple;
        }

        public LindaTuple lindaRead(string filter)
        {

            while (dao.getTuple(filter) == null) {System.Threading.Thread.Sleep(1000);}
            LindaTuple tuple = dao.getTuple(filter);
            return tuple;
        }

        public LindaTuple lindaInP(string filter)
        {
            LindaTuple tuple = dao.getTuple(filter);

            if(tuple!=null)dao.deleteTuple(tuple);
            System.Threading.Thread.Sleep(1000);
            return tuple;
        }

        public LindaTuple lindaReadP(string filter)
        {
            System.Threading.Thread.Sleep(1000);
            return dao.getTuple(filter);
        }
    }
}
