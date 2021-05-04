namespace AlocacaoHorarios_SolucaoInicial.Entidades
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
    }
}
