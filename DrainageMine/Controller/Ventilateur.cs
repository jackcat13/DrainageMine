using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrainageMine.Controller
{
    class EtatVentiloChangedEventArgs : EventArgs
    {
        public readonly String NewValue;

        public EtatVentiloChangedEventArgs(String NewValue)
        {
            this.NewValue = NewValue;
        }
    }

    class Ventilateur
    {

        private Linda linda;
        private String etatVentilateur;


        public event System.EventHandler<EtatVentiloChangedEventArgs> etatVentiloChanged;


        public String EtatVentilateur
        {
            get { return etatVentilateur; }
            set
            {
                etatVentilateur = value;
                OnEtatVentiloChanged(new EtatVentiloChangedEventArgs(value));
            }
        }

        public Ventilateur(Linda linda)
        {
            this.linda = linda;
            this.etatVentilateur = "desactive";
        }

        protected virtual void OnEtatVentiloChanged(EtatVentiloChangedEventArgs e)
        {
            if (etatVentiloChanged != null) etatVentiloChanged(this, e);
        }

        public void agentVentilateur()
        {
            while (true)
            {
                if (linda.lindaReadP("activation_ventilateur")!=null)
                {
                    linda.lindaIn("activation_ventilateur");
                    EtatVentilateur = "active";
                }
                if (linda.lindaReadP("desactivation_ventilateur") != null)
                {
                    linda.lindaIn("desactivation_ventilateur");
                    EtatVentilateur = "desactive";
                }
            }
        }

    }
}
