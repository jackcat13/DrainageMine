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
        private Thread capteurH20;
        private Thread capteurC0;
        private Thread capteurCH4;
        private Pompe pompe;
        private Ventilateur ventilateur;
        private Thread pompeThread;
        private Thread ventilateurThread;
        private Thread h2O_seuil_haut;
        private Thread surveillance_gaz_haut;
        private Thread commandePompeVentilo;
        private Thread detection_gaz_bas;
        private Thread h2O_seuil_bas;
        delegate void SetTextCallback(string text);

        public Form1()
        {
            InitializeComponent();
            linda = new Linda();
            capteurH20 = new Thread(agentCapteurH20);
            capteurC0 = new Thread(agentCapteurC0);
            capteurCH4 = new Thread(agentCapteurCH4);

            pompe = new Pompe(linda);
            pompeThread = new Thread(new ThreadStart(pompe.agentPompe));

            ventilateur = new Ventilateur(linda);
            ventilateurThread = new Thread(new ThreadStart (ventilateur.agentVentilateur));

            H2O_seuil_haut h = new H2O_seuil_haut(linda);
            h2O_seuil_haut = new Thread(h.agent_H2O_seuil_haut);

            Detection_gaz_bas d = new Detection_gaz_bas(linda);
            detection_gaz_bas = new Thread(d.agent_detection_gaz_bas);


            CommandePompeVentilo cpv = new CommandePompeVentilo(linda);
            commandePompeVentilo = new Thread(cpv.agentCommandePompeVentilo);

            Surveillance_gaz_haut sgh = new Surveillance_gaz_haut(linda);
            surveillance_gaz_haut = new Thread(sgh.agentSurveillance_gaz_haut);

            H2O_seuil_bas hb = new H2O_seuil_bas(linda);
            h2O_seuil_bas = new Thread(hb.agent_H2O_seuil_bas);
            

            try{
                H2OSeuilBasTextBox.Text = linda.lindaReadP("value_Seuil_H2O_Bas").Arguments.Split(',')[1];
                COSeuilBasTextBox.Text = linda.lindaReadP("value_Seuil_CO_Bas").Arguments.Split(',')[1];
                CH4SeuilBasTextBox.Text = linda.lindaReadP("value_Seuil_CH4_Bas").Arguments.Split(',')[1];
                H2OSeuilHautTextBox.Text = linda.lindaReadP("value_Seuil_H2O_Haut").Arguments.Split(',')[1];
                COSeuilHautTextBox.Text = linda.lindaReadP("value_Seuil_CO_Haut").Arguments.Split(',')[1];
                CH4SeuilHautTextBox.Text = linda.lindaReadP("value_Seuil_CH4_Haut").Arguments.Split(',')[1];
                H2OValueTextBox.Text = linda.lindaReadP("niveau_H2O").Arguments.Split(',')[1];
                COValueTextBox.Text = linda.lindaReadP("niveau_CO").Arguments.Split(',')[1];
                CH4ValueTextBox.Text = linda.lindaReadP("niveau_CH4").Arguments.Split(',')[1];
            }
            catch(Exception e){
                Console.WriteLine(e);
            }

            
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Closing);
        }

        private void setSeuilBasButton_Click(object sender, EventArgs e)
        {
            List<string> tupleH2O = new List<string>();
            tupleH2O.Add("value_Seuil_H2O_Bas");
            tupleH2O.Add(H2OSeuilBasTextBox.Text);
            LindaTuple seuilH2OBas = new LindaTuple(tupleH2O);
            linda.lindaAdd("value_Seuil_H2O_Bas", seuilH2OBas);

            List<string> tupleCO = new List<string>();
            tupleCO.Add("value_Seuil_CO_Bas");
            tupleCO.Add(COSeuilBasTextBox.Text);
            LindaTuple seuilCOBas = new LindaTuple(tupleCO);
            linda.lindaAdd("value_Seuil_CO_Bas", seuilCOBas);

            List<string> tupleCH4 = new List<string>();
            tupleCH4.Add("value_Seuil_CH4_Bas");
            tupleCH4.Add(CH4SeuilBasTextBox.Text);
            LindaTuple seuilCH4Bas = new LindaTuple(tupleCH4);
            linda.lindaAdd("value_Seuil_CH4_Bas", seuilCH4Bas);
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

        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            if (capteurH20.IsAlive) { 
            capteurH20.Abort();
            }
            if (capteurC0.IsAlive)  { 
            capteurC0.Abort();
             }
            if (capteurCH4.IsAlive) {
                 capteurCH4.Abort();
             }
            if (pompeThread.IsAlive)
            {
                pompeThread.Abort();
            }
            if (ventilateurThread.IsAlive)
            {
                ventilateurThread.Abort();
            }
            if (h2O_seuil_haut.IsAlive)
            {
                h2O_seuil_haut.Abort();
            }
            if (commandePompeVentilo.IsAlive)
            {
                commandePompeVentilo.Abort();
            }
            if(detection_gaz_bas.IsAlive)
            {
                detection_gaz_bas.Abort();
            }

            if (surveillance_gaz_haut.IsAlive)
            {
                surveillance_gaz_haut.Abort();
            }
            if (h2O_seuil_bas.IsAlive)
            {
                h2O_seuil_bas.Abort();
            }
        
        }

        private void agentCapteurH20()
        {
            while (true)
            {
                try
                {
                    linda.lindaAdd("niveau_H2O", new LindaTuple("niveau_H2O," + (string.IsNullOrWhiteSpace(H2OValueTextBox.Text)? "0" : H2OValueTextBox.Text)));
                    Console.WriteLine(H2OValueTextBox.Text);
                    Thread.Sleep(1000);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        private void agentCapteurC0()
        {
            while (true)
            {
                try
                {
                    linda.lindaAdd("niveau_CO", new LindaTuple("niveau_CO," + (string.IsNullOrWhiteSpace(COValueTextBox.Text) ? "0" : COValueTextBox.Text)));
                    Thread.Sleep(1000);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        private void agentCapteurCH4()
        {
            while (true)
            {
                try
                {
                    linda.lindaAdd("niveau_CH4", new LindaTuple("niveau_CH4," + (string.IsNullOrWhiteSpace(CH4ValueTextBox.Text) ? "0" : CH4ValueTextBox.Text)));
                    Thread.Sleep(1000);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {

            pompe.etatPompeChanged += _etatPompeChanged;
            ventilateur.etatVentiloChanged += _etatVentiloChanged;

            capteurH20.Start();
            capteurC0.Start();
            capteurCH4.Start();

           
            pompeThread.Start();

            ventilateurThread.Start();

         
            h2O_seuil_haut.Start();


            detection_gaz_bas.Start();

            commandePompeVentilo.Start();

            surveillance_gaz_haut.Start();

            h2O_seuil_bas.Start();

            linda.lindaAdd("detection_H2O_haut",new LindaTuple("detection_H2O_haut"));
            setlblPompeText("desactive");
            setlblVentilateurText("desactive");


           
        }

        private void _etatPompeChanged(object sender, EtatPompeChangedEventArgs e)
        {
            if (this.lblPompe.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(setlblPompeText);
                this.Invoke(d, new object[] { e.NewValue });
            }
            else
            {
                this.setlblPompeText(e.NewValue);
            }
        }

        private void setlblPompeText(String s)
        {
            lblPompe.Text = s;

        }

        private void _etatVentiloChanged(object sender, EtatVentiloChangedEventArgs e)
        {
            if (this.lblVentilateur.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(setlblVentilateurText);
                this.Invoke(d, new object[] { e.NewValue });
            }
            else
            {
                this.setlblVentilateurText(e.NewValue);
            }
        }

        private void setlblVentilateurText(String s)
        {
            lblVentilateur.Text = s;

        }



    }
}
