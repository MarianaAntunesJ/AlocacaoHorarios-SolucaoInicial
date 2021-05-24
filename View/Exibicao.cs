using System;
using System.Linq;
using System.Collections.Generic;
using ConsoleTables;
using AlocacaoHorarios_SolucaoInicial.Helpers;

namespace AlocacaoHorarios_SolucaoInicial.View
{
    class Exibicao
    {
        public Semana _semana { get; set; }

        public Exibicao(Semana semana)
        {
            _semana = semana;
        }

        /*Método - Gera campos do horário. 
          Cria arrays de disciplinas, professores e salas. Depois insere em um array único. (Array[ ]).*/
        private Array[] GeraCampoDoHorario(int aula)
        {
            var disciplinas = _semana.Dias.Select(_ => _.Aulas[aula].Disciplina.Nome).ToArray();
            var professores = _semana.Dias.Select(_ => _.Aulas[aula].Disciplina.Professor.Nome).ToArray();
            var salas = _semana.Dias.Select(_ => _.Aulas[aula].Sala.Id.ToString()).ToArray();

            return new Array[] { disciplinas, professores, salas };
        }

        /* Método - gera traços. Visual. 
            Apenas traceja o horário a cada 3 rows (linhas) - disciplina, professor e sala - para melhor visualização.*/
        private string[] GerarTracejado()
        {
            var tracos = new string('-', PegaMaiorString());
            return new string[] { tracos, tracos, tracos, tracos, tracos };
        }

        /* Package utilizado: ConsoleTables, por Khalid Akmeh. 
           Método - Exibe semana. Construímos uma table para o horário, adicionando nossas aulas em rows. */
        public void ExibirSemana()
        {
            var cabecalhoDaSemana = _semana.Dias.Select(_ => $"{_.DiaDaSemana}-Feira").ToArray();
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

            table.Write(Format.MarkDown); //Tira tracejado a cada row
        }

        /* Método - Pegar a maior string. 
            Procura a maior string e retorna seu length, para fins como limitação de tracejado de linha.*/
        private int PegaMaiorString()
        {
            var maiores = new List<int>
            {
                _semana.Dias.Max(_ => _.Aulas.Max(_ => _.Disciplina.Professor.Nome.Length)),
                _semana.Dias.Max(_ => _.Aulas.Max(_ => _.Disciplina.Nome.Length)),
                _semana.Dias.Max(_ => $"{_.DiaDaSemana}-Feira".Length)
            };

            return maiores.Max() + 2;
        }
    }
}
