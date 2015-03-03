using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrainageMine
{
    class DAO
    {

        private MinageDataSet minDataSet;
        private MinageDataSetTableAdapters.EspaceTupleTableAdapter espaceTupleTableAdaptater;

        public DAO()
        {
            minDataSet = new MinageDataSet();
            espaceTupleTableAdaptater = new MinageDataSetTableAdapters.EspaceTupleTableAdapter();
        }

        public void addTuple(string tuple){
            
            MinageDataSet.EspaceTupleRow row = minDataSet.EspaceTuple.NewEspaceTupleRow();
            row.tuple = tuple;
            minDataSet.EspaceTuple.Rows.Add(row);
            minDataSet.EspaceTuple.AcceptChanges();
            espaceTupleTableAdaptater.Update(minDataSet.EspaceTuple);
        }

        public string getTuple(string filter)
        {
            System.Data.DataRow[] row = minDataSet.EspaceTuple.Select("tuple LIKE '" + filter + "'");
            if (row.Length != 0 && row != null)
                return (string)row[0][0];
            else
                return "No tuple found";
        }

        public void deleteTuple(string filter)
        {

            minDataSet.EspaceTuple.Select("tuple LIKE '" + filter + "'")[0].Delete();
            minDataSet.EspaceTuple.AcceptChanges();
            espaceTupleTableAdaptater.Update(minDataSet.EspaceTuple);
        }

        public void updateTuple(string filter, string tuple)
        {

            System.Data.DataRow[] row = minDataSet.EspaceTuple.Select("tuple LIKE '" + filter + "'");
            if (row.Length != 0 && row != null)
            {
                row[0][0] = tuple;
                minDataSet.EspaceTuple.AcceptChanges();
                espaceTupleTableAdaptater.Update(minDataSet.EspaceTuple);
            }
            else
            {
                this.addTuple(tuple);
            }
        }
    }
}
