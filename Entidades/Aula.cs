namespace AlocacaoHorarios_SolucaoInicial.Entidades
{
    class Aula
    {
        public int Id { get; set; }
        public Disciplina Disciplina { get; set; }
        public Sala Sala { get; set; }

        public Aula()
        {
        }

        public Aula(int id, Disciplina disciplina, Sala sala)
        {
            Id = id;
            Disciplina = disciplina;
            Sala = sala;
        }
    }
}
