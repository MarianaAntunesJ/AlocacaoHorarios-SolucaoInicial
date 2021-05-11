using AlocacaoHorarios_SolucaoInicial.DAL;
using AlocacaoHorarios_SolucaoInicial.Entidades;
using AlocacaoHorarios_SolucaoInicial.View;
using System.Collections.Generic;

namespace AlocacaoHorarios_SolucaoInicial
{
    class Program
    {
        static void Main()
        {
            Seed popula = new Seed();

            Exibicao exibicao = new Exibicao();

            exibicao.ExibirSemana(popula.Dias);
            
                     
            /*
            var professor = new Professor("CJ1", "Manzano");

            var disciplina = new Disciplina(1, "LOPA", 6, 60, 1, false, professor);

            var sala = new Sala(10, false, 60);

            var aula = new Aula(disciplina, sala);

            var dia = new Dia();

            var horario = new Horario(Periodos.Primeiro);

            horario.InsereNoDiaDesocupado(dia, 1);
            */
        }
    }
}
