using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsFantasilandia
{
    public class CSalaGiochi : CAttrazioni
    {
        private int Prezzo { get; set; }
        public CSalaGiochi(string Nome, int CapienzaMassima, int CostoRiparazione, int TempoRiparazione, int Prezzo) : base(Nome, CapienzaMassima, CostoRiparazione, TempoRiparazione)
        {
            this.Prezzo = Prezzo;
        }

        public override string Descrizione()
        {
            return $"Nome Sala giochi: {Nome}\nCapienza massima: {CapienzaMassima}\nCosto di riparazione: {CostoRiparazione}€\nTempo di riparazione: {TempoRiparazione}\n Prezzo in gettoni: {Prezzo}";
        }

        public override int Costo(CVisitatore v)
        {
            return Prezzo;
        }
    }
}
