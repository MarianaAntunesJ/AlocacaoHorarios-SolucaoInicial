using AlocacaoHorarios_SolucaoInicial.Entities;
using AlocacaoHorarios_SolucaoInicial.View;
using System.Collections.Generic;
using System;
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

            // Percorre a semana
            for (var i = 0; i <= 4; i++)
            {
                // Percorre o dia
                for (var j = 0; j <= 2; j += 2)
                {
                    var aula = semana.Dias[i].Aulas[j];

                    // agrupa a variavel "aula" em dupla.
                    var aulasDupla = AgruparAulas(semana, aula, new Tuple<int, int>(i, j + 1));

                    // aula após a aula atual [0] - primeiraAula ou [2] - terceiraAula
                    var aulaSubstituida = new Tuple<int, int>(i, j + 1);

                    // variavel para armazenar a aula da semana, de mesma disciplina, que sera alocada em seguida aula atual.
                    var aulaSubstituta = aulasDupla.OrderBy(_ => random.Next()).FirstOrDefault();

                    semana.TrocaAulas(aulaSubstituida, aulaSubstituta);
                }
            }
            return semana;
        }

        /* Método - Agrupa aulas em duplas. 
            tupla contem <int (Dia da semana)>, <int (Horario do dia)> da aula */
        private List<Tuple<int, int>> AgruparAulas(Semana semana, Aula aula, Tuple<int, int> diaHorarioAula)
        {
            var aulas = new List<Tuple<int, int>>();

            //Percorre a partir do dia inicial;
            for (var i = diaHorarioAula.Item1; i < semana.Dias.Count; i++)
            {
                var indexInicial = 0;

                var diaEntrada = diaHorarioAula.Item1;
                var aulaEntrada = diaHorarioAula.Item2;

                //Define o valor de J. Se "i" for igual a "diaEntrada" percorrer apenas a partir da "aulaEntrada"
                if (i == diaEntrada)
                    indexInicial = aulaEntrada;

                //Percorre a partir da aula
                for (var j = indexInicial; j <= 3; j++)
                {
                    var aulaAtualIgualAula = semana.Dias[i].Aulas[j].Id == aula.Id;

                    if (aulaAtualIgualAula)
                        aulas.Add(new Tuple<int, int>(i, j));
                }
            }
            return aulas;
        }

        //RT02
        public void AulasDuplasDiferentesNoDia(Semana semana)
        {

        }
    }
}
