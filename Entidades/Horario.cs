namespace AlocacaoHorarios_SolucaoInicial.Entidades
{
    class Horario
    {
        public Periodos Periodo { get; set; }
        public Dia[] Dias { get; set; } = new Dia[5];

        public Horario()
        {
        }

        public Horario(Periodos periodo, Dia[] dias)
        {
            Periodo = periodo;
            Dias = dias;
        }
    }

    enum Periodos
    {
        Primeiro,
        Segundo,
        Quarto,
        Quinto,
        Sexto
    }
}
