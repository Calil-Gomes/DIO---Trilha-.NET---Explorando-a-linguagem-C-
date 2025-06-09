using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO_Codigos.ModelsSecondary
{
    internal class Suite
    {
        internal string TipoSuite;
        internal int Capacidade;
        internal decimal ValorDiaria;
        internal Suite(string tiposuite, int capacidade, decimal valordiaria) {
            this.TipoSuite = tiposuite;
            this.Capacidade = capacidade;
            this.ValorDiaria = valordiaria;
        }

    }
}
