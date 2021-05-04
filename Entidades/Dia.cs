namespace AlocacaoHorarios_SolucaoInicial.Entidades
{
    class Dia
    {
        public DiasDaSemana DiaDaSemana { get; set; }
        public Aula[] Aulas { get; set; }

        public Dia()
        {
            Aulas = new Aula[2];
        }

        public Dia(DiasDaSemana diaDaSemana) : this()
        {
            DiaDaSemana = diaDaSemana;
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
