using AlocacaoHorarios_SolucaoInicial.Entities;
using AlocacaoHorarios_SolucaoInicial.View;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AlocacaoHorarios_SolucaoInicial.Helpers
{
    class Restricoes
    {
        public Semana A(Semana semana)
        {
            var random = new Random();

            var exibicao = new Exibicao(semana);

            for (var i = 0; i <= 4; i++)
            {
                for (var j = 0; j <= 2; j += 2)
                {
                    var primeiraAula = semana.Dias[i].Aulas[j];
                    var aulas = B(semana, primeiraAula, new Tuple<int, int>(i, j + 1));
                    var aulaEntrada = new Tuple<int, int>(i, j + 1);
                    var aulaTroca = aulas.OrderBy(_ => random.Next()).Take(1).FirstOrDefault();
                    semana.TrocaAulas(aulaEntrada, aulaTroca);
                    exibicao._semana = semana;
                    exibicao.ExibirSemana();
                }
            }
            return semana;
        }

        private List<Tuple<int, int>> B(Semana semana, Aula aula, Tuple<int, int> inicio)
        {
            //Explicar: Qual loica implementar? OTIMIZADA OU VISIVEL

            var aulas = new List<Tuple<int, int>>();
            /*for (var i = inicio.Item1; i < semana.Dias.Count; i++)
            {

                for (var j = 0; j <= 3; j++)
                {
                    var disciplinaIgualDisciplinaAtual = semana.Dias[i].Aulas[j].Id == aula.Id;
                    var diaEntradaMaiorDiaAtual = i > inicio.Item1;
                    var aulaAtualMaiorAulaEntrada = (i == inicio.Item1 && j > inicio.Item2);

                    if ( disciplinaIgualDisciplinaAtual && (diaEntradaMaiorDiaAtual || aulaAtualMaiorAulaEntrada ))
                        aulas.Add(new Tuple<int, int>(i, j));
                }
            }*/

            for (var i = inicio.Item1; i < semana.Dias.Count; i++)
            {
                var valorj = 0;
                if (i == inicio.Item1)
                    valorj = inicio.Item2;

                for (var j = valorj; j <= 3; j++)
                {
                    var disciplinaIgualDisciplinaAtual = semana.Dias[i].Aulas[j].Id == aula.Id;

                    if (disciplinaIgualDisciplinaAtual)
                        aulas.Add(new Tuple<int, int>(i, j));
                }
            }

            return aulas;
        }
    }
}
