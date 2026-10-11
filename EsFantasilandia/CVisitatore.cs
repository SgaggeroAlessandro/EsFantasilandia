using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsFantasilandia
{
    public class CVisitatore
    {
        public bool FastPass { get; set; }
        public int Altezza { get; set; }
        public int Età { get; set; }
        public int Peso { get; set; }
        public CVisitatore(bool FastPass, int Altezza, int Età, int Peso)
        {
            this.FastPass = FastPass;
            this.Altezza = Altezza;
            this.Età = Età;
            this.Peso = Peso;
        }
    }
}
