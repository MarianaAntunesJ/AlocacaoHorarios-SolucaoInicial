namespace AlocacaoHorarios_SolucaoInicial.Entidades
{
    class Horario
    {
        public Periodo Periodo { get; set; }
        public Dia[] Dias { get; set; } = new Dia[5];
    }

    enum Periodo
    {
        Primeiro,
        Segundo,
        Quarto,
        Quinto,
        Sexto
    }
}
