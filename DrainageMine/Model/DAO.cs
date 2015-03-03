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

        public DAO()
        {
            minDataSet = new MinageDataSet();
        }

        public void addTuple(string tuple){

            MinageDataSet.EspaceTupleRow row = minDataSet.EspaceTuple.NewEspaceTupleRow();
            row.tuple = tuple;
            minDataSet.EspaceTuple.Rows.Add(row);
            minDataSet.EspaceTuple.AcceptChanges();
        }

        public string getTuple(string filter)
        {

            return (string)minDataSet.EspaceTuple.Select( "tuple LIKE " + filter + "*" )[0][0];
        }

        public void deleteTuple(string filter)
        {

            minDataSet.EspaceTuple.Select("tuple LIKE " + filter + "*")[0].Delete();
            minDataSet.EspaceTuple.AcceptChanges();
        }

        public void updateTuple(string filter, string tuple)
        {

            System.Data.DataRow[] row = minDataSet.EspaceTuple.Select("tuple LIKE " + filter + "*");
            if (row.Length != 0)
            {
                row[0][0] = tuple;
            }
            else
            {
                this.addTuple(tuple);
            }
            minDataSet.EspaceTuple.AcceptChanges();
        }
    }
}
