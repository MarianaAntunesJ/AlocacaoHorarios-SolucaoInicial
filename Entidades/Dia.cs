namespace AlocacaoHorarios_SolucaoInicial.Entidades
{
    class Dia
    {
        public DiasDaSemana DiaDaSemana { get; set; }
        public Aula[] Aulas { get; set; } = new Aula[2];

        public Dia()
        {
        }

        public Dia(DiasDaSemana diaDaSemana, Aula[] aulas)
        {
            DiaDaSemana = diaDaSemana;
            Aulas = aulas;
        }
    }

    enum DiasDaSemana
    {
        Segunda,
        Terça,
        Quarta,
        Quinta,
        Sexta
    }
}
