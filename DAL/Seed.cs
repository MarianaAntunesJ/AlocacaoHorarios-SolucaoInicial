using AlocacaoHorarios_SolucaoInicial.Entities;
using AlocacaoHorarios_SolucaoInicial.Helper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AlocacaoHorarios_SolucaoInicial.DAL
{
    class Seed
    {
        public List<Professor> Professores { get; }
        public List<Sala> Salas { get; }
        public List<Disciplina> Disciplinas { get; }
        public List<Aula> Aulas { get; }
        public List<Dia> Semana { get; }

        public Seed()
        {
            Professores = new List<Professor>();
            Salas = new List<Sala>();
            Disciplinas = new List<Disciplina>();
            Aulas = new List<Aula>();

            PreencheProfessores();
            PreencheSalas();
            PreencheDisciplinasPrimeiroSemestre();
            PreencheAula();
            Semana = PreencheSemana(Aulas);
        }

        public void PreencheProfessores()
        {
            Professores.Add(new Professor("1", "Augusto Manzano"));
            Professores.Add(new Professor("2", "Karin Nin Brauer"));
            Professores.Add(new Professor("3", "Fernanda Aparecida"));
            Professores.Add(new Professor("4", "Marques Souza"));
            Professores.Add(new Professor("5", "Paulo Giovani"));
            Professores.Add(new Professor("6", "Avelino Júnior"));
            Professores.Add(new Professor("7", "Fábio Viana"));
            Professores.Add(new Professor("8", "João Correia"));
            Professores.Add(new Professor("9", "Elton Ferreira"));
            Professores.Add(new Professor("10", "João Evangelista"));
            Professores.Add(new Professor("11", "Alisson Ribeiro"));
            Professores.Add(new Professor("12", "Helton Júnior"));
            Professores.Add(new Professor("13", "Fernanda Maffei "));
        }

        public void PreencheSalas()
        {
            Salas.Add(new Sala(1, true, 20));
            Salas.Add(new Sala(3, true, 42));
            Salas.Add(new Sala(4, false, 24));
            Salas.Add(new Sala(6, false, 29));
            Salas.Add(new Sala(8, false, 56));
            Salas.Add(new Sala(9, true, 51));
            Salas.Add(new Sala(10, false, 50));
            Salas.Add(new Sala(11, true, 59));
            Salas.Add(new Sala(12, false, 40));
            Salas.Add(new Sala(13, false, 27));

        }

        public Professor GetProfessorId(string id)
        {
            foreach (var professor in Professores)
                if (id == professor.Id)
                    return professor;
            return null;
        }

        public void PreencheDisciplinasPrimeiroSemestre()
        {
            Disciplinas.Add(new Disciplina(1, "Logica", 6, 50, 1, false, GetProfessorId("1")));
            Disciplinas.Add(new Disciplina(2, "Arquitetura", 4, 50, 1, false, GetProfessorId("12")));
            Disciplinas.Add(new Disciplina(3, "Comunicacao", 2, 50, 1, false, GetProfessorId("3")));
            Disciplinas.Add(new Disciplina(4, "Ingles", 4, 50, 1, false, GetProfessorId("2")));
            Disciplinas.Add(new Disciplina(5, "Matematica", 2, 50, 1, false, GetProfessorId("13")));
            Disciplinas.Add(new Disciplina(6, "Historia", 2, 50, 1, false, GetProfessorId("7")));
        }

        public Disciplina GetDisicplinaId(int id)
        {
            foreach (var disciplina in Disciplinas)
                if (id == disciplina.Id)
                    return disciplina;
            return null;
        }

        public Sala GetSalaId(int id)
        {
            foreach (var sala in Salas)
                if (id == sala.Id)
                    return sala;
            return null;
        }

        public void PreencheAula()
        {
            for(var i = 1; i <= 6; i++)
                Aulas.Add(new Aula(i, GetDisicplinaId(i), GetSalaId(10)));
        }

        public Aula GetAulaId(int id)
        {
            foreach (var aula in Aulas)
                if (id == aula.Id)
                    return aula;
            return null;
        }

        public List<Dia> PreencheSemana(List<Aula> aulas)
        {
            Semana semana = new Semana();
            return semana.PreencheSemana(aulas);
        }
    }
}
