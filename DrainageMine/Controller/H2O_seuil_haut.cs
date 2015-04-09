using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrainageMine.Controller
{
    class H2O_seuil_haut
    {
        Linda linda;

        public H2O_seuil_haut(Linda linda){
            this.linda = linda;
        }

        public void agent_H2O_seuil_haut()
        {
            linda.lindaRead("detection_H2O_haut");
            string niveau=linda.lindaRead("niveau_H2O").Arguments.Split(',')[1];


        }
    }
}
/*
	read(ts, <|detection_H2O_haut, string|>). //Permet de vérifier que cette tâche est active 
	read(ts, <|niveau_H2O, string, ?x, float|>).
	([x>=seuil_H2O_haut] 
		out(ts, <H2O_haut_detecte,string>).
		in(ts, <|detection_H2O_haut, string|>).
		H2O_haut (seuil_H2O_haut)
	+ //OR
	[x < seuil_H2O_eau]
		H2O_haut (seuil_H2O_haut)
	)
 * 
 * */
