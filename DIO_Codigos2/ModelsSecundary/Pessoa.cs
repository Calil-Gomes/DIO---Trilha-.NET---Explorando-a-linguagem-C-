using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO_Codigos.ModelsSecondary
{
    internal class Pessoa
    {
        internal Pessoa(string nome, string sobrenome)
        {
            this.Nome = nome.ToUpper();
            this.Sobrenome = sobrenome.ToUpper();
        }
        internal string Nome { get; set; }
        internal string Sobrenome { get; set; }


    }
}
