using DrainageMine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrainageMine.Controller
{
    class H2O_seuil_bas
    {
        Linda linda;

        public H2O_seuil_bas(Linda linda){
            this.linda = linda;
        }
        public void agent_H2O_seuil_bas()
        {
            while (true)
            {
                linda.lindaRead("detection_H2O_bas");
                var niveau = Convert.ToInt32(linda.lindaRead("niveau_H2O").Arguments.Split(',')[1]);
                var seuil = Convert.ToInt32(linda.lindaRead("value_Seuil_H2O_Bas").Arguments.Split(',')[1]);
                if (niveau < seuil)
                {
                    
                    linda.lindaOut(new LindaTuple("desactivation_pompe"));
                    if (linda.lindaReadP("detection_gaz_bas") != null)
                    {
                        linda.lindaIn("detection_gaz_bas");
                        linda.lindaOut(new LindaTuple("desactivation_ventilateur"));
                    }
                    linda.lindaOut(new LindaTuple("detection_H2O_haut"));
                    linda.lindaIn("surveillance_gaz_haut");
                    linda.lindaIn("detection_H2O_bas");
                }
            }
        }


    }
}
