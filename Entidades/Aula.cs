namespace AlocacaoHorarios_SolucaoInicial.Entidades
{
    class Aula
    {
        public Disciplina Disciplina { get; set; }
        public Sala Sala { get; set; }

        public Aula()
        {
        }

        public Aula(Disciplina disciplina, Sala sala)
        {
            Disciplina = disciplina;
            Sala = sala;
        }
    }
}
