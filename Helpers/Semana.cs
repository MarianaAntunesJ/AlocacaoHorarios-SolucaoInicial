using AlocacaoHorarios_SolucaoInicial.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AlocacaoHorarios_SolucaoInicial.Helpers
{
    class Semana
    {
        public List<Dia> Dias { get; set; }
        public List<Dia> PreencheSemana(List<Aula> aulas)
            => CriaSemana(DistribuiAulas(AulasParaTodasAsAulasDaSemana(aulas)));

        public Semana() : this(new List<Dia>())
        {
        }

        public Semana(List<Dia> dias)
        {
            Dias = dias;
        }

        //Lista de consumo com o total de cada matéria p/ semana
        //Todo: mudar nome
        private List<Aula> AulasParaTodasAsAulasDaSemana(List<Aula> aulas)
        {
            var aulasPorCargaHoraria = new List<Aula>();
            foreach (var aula in aulas)
            {
                for (var i = 1; i <= aula.Disciplina.AulasPorSemana; i++)
                    aulasPorCargaHoraria.Add(aula);
            }
            return aulasPorCargaHoraria;
        }

        //lista de consumo (todas aulas) e sai lista "bagunçada"
        private List<Aula> DistribuiAulas(List<Aula> aulas)
        {
            //usa o hash pq ele muda bastante a cada geração
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

        //Popula lista semana através da lista random
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
