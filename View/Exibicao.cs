using AlocacaoHorarios_SolucaoInicial.Entidades;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace AlocacaoHorarios_SolucaoInicial.View
{
    class Exibicao
    {
        private int _maiorString { get; set; }

        //ToDo: lógica para espaços, problema: usando o ceiling para string com total impar
        public void ExibirSemana(List<Dia> dias)
        {
            CalculaMaiorString(dias);

            var stringBuilder = new StringBuilder();

            stringBuilder = CabecalhoSemana(dias, stringBuilder);

            for (var i = 0; i <= 3; i++)
            {
                stringBuilder = Aula(dias, stringBuilder, i);
                stringBuilder = Professor(dias, stringBuilder, i);
                stringBuilder = Sala(dias, stringBuilder, i);
            }

            Console.WriteLine(stringBuilder);
        }

        private StringBuilder CabecalhoSemana(List<Dia> dias, StringBuilder stringBuilder)
        {
            foreach (var dia in dias)
            {
                var space = new string(' ', (int)Math.Ceiling((_maiorString - $"{dia.DiaDaSemana}-Feira".Length) / 2.0));
                stringBuilder.Append($"{space}{dia.DiaDaSemana}-Feira{space}|");
            }

            stringBuilder.Append("\n");
            return stringBuilder;
        }

        private StringBuilder Aula(List<Dia> dias, StringBuilder stringBuilder, int index)
        {
            foreach (var dia in dias)
            {
                var space = new string(' ', (int)Math.Ceiling((_maiorString - dia.Aulas[index].Disciplina.Nome.Length) / 2.0));
                stringBuilder.Append($"{space}{dia.Aulas[index].Disciplina.Nome}{space}|");
            }   
            stringBuilder.Append("\n");
            return stringBuilder;
        }

        private StringBuilder Professor(List<Dia> dias, StringBuilder stringBuilder, int index)
        {
            foreach (var dia in dias)
            {
                var space = new string(' ', (int)Math.Ceiling((_maiorString - dia.Aulas[index].Disciplina.Professor.Nome.Length) / 2.0));
                stringBuilder.Append($"{space}{dia.Aulas[index].Disciplina.Professor.Nome}{space}|");
            }
            stringBuilder.Append("\n");
            return stringBuilder;
        }

        private StringBuilder Sala(List<Dia> dias, StringBuilder stringBuilder, int index)
        {
            foreach (var dia in dias)
            {
                var space = new string(' ', (int)Math.Ceiling((_maiorString - dia.Aulas[index].Sala.Id.ToString().Length) / 2.0));
                stringBuilder.Append($"{space}{dia.Aulas[index].Sala.Id}{space}|");
            }
                
            stringBuilder.Append('\n');
            stringBuilder.Append('-', 118);
            stringBuilder.Append('\n');
            return stringBuilder;
        }

        private void CalculaMaiorString(List<Dia> dias)
        {
            foreach (var dia in dias)
            {
                var a = dia.Aulas.OrderByDescending(_ => _.Disciplina.Professor.Nome.Length).First().Disciplina.Professor.Nome.Length;
                if (a > _maiorString)
                    _maiorString = a;
            }
            _maiorString += 2;
        }
    }
}
