using DrainageMine.Controller;
using DrainageMine.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

            try{
                H2OSeuilHautTextBox.Text = linda.lindaReadP("value_Seuil_H2O_Haut").Arguments.Split(',')[1];
                COSeuilHautTextBox.Text = linda.lindaReadP("value_Seuil_CO_Haut").Arguments.Split(',')[1];
                CH4SeuilHautTextBox.Text = linda.lindaReadP("value_Seuil_CH4_Haut").Arguments.Split(',')[1];
                H20ValueTextBox.Text = linda.lindaReadP("niveau_H20").Arguments.Split(',')[1];
                COValueTextBox.Text = linda.lindaReadP("niveau_CO").Arguments.Split(',')[1];
                CH4ValueTextBox.Text = linda.lindaReadP("niveau_CH4").Arguments.Split(',')[1];
            }
            catch(Exception e){
                Console.WriteLine(e);
            }

            Thread capteurCH4 = new Thread(agentCapteurCH4);
            capteurCH4.Start();

            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Closing);
        }


        private void setSeuilButton_Click(object sender, EventArgs e)
        {
            List<string> tupleH2O = new List<string>();
            tupleH2O.Add("value_Seuil_H2O_Haut");
            tupleH2O.Add(H2OSeuilHautTextBox.Text);
            LindaTuple seuilH2OHaut = new LindaTuple(tupleH2O);
            linda.lindaAdd("value_Seuil_H2O_Haut", seuilH2OHaut);

            List<string> tupleCO = new List<string>();
            tupleCO.Add("value_Seuil_CO_Haut");
            tupleCO.Add(COSeuilHautTextBox.Text);
            LindaTuple seuilCOHaut = new LindaTuple(tupleCO);
            linda.lindaAdd("value_Seuil_CO_Haut", seuilCOHaut);

            List<string> tupleCH4 = new List<string>();
            tupleCH4.Add("value_Seuil_CH4_Haut");
            tupleCH4.Add(CH4SeuilHautTextBox.Text);
            LindaTuple seuilCH4Haut = new LindaTuple(tupleCH4);
            linda.lindaAdd("value_Seuil_CH4_Haut", seuilCH4Haut);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Closing(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Êtes-vous sûr de vouloir quitter ?", "Ne partez pas :-(", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }*/

        }

        private void agentCapteurCH4()
        {
            while (true)
            {
                Console.WriteLine("Thread en marche !");
                //linda.lindaAdd("niveau_CH4", new LindaTuple("niveau_CH4," + CH4ValueTextBox.Text));
            }
        }

    }
}
