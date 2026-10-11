using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsFantasilandia
{
    public class CBagni : IFixable
    {
        private int numeroBagno;
        private int costoR;
        private int tempoR;
        private bool guasta;
        public CBagni(int numeroBagno, int costoR, int tempoR)
        {
            this.numeroBagno = numeroBagno; 
            this.costoR = costoR;
            this.tempoR = tempoR;
            guasta = false;
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

        public string Descrizione()
        {
            return $"Numero del bagno: {numeroBagno} - Costo della riparazione: {costoR} - Tempo per la riparazione: {tempoR}";
        }
    }
    }
