namespace AlocacaoHorarios_SolucaoInicial.Entities
{
    class Dia
    {
        public DiasDaSemana DiaDaSemana { get; set; }
        public Aula[] Aulas { get; private set; }

        public Dia()
        {
            Aulas = new Aula[4] { new Aula(), new Aula(), new Aula(), new Aula() };
        }

        public Dia(DiasDaSemana diaDaSemana, Aula[] aulas)
        {
            DiaDaSemana = diaDaSemana;
            Aulas = aulas;
        }

        public bool AulaDesocupada(int index) => Aulas[index] == null;

        //ToDo: Refazer para vetor[4]
        public bool InsereNaAulaDesocupada(Aula aula, int index)
        {
            if (AulaDesocupada(index))
            {
                Aulas[index] = aula;
                return true;
            }
            return false;
        }

        //ToDo: Refazer para vetor[4]
        public void TrocaDias(int aula1, int aula2)
        {
            var aux = Aulas[aula1];
            Aulas[aula1] = Aulas[aula2];
            Aulas[aula2] = aux;
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
