using AlocacaoHorarios_SolucaoInicial.Entities;
using AlocacaoHorarios_SolucaoInicial.View;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AlocacaoHorarios_SolucaoInicial.Helpers
{
    class Restricoes
    {
        // RT01
        public Semana AulaDupla(Semana semana)
        {
            var random = new Random();

            var exibicao = new Exibicao(semana);

            //Percorre a semana
            for (var i = 0; i <= 4; i++)
            {
                //percorre o dia
                for (var j = 0; j <= 2; j += 2)
                {
                    var aula = semana.Dias[i].Aulas[j];

                    // agrupa a variavel "aula" em dupla.
                    var aulasEmDupla = AgruparAulas(semana, aula, new Tuple<int, int>(i, j + 1));

                    // aula após a aula atual [0] - primeiraAula ou [2] - terceiraAula
                    var aulaInicial = new Tuple<int, int>(i, j + 1);

                    // variavel para armazenar a aula da semana, de mesma disciplina, que sera alocada em seguida aula atual.
                    var aulaSubstituta = aulasEmDupla.OrderBy(_ => random.Next()).FirstOrDefault();

                    semana.TrocaAulas(aulaInicial, aulaSubstituta);
                }
            }
            return semana;
        }

        /* Método - Agrupa aulas em duplas. 
            tupla contem <int (Dia da semana)>, <int (Horario do dia)> */
        private List<Tuple<int, int>> AgruparAulas(Semana semana, Aula aula, Tuple<int, int> aulaInicial)
        {
            //Explicar: Qual logica implementar? OTIMIZADA OU VISIVEL

            var aulas = new List<Tuple<int, int>>();

            //Percorre a partir do dia e aula inicial;
            for (var i = aulaInicial.Item1; i < semana.Dias.Count; i++)
            {
                //Percorre as aulas do dia
                for (var j = 0; j <= 3; j++)
                {
                    if (DisciplinaIgualDisciplinaAtual() && (DiaEntradaMaiorDiaAtual() || AulaAtualMaiorAulaEntrada()))
                        aulas.Add(new Tuple<int, int>(i, j));


                    bool DisciplinaIgualDisciplinaAtual()
                        => semana.Dias[i].Aulas[j].Id == aula.Id;

                    bool DiaEntradaMaiorDiaAtual()
                        => i > aulaInicial.Item1;

                    bool AulaAtualMaiorAulaEntrada()
                        => (i == aulaInicial.Item1 && j > aulaInicial.Item2);
                }
            }

            /*for (var i = inicio.Item1; i < semana.Dias.Count; i++)
            {
                var indexInicial = 0;
                
                /* Define o valor de J. 
                    O J é o index inicial para o for percorrer, afim de evitar processamento desnecessario)

                if (i == inicio.Item1)
                    indexInicial = inicio.Item2;

                for (var j = indexInicial; j <= 3; j++)
                {
                    var disciplinaIgualDisciplinaAtual = semana.Dias[i].Aulas[j].Id == aula.Id;

                    if (disciplinaIgualDisciplinaAtual)
                        aulas.Add(new Tuple<int, int>(i, j));
                }
            }*/

            return aulas;
        }
    }
}
