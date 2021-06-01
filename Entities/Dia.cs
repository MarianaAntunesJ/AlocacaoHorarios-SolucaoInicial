namespace AlocacaoHorarios_SolucaoInicial.Entities
{
    class Dia
    {
        // Defini quantidades de aulas para o vetor
        private readonly int _qtdAulas = 4;

        // Tipo enum para definir o nome do dia. Ex: segunda
        public DiasDaSemana DiaDaSemana { get; set; }

        public Aula[] Aulas { get; private set; }

        public Dia()
        {
            Aulas = new Aula[_qtdAulas];

            // Intancia todos os index do vetor Aulas;
            for(var i = 0; i < _qtdAulas; i++)
            {
                Aulas[i] = new Aula();
            }
        }

        public Dia(DiasDaSemana diaDaSemana, Aula[] aulas)
        {
            DiaDaSemana = diaDaSemana;
            Aulas = aulas;
        }

        public bool AulaDesocupada(int index) => Aulas[index] == null;

        public bool InsereNaAulaDesocupada(Aula aula, int index)
        {
            if (AulaDesocupada(index))
            {
                Aulas[index] = aula;
                return true;
            }
            return false;
        }
    }

    enum DiasDaSemana
    {
        Segunda = 1,
        Terça = 2,
        Quarta = 3,
        Quinta = 4,
        Sexta = 5
    }
}
