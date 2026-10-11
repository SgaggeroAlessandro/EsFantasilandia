using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsFantasilandia
{
    public class CChioschi : IFixable
    {
        private string nomeChiosco;
        private int costoR;
        private int tempoR;
        private bool guasta;
        public CChioschi(string nomeChiosco, int costoR, int tempoR)
        {
            this.nomeChiosco = nomeChiosco;
            this.costoR = costoR;
            this.tempoR = tempoR;
            guasta = false;
        }
        
        
        public string Descrizione()
        {
            return $"Nome del chiosco: {nomeChiosco} - Costo della riparazione: {costoR} - Tempo per la riparazione: {tempoR}";
        }
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
