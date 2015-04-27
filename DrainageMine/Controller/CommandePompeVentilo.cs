using DrainageMine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrainageMine.Controller
{
    class CommandePompeVentilo
    {

        private Linda linda;


        public CommandePompeVentilo(Linda linda)
        {
            this.linda = linda;
           
        }

        public void agentCommandePompeVentilo()
        {
            while (true)
            {
                linda.lindaIn("H2O_haut_detecte");
                int seuilCH4 = Convert.ToInt32(this.linda.lindaRead("value_Seuil_CH4_Haut").Arguments.Split(',')[1]);
                int seuilCO = Convert.ToInt32(this.linda.lindaRead("value_Seuil_CO_Haut").Arguments.Split(',')[1]);
                int niveauCH4 = Convert.ToInt32(linda.lindaRead("niveau_CH4").Arguments.Split(',')[1]);
                int niveauCO = Convert.ToInt32(linda.lindaRead("niveau_CO").Arguments.Split(',')[1]);
                if ((niveauCH4 < seuilCH4) && (niveauCO < seuilCO))
                {
                    linda.lindaOut(new LindaTuple("activation_pompe"));
                    linda.lindaOut(new LindaTuple("detection_H2O_bas"));
                    linda.lindaOut(new LindaTuple("surveillance_gaz_haut"));
                }
                else
                {
                    linda.lindaOut(new LindaTuple("activation_ventilateur"));
                    linda.lindaOut(new LindaTuple("detection_gaz_bas"));

                }
            }
        }

    }
}
