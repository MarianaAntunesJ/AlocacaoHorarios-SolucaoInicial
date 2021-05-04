using AlocacaoHorarios_SolucaoInicial.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AlocacaoHorarios_SolucaoInicial
{
    class Program
    {
        static void Main()
        {            
            var professor = new Professor("CJ1", "Manzano");

            var disciplina = new Disciplina(1, "LOPA", 6, 60, 1, false, professor);

            var sala = new Sala(10, false, 60);

            var aula = new Aula(disciplina, sala);

            var dia = new Dia(DiasDaSemana.Segunda);

            dia.Aulas[1] = aula;

            var horario = new Horario(Periodos.Primeiro);

            horario.InsereNoDiaDesocupado(dia, 1);
        }
    }
}
