using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsFantasilandia
{
    public class CMontagnaRussa : CAttrazioni
    {
        public int AltezzaMinima { get; set; }
        private int Prezzo { get; set; }
        private int FastPass { get; set; }

        public CMontagnaRussa(string Nome, int CapienzaMassima, int CostoRiparazione, int TempoRiparazione, int AltezzaMinima, int Prezzo, int FastPass) : base(Nome, CapienzaMassima, CostoRiparazione, TempoRiparazione)
        {
            this.AltezzaMinima = AltezzaMinima;
            this.Prezzo = Prezzo;
            this.FastPass = FastPass;
        }

        public override string Descrizione()
        {
            return $"Nome montagna russa: {Nome}\nCapienza massima: {CapienzaMassima}\nCosto di riparazione: {CostoRiparazione}€\nTempo di riparazione: {TempoRiparazione}\n Altezza minima richiesta: {AltezzaMinima}\n Prezzo: {Prezzo}€\n Fast Pass: {FastPass}€";
        }
        public override int Costo(CVisitatore v)
        {
            if(VerificaAltezza(v) == false)
            {
                return 0;
            }
            return v.FastPass ? Prezzo + FastPass : Prezzo;
        }

        public bool VerificaAltezza(CVisitatore v)
        {
            if(v.Altezza < AltezzaMinima)
            {
                return false;

            }
            return true;
        }
    }
}
