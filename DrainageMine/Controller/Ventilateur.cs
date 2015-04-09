using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrainageMine.Controller
{
    class Ventilateur
    {

        private Linda linda;
        private String etatVentilateur;

        public Ventilateur(Linda linda)
        {
            this.linda = linda;
            this.etatVentilateur = "desactive";
        }

        public void agentVentilateur()
        {
            while (true)
            {
                if (this.etatVentilateur == "desactive")
                {
                    linda.lindaIn("activation_ventilateur");
                    this.etatVentilateur = "active";
                }
                else
                {
                    linda.lindaIn("desactivation_ventilateur");
                    this.etatVentilateur = "desactive";
                }
            }
        }

    }
}
