using DrainageMine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrainageMine.Controller
{
    class Surveillance_gaz_haut
    {
        private Linda linda;

        public Surveillance_gaz_haut(Linda linda)
        {

            this.linda = linda;
        }




        public void agentSurveillance_gaz_haut()
        {
            while (true)
            {
                linda.lindaRead("surveillance_gaz_haut");

                var niveau_ch4 = Convert.ToInt32(linda.lindaRead("niveau_CH4").Arguments.Split(',')[1]);
                var niveau_co = Convert.ToInt32(linda.lindaRead("niveau_CO").Arguments.Split(',')[1]);

                var seuil_ch4 = Convert.ToInt32(linda.lindaRead("value_Seuil_CH4_Haut").Arguments.Split(',')[1]);
                var seuil_co = Convert.ToInt32(linda.lindaRead("value_Seuil_CO_Haut").Arguments.Split(',')[1]);

                if ((niveau_ch4 >= seuil_ch4) || (niveau_co >= seuil_co))
                {
                    linda.lindaOut(new LindaTuple("activation_ventilateur"));
                    linda.lindaOut(new LindaTuple("detection_gaz_bas"));
                    linda.lindaIn("surveillance_gaz_haut");

                }
            }
        }
    }
}
