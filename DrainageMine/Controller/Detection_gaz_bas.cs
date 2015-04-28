using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrainageMine.Model;
namespace DrainageMine.Controller
{
    class Detection_gaz_bas
    {
        public Linda linda { get; set; }

        public Detection_gaz_bas(Linda linda)
        {
            this.linda = linda;
        }
         public void agent_detection_gaz_bas(){
             while (true)
             {
                 linda.lindaRead("detection_gaz_bas");

                 var niveau_ch4 = Convert.ToInt32(linda.lindaRead("niveau_CH4").Arguments.Split(',')[1]);
                 var niveau_co = Convert.ToInt32(linda.lindaRead("niveau_CO").Arguments.Split(',')[1]);

                 var seuil_ch4 = Convert.ToInt32(linda.lindaRead("value_Seuil_CH4_Bas").Arguments.Split(',')[1]);
                 var seuil_co = Convert.ToInt32(linda.lindaRead("value_Seuil_CO_Bas").Arguments.Split(',')[1]);

                 if ((niveau_ch4 < seuil_ch4) && (niveau_co < seuil_co))
                 {
                     linda.lindaOut(new LindaTuple("desactivation_ventilateur"));
                     linda.lindaOut(new LindaTuple("activation_pompe"));
                     linda.lindaOut(new LindaTuple("detection_H2O_bas"));
                     linda.lindaOut(new LindaTuple("surveillance_gaz_haut"));                     
                     linda.lindaIn("detection_gaz_bas");


                 }
             }
         

        }

    }

   
}

/* Detection_gaz_bas(seuil_CH4, seuil_CO)=
	in(ts, <|detection_gaz_bas, string|>).
	read(ts, <|niveau_CH4, string, ?x, float|>).
	read(ts, <|niveau_CO, string, ?y, float|>).
	([x<seuil_CH4 AND y<seuil_CO]
		out(ts, <activation_pompe, string>).
		out(ts, <detection_H2O_bas, string>).
		Detection_gaz_bas(seuil_CH4, seuil_CO)
	+
	[x>=seuil_CH4 OR y>=seuil_CO] 
		Detection_gaz_bas(seuil_CH4, seuil_CO)*/