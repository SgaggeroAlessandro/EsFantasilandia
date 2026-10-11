using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsFantasilandia
{
    public class CSaltoNelVuoto : CMontagnaRussa
    {
        private int Peso { get; set; }
        private int Supplemento { get; set; }


        public CSaltoNelVuoto(string Nome, int CapienzaMassima, int CostoRiparazione, int TempoRiparazione, int AltezzaMinima, int Prezzo, int FastPass, int Peso, int Supplemento) : base(Nome, CapienzaMassima, CostoRiparazione, TempoRiparazione, AltezzaMinima, Prezzo, FastPass)
        {
            this.Peso = Peso;
            this.Supplemento = Supplemento;
        }

        public override string Descrizione()
        {
            return base.Descrizione() + $"\nPeso: {Peso}\n Supplemento: {Supplemento}€";
        }

        public override int Costo(CVisitatore v)
        {
            if(VerificaAltezza(v) == false || VerificaPeso(v) == false)
            {
                return 0;
            }
            return base.Costo(v) + Supplemento;
        }

        public bool VerificaPeso(CVisitatore v)
        {
            if(v.Peso > Peso)
            {
                return false;
            }
            return true;
        }
    }
}
