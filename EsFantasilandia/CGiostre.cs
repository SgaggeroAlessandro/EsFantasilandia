using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsFantasilandia
{
    public class CGiostre : CAttrazioni
    {
        public int EtaMassima { get; set; }
        private int Prezzo { get; set; }

        public CGiostre(string Nome, int CapienzaMassima, int CostoRiparazione, int TempoRiparazione, int EtaMassima, int Prezzo) : base(Nome, CapienzaMassima, CostoRiparazione, TempoRiparazione)
        {
            this.EtaMassima = EtaMassima;
            this.Prezzo = Prezzo;
        }

        public override string Descrizione()
        {
            return $"Nome giostra: {Nome}\nCapienza massima: {CapienzaMassima}\nCosto di riparazione: {CostoRiparazione}€\nTempo di riparazione: {TempoRiparazione}\n Età del bambino: {EtaMassima}\n Prezzo: {Prezzo}";
        }

        public bool VerificaEtà(CVisitatore v)
        {
            if (v.Età > EtaMassima)
            {
                return false;
            }
            return true;
        }
        public override int Costo(CVisitatore v)
        {
            if (VerificaEtà(v) == false)
            {
                return 0;
            }
            return Prezzo;
        }
    }
}