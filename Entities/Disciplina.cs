namespace AlocacaoHorarios_SolucaoInicial.Entities
{
    class Disciplina
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int AulasPorSemana { get; set; }
        public int QntAlunosMatriculados { get; set; }
        public int Periodo { get; set; }
        public bool SalaPratica { get; set; }
        public Professor Professor { get; set; }

        public Disciplina()
        {
        }

        public Disciplina(int id, string nome, int aulasPorSemana, int qntAlunosMatriculados, int periodo, bool salaPratica, Professor professor)
        {
            Id = id;
            Nome = nome;
            AulasPorSemana = aulasPorSemana;
            QntAlunosMatriculados = qntAlunosMatriculados;
            Periodo = periodo;
            SalaPratica = salaPratica;
            Professor = professor;
        }
    }
}
