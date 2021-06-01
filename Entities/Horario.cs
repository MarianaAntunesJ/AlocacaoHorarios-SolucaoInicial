namespace AlocacaoHorarios_SolucaoInicial.Entities
{
    class Horario
    {
        public Periodos Periodo { get; private set; }
        public Dia[] Dias { get; private set; }

        public Horario()
        {
            Dias = new Dia[5];
        }

        public Horario(Periodos periodo) : this()
        {
            Periodo = periodo;
        }
    }

    //ToDo: implementar
    enum Periodos
    {
        Primeiro,
        Segundo,
        Quarto,
        Quinto,
        Sexto
    }
}
