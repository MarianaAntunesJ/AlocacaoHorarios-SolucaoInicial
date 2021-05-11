using AlocacaoHorarios_SolucaoInicial.Entidades;
using System;
using System.Collections.Generic;

namespace AlocacaoHorarios_SolucaoInicial.View
{
    class Exibicao
    {

        public void ExibirAula(Aula aula)
        {
            Console.WriteLine(aula.Disciplina.Nome);
            Console.WriteLine(aula.Sala.Id);
            Console.WriteLine();
        }


        public string ConverteIdParaDiaDaSemana(int id)
        {
            if (id == 1)
                return "SEGUNDA-FEIRA";
            else if (id == 2)
                return "TERÇA-FEIRA";
            else if (id == 3)
                return "QUARTA-FEIRA";
            else if (id == 4)
                return "QUINTA-FEIRA";
            else if (id == 5)
                return "SEXTA-FEIRA";
            else 
                return null;
        }

        public void ExibirDia(Dia dia)
        {
            Console.WriteLine(ConverteIdParaDiaDaSemana(dia.Id));
            ExibirAula(dia.Aulas[0]);
            ExibirAula(dia.Aulas[1]); 
        }

        public void ExibirSemana(List<Dia> dias)
        {
            for (int i = 0; i < 5; i++)
                ExibirDia(dias[i]);
        }
    }
}
