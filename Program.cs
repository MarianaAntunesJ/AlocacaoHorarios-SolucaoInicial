using AlocacaoHorarios_SolucaoInicial.DAL;
using AlocacaoHorarios_SolucaoInicial.Helpers;
using AlocacaoHorarios_SolucaoInicial.View;
using System;

namespace AlocacaoHorarios_SolucaoInicial
{
    class Program
    {
        static void Main()
        {
            var popula = new Seed();

            var restricoes = new Restricoes();

            var exibicao = new Exibicao(popula.Semana);

            Console.WriteLine();
            Console.WriteLine("Horário inicial");
            Console.WriteLine();
            exibicao.ExibirSemana();

            exibicao._semana = restricoes.AulaDupla(popula.Semana);

            Console.WriteLine();
            Console.WriteLine("Horário após RT01 - Aulas Duplas");
            Console.WriteLine();
            exibicao.ExibirSemana();
        }
    }
}
