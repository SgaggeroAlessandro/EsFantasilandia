using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsFantasilandia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<CAttrazioni> attrazioni = new List<CAttrazioni>();
            List<IFixable> elementiFixable = new List<IFixable>();


            CMontagnaRussa m1 = new CMontagnaRussa("Olandese Volante", 150, 250, 3, 120, 10, 3);
            attrazioni.Add(m1);
            Console.WriteLine(m1.Descrizione());
            elementiFixable.Add(m1);

            CGiostre g1 = new CGiostre("Giro giro tondo", 20, 40, 2, 10, 5);
            attrazioni.Add(g1);
            Console.WriteLine(g1.Descrizione());
            elementiFixable.Add(g1);

            CSalaGiochi s1 = new CSalaGiochi("Arcade", 30, 800, 7, 15);
            attrazioni.Add(s1);
            Console.WriteLine(s1.Descrizione());
            elementiFixable.Add(s1);

            CSaltoNelVuoto sv1 = new CSaltoNelVuoto("Salto dal cielo", 20, 130, 2, 150, 7, 2, 60, 3);
            attrazioni.Add(sv1);
            Console.WriteLine(sv1.Descrizione());
            elementiFixable.Add(sv1);

            CChioschi c1 = new CChioschi("Bar centrale", 55, 1);
            elementiFixable.Add(c1);
            Console.WriteLine(c1.Descrizione());

            CBagni b1 = new CBagni(7, 150, 1);
            elementiFixable.Add(b1);
            Console.WriteLine(b1.Descrizione());

            m1.SegnalaGuasto();
            b1.SegnalaGuasto();

            Console.WriteLine("\n\n\n");
            List<IFixable> StruttureDaSistemare = new List<IFixable>();
            foreach (IFixable f in elementiFixable)
            {
                if (f.isGuasta() == true)
                {
                    StruttureDaSistemare.Add(f);
                }
            }

            foreach (IFixable f in StruttureDaSistemare)
            {
                Console.WriteLine(f.Descrizione());
            }

            CVisitatore v1 = new CVisitatore(true, 170, 18, 75);

            if (m1.VerificaAltezza(v1) == true)
            {
                Console.WriteLine($"Il visitatore è alto {v1.Altezza} e l'altezza minima richiesta per salire è {m1.AltezzaMinima}, quindi il visitatore può salire su {m1.Nome}");
            }
            else
            {
                Console.WriteLine($"Il visitatore è alto {v1.Altezza} e l'altezza minima richiesta per salire è {m1.AltezzaMinima}, quindi il visitatore non può salire su {m1.Nome}");
            }

            if (sv1.VerificaAltezza(v1) == true && sv1.VerificaPeso(v1) == true)
            {
                Console.WriteLine($"Il visitatore può salire sulla giostra {sv1.Nome}");
            }
            else
            {
                Console.WriteLine($"Il visitatore non può salire sulla giostra {sv1.Nome}");
            }

            if (g1.VerificaEtà(v1))
            {
                Console.WriteLine($"Il visitatore ha {v1.Età} anni, quindi può salire sulla giostra {g1.Nome} perché l'età massima è {g1.EtaMassima}");
            }
            else
            {
                Console.WriteLine($"Il visitatore ha {v1.Età} anni, quindi non può salire sulla giostra {g1.Nome} perché l'età massima è {g1.EtaMassima}");
            }

            int incasso = 0;

            foreach (CAttrazioni a in attrazioni)
            {
                incasso += a.Costo(v1);
            }

            Console.WriteLine("\n\n\n");
            Console.WriteLine(incasso);
        }
    }
}



/*
 * RISPOSTA ALLE DOMANDE GUIDA:
 * 1. 
 * 
 * 
 * 
 * 
 * 
*/