using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrainageMine.Controller
{
    class Pompe
    {

        private Linda linda;
        private String etatPompe;

        public Pompe(Linda linda)
        {
            this.linda = linda;
            this.etatPompe = "desactive";
        }

        public void agentPompe()
        {
            while (true)
            {
                if (this.etatPompe == "desactive")
                {
                    linda.lindaIn("activation_pompe");
                    this.etatPompe = "active";
                }
                else
                {
                    linda.lindaIn("desactivation_pompe");
                    this.etatPompe = "desactive";
                }
            }
        }

    }
}
