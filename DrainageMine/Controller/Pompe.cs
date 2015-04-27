using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrainageMine.Controller
{
    class EtatPompeChangedEventArgs : EventArgs
    {
        public readonly String NewValue;

        public EtatPompeChangedEventArgs(String NewValue)
        {
            this.NewValue = NewValue;
        }
    }
    class Pompe
    {
        public event System.EventHandler<EtatPompeChangedEventArgs> etatPompeChanged;
        private Linda linda;
        private String etatPompe;

        public String EtatPompe
        {
            get { return etatPompe; }
            set
            {
                etatPompe = value;
                OnEtatPompeChanged(new EtatPompeChangedEventArgs(value));
            }
        }

        public Pompe(Linda linda)
        {
            this.linda = linda;
            this.etatPompe = "desactive";
        }

        protected virtual void OnEtatPompeChanged(EtatPompeChangedEventArgs e)
        {
            if (etatPompeChanged != null) etatPompeChanged(this, e);
        }

        public void agentPompe()
        {
            while (true)
            {
                if (linda.lindaReadP("activation_pompe")!=null)
                {
                    linda.lindaIn("activation_pompe");
                    EtatPompe = "active";
                }
                if (linda.lindaReadP("desactivation_pompe") != null)
                {
                    linda.lindaIn("desactivation_pompe");
                    EtatPompe = "desactive";
                }
            }
        }

    }
}
