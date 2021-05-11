using AlocacaoHorarios_SolucaoInicial.Entidades;
using System.Collections.Generic;

namespace AlocacaoHorarios_SolucaoInicial.DAL
{
    class Seed
    {
        public List<Professor> Professores { get; }
        public List<Sala> Salas { get; }
        public List<Disciplina> Disciplinas { get; }
        public List<Aula> Aulas { get; }
        public List<Dia> Dias { get; }

        public Seed()
        {
            Professores = new List<Professor>();
            Salas = new List<Sala>();
            Disciplinas = new List<Disciplina>();
            Aulas = new List<Aula>();
            Dias = new List<Dia>();

            PreencheProfessores();
            PreencheSalas();
            PreencheDisciplinasPrimeiroSemestre();
            PreencheAula();
            PreencheDia();
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
            Aulas.Add(new Aula(1 ,GetDisicplinaId(1), GetSalaId(10)));
            Aulas.Add(new Aula(2 ,GetDisicplinaId(2), GetSalaId(10)));
            Aulas.Add(new Aula(3 ,GetDisicplinaId(3), GetSalaId(10)));
            Aulas.Add(new Aula(4 ,GetDisicplinaId(4), GetSalaId(10)));
            Aulas.Add(new Aula(5 ,GetDisicplinaId(5), GetSalaId(10)));
            Aulas.Add(new Aula(6 ,GetDisicplinaId(6), GetSalaId(10)));
        }

        public Aula GetAulaId(int id)
        {
            foreach (var aula in Aulas)
                if (id == aula.Id)
                    return aula;
            return null;
        }

        public void PreencheDia()
        {
            Aula[] segunda = new Aula[2] { GetAulaId(1), GetAulaId(6) };
            Aula[] terca = new Aula[2] { GetAulaId(4), GetAulaId(6) };
            Aula[] quarta = new Aula[2] { GetAulaId(5), GetAulaId(2) };
            Aula[] quinta = new Aula[2] { GetAulaId(1), GetAulaId(4) };
            Aula[] sexta = new Aula[2] { GetAulaId(2), GetAulaId(3) };

            Dias.Add(new Dia(1, segunda));
            Dias.Add(new Dia(2, terca));
            Dias.Add(new Dia(3, quarta));
            Dias.Add(new Dia(4, quinta));
            Dias.Add(new Dia(5, sexta));
        }
    }
}
