using DrainageMine.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrainageMine
{
    public partial class Form1 : Form
    {

        private Linda linda;

        public Form1()
        {
            InitializeComponent();
            linda = new Linda();
        }

        private void espaceTupleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.espaceTupleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.minageDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'minageDataSet.EspaceTuple'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.espaceTupleTableAdapter.Fill(this.minageDataSet.EspaceTuple);

        }

        private void setSeuilButton_Click(object sender, EventArgs e)
        {
            List<string> tupleH2O = new List<string>();
            tupleH2O.Add(H2OSeuilHautTextBox.Text);
            Model.Tuple seuilH2OHaut = new Model.Tuple(tupleH2O);
            linda.lindaAdd("value_Seuil_H2O_Haut", seuilH2OHaut);

            List<string> tupleCO = new List<string>();
            tupleCO.Add(COSeuilHautTextBox.Text);
            Model.Tuple seuilCOHaut = new Model.Tuple(tupleCO);
            linda.lindaAdd("value_Seuil_CO_Haut", seuilCOHaut);

            List<string> tupleCH4 = new List<string>();
            tupleCH4.Add(CH4SeuilHautTextBox.Text);
            Model.Tuple seuilCH4Haut = new Model.Tuple(tupleCH4);
            linda.lindaAdd("value_Seuil_CH4_Haut", seuilCH4Haut);
        }


    }
}
