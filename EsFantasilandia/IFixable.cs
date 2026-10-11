using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsFantasilandia
{
    public interface IFixable
    {
        bool isGuasta();
        void Ripara();
        void SegnalaGuasto();

        string Descrizione();
    }
}
