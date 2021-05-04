namespace AlocacaoHorarios_SolucaoInicial.Entidades
{
    class Horario
    {
        public Periodos Periodo { get; set; }
        public Dia[] Dias { get; set; }

        public Horario()
        {
            Dias = new Dia[5];
        }

        public Horario(Periodos periodo) : this()
        {
            Periodo = periodo;
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
