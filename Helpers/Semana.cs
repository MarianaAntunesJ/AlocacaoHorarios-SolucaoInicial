using AlocacaoHorarios_SolucaoInicial.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AlocacaoHorarios_SolucaoInicial.Helpers
{
    class Semana
    {
        public List<Dia> Dias { get; set; }

        public Semana() : this(new List<Dia>())
        {
        }

        public Semana(List<Dia> dias)
        {
            Dias = dias;
        }

        // Método - Preenche seamana. Chamas as funções necessárias para a criação inicial da semana.
        public List<Dia> PreencheSemana(List<Aula> aulas)
            => CriaSemana(DistribuiAulas(PreencheCargaHorariaDasAulas(aulas)));


        /* Método - Lista de consumo. Possui todas as aulas que cada matéria deve ter. 
            Exem: Lógica possui 6 aulas por semana, portanto existem 6 indexes contendo Lógica como valor.*/

        private List<Aula> PreencheCargaHorariaDasAulas(List<Aula> aulas)
        {
            var aulasPorCargaHoraria = new List<Aula>();
            foreach (var aula in aulas)
            {
                for (var i = 1; i <= aula.Disciplina.AulasPorSemana; i++)
                    aulasPorCargaHoraria.Add(aula);
            }
            return aulasPorCargaHoraria;
        }


        /* Método - Distribui aulas de forma randômica.
            O uso do Hash garante maior aleatoriedade de saídas.*/
        private List<Aula> DistribuiAulas(List<Aula> aulas)
        {
            var rand = new Random(DateTime.Now.ToString().GetHashCode());
            var aulasRandomicas = new List<Aula>();
            while (aulas.Count > 0)
            {
                int index = rand.Next(0, aulas.Count);
                aulasRandomicas.Add(aulas[index]);
                aulas.RemoveAt(index);
            }

            return aulasRandomicas;
        }


        /* Método - Cria semana. Distribui as aulas em uma lista que representa a semana.
            obs: Sendo fixo como uma lista de 5 posições (semana) e outra de lista de 4 posições (aulas) para representar o dia de aulas.*/
        private List<Dia> CriaSemana(List<Aula> aulas)
        {
            var semana = new List<Dia>();
            for (var i = 1; i <= 5; i++)
            {
                var dia = new Dia() { DiaDaSemana = (DiasDaSemana)i };

                for (var j = 0; j <= 3; j++)
                {
                    dia.Aulas[j] = aulas.First();
                    aulas.Remove(aulas.First());
                }
                semana.Add(dia);
            }
            return semana;
        }


        /* Método - Troca aulas. Troca aulas entre elas mesmas. 
            Recebe duas tuplas contendo <int (Dia da semana), <int (Horario do dia)>.*/
        public void TrocaAulas(Tuple<int, int> aulaEntrada1, Tuple<int, int> aulaEntrada2)
        {
            if(aulaEntrada2 != null)
            {
                var aula1 = Dias[aulaEntrada1.Item1].Aulas[aulaEntrada1.Item2];
                var aula2 = Dias[aulaEntrada2.Item1].Aulas[aulaEntrada2.Item2];

                Dias[aulaEntrada1.Item1].Aulas[aulaEntrada1.Item2] = aula2;
                Dias[aulaEntrada2.Item1].Aulas[aulaEntrada2.Item2] = aula1;
            }
        }
    }
}
