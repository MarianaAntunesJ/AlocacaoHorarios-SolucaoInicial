using AlocacaoHorarios_SolucaoInicial.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AlocacaoHorarios_SolucaoInicial
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Cadastro de professores
            Console.WriteLine("Insira os Professores:");

            List<Professor> professores = new List<Professor>();

            Console.WriteLine("Inisira quantidade de professores a serem adicionados:");
            int quantidadeDeProfessores = int.Parse(Console.ReadLine());

            var professor = new Professor();
            for(int i = 0; i < quantidadeDeProfessores; i++)
            {
                professor.Id = Console.ReadLine();
                professor.Nome = Console.ReadLine();
                professores.Add(professor);
            }
            // *******************************************************************************
            */

            //Cadastro de salas
            Console.WriteLine("Insira as salas:");

            List<Sala> salas = new List<Sala>();

            Console.WriteLine("Inisira quantidade de salas a serem adicionados:");
            int quantidadeDeSalas = int.Parse(Console.ReadLine());

            var sala = new Sala();
            for (int i = 0; i < quantidadeDeSalas; i++)
            {
                sala.Id = int.Parse(Console.ReadLine());
                sala.SalaPratica = bool.Parse(Console.ReadLine());
                sala.Capacidade = int.Parse(Console.ReadLine());
                salas.Add(sala);
            }

            List<Sala> SortedListSala = salas.OrderByDescending(_ => _.Capacidade).ToList();
            // *******************************************************************************


            //Cadastro de disciplinas

            var disciplinas = new List<Disciplina>();

            Console.WriteLine("Insira quantidade de disciplinas:");
            int quantidadeDeDisciplinas = int.Parse(Console.ReadLine());

            

            for (int i = 0; i < quantidadeDeDisciplinas; i++)
            {
                var disciplina = new Disciplina();
                disciplina.Nome = Console.ReadLine();
                disciplina.Periodo = int.Parse(Console.ReadLine());
                disciplina.Professor = Console.ReadLine();
                disciplina.SalaPratica = bool.Parse(Console.ReadLine());
                disciplina.AulasPorSemana = int.Parse(Console.ReadLine());
                disciplina.QntAlunosMatriculados = int.Parse(Console.ReadLine());
                disciplinas.Add(disciplina);
            }
            // *******************************************************************************

            List<Disciplina> SortedListDisciplina = disciplinas.OrderByDescending(_ => _.QntAlunosMatriculados).ToList();

            foreach(Disciplina objeto in SortedListDisciplina)
                Console.WriteLine(objeto.Nome);



        }
    }
}
