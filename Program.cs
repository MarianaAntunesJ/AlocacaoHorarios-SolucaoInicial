using AlocacaoHorarios_SolucaoInicial.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AlocacaoHorarios_SolucaoInicial
{
    class Program
    {
        static void Main(string[] args)
        {            
            var professor = new Professor("CJ1", "Manzano");

            var disciplina = new Disciplina(1, "LOPA", 6, 60, 1, false, professor);

            var sala = new Sala(10, false, 60);

            var aula = new Aula(disciplina, sala);

            var dia = new Dia(DiasDaSemana.Segunda, new Aula[] { aula, null });

            var horario = new Horario(Periodos.Primeiro, new Dia[] { dia });

        }
    }
}
