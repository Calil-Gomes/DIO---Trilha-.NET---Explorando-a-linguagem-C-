using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DIO_Codigos.ModelsSecondary;

internal class Program
{
    private static void Main(string[] args)
    {
        Pessoa persona1 = new Pessoa(nome: "Calil", sobrenome: "Gomes");
        Pessoa persona2 = new Pessoa(nome: "Maria", sobrenome: "Fonseca");

        List<Pessoa> hospedes = new List<Pessoa>();
        hospedes.Add(persona1);
        hospedes.Add(persona2);

        Suite suiteE = new Suite(tiposuite: "Ultra Premium", capacidade: 2, valordiaria: 45);

        Reserva reservaNew = new Reserva(diasReservados: 10);


        reservaNew.CadastrarHospedes(hospedes);
        reservaNew.CadastrarSuite(suiteE);

        Console.WriteLine($"Quantidade de hóspedes: {reservaNew.ObterQuantidadeHospedes()}");
        Console.WriteLine($"Valor da diária: {reservaNew.CalcularValorDiaria()}");
    }
}