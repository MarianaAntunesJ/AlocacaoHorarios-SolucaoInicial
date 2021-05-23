using AlocacaoHorarios_SolucaoInicial.Entities;
using System;
using System.Linq;
using System.Collections.Generic;
using ConsoleTables;

namespace AlocacaoHorarios_SolucaoInicial.View
{
    class Exibicao
    {
        private List<Dia> _dias { get; }

        public Exibicao(List<Dia> dias)
        {
            _dias = dias;
        }

        private Array[] GeraCampoDoHorario(int aula)
        {
            var disciplinas = _dias.Select(_ => _.Aulas[aula].Disciplina.Nome).ToArray();
            var professores = _dias.Select(_ => _.Aulas[aula].Disciplina.Professor.Nome).ToArray();
            var salas = _dias.Select(_ => _.Aulas[aula].Sala.Id.ToString()).ToArray();

            return new Array[] { disciplinas, professores, salas };
        }

        private string[] GerarTracejado()
        {
            var a = new string('-', PegaMaiorString());
            return new string[] { a, a, a, a, a };
        }

        public void ExibirSemana()
        {
            var cabecalhoDaSemana = _dias.Select(_ => $"{_.DiaDaSemana}-Feira").ToArray();
            var tracejado = GerarTracejado();
            var table = new ConsoleTable(cabecalhoDaSemana);

            for (var i = 0; i <= 3; i++)
            {
                var horario = GeraCampoDoHorario(i);
                table.AddRow((string[])horario[0])
                    .AddRow((string[])horario[1])
                    .AddRow((string[])horario[2])
                    .AddRow(tracejado);
            }

            table.Write(Format.MarkDown);
        }

        private int PegaMaiorString()
        {
            var maiores = new List<int>
            {
                _dias.Max(_ => _.Aulas.Max(_ => _.Disciplina.Professor.Nome.Length)),
                _dias.Max(_ => _.Aulas.Max(_ => _.Disciplina.Nome.Length)),
                _dias.Max(_ => $"{_.DiaDaSemana}-Feira".Length)
            };

            return maiores.Max() + 2;
        }
    }
}
