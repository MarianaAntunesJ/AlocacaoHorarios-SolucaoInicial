namespace AlocacaoHorarios_SolucaoInicial.Entidades
{
    class Dia
    {
        public DiaDaSemana DiaDaSemana { get; set; }
        public Aula[] Aulas { get; set; } = new Aula[2];
    }

    enum DiaDaSemana
    {
        Segunda,
        Terça,
        Quarta,
        Quinta,
        Sexta
    }
}
