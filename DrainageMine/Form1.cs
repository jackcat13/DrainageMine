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
        public Form1()
        {
            InitializeComponent();

            //Initialisation des valeurs
            coTextBox.Text = "0";
            chTextBox.Text = "0";
            waterLevelTextBox.Text = "test";
            
            

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

    }
}
