using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIO_Codigos.ModelsSecondary;

namespace DIO_Codigos.ModelsSecondary
{
    internal class Reserva
    {
        internal List<List<Pessoa>> Hospedes = new List<List<Pessoa>>();
        internal List<Pessoa> HospeQtd = new List<Pessoa>();
        internal Suite Suite { get; set; }
        
        internal int DiasReservados { get; set; }

        internal void CadastrarHospedes(List<Pessoa> Param)
        {
            this.Hospedes.Add(Param);
            this.HospeQtd = Param;
        }
        

        internal void CadastrarSuite(Suite Param)
        {
            this.Suite = Param;
        }
        
        internal int ObterQuantidadeHospedes() {
            int tamanhoLista = this.HospeQtd.Count();
            return tamanhoLista;
        }
        internal decimal CalcularValorDiaria() {
            decimal valorMultiplicado = DiasReservados * this.Suite.ValorDiaria;
            decimal new_value;
            if (DiasReservados >= 10) {
                new_value = valorMultiplicado - ((10/100)*valorMultiplicado);
            }
            else
            {
                new_value = valorMultiplicado;
            }
            return new_value;
        }
        internal Reserva( int diasReservados)
        {
            this.DiasReservados = diasReservados;
        }
    }
}
