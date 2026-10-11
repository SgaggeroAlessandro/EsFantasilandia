using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsFantasilandia
{
    public abstract class CAttrazioni : IFixable
    {
        public string Nome { get; set; }
        public int CapienzaMassima { get; set; }

        public int CostoRiparazione { get; set; }
        public int TempoRiparazione { get; set; }
        private bool guasta;
        public CAttrazioni(string Nome, int CapienzaMassima, int CostoRiparazione, int TempoRiparazione)
        {
            this.Nome = Nome;
            this.CapienzaMassima = CapienzaMassima;
            this.CostoRiparazione = CostoRiparazione;
            this.TempoRiparazione = TempoRiparazione;
        }

        public abstract int Costo(CVisitatore v);
        public abstract string Descrizione();

        public bool isGuasta()
        {
            return guasta;
        }

        public void Ripara()
        {
            guasta = false;
        }

        public void SegnalaGuasto()
        {
            guasta = true;
        }
    }
}
