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

        public bool DiaDesocupado(int index) => Dias[index] == null;

        public bool InsereNoDiaDesocupado(Dia dia, int index)
        {
            if (DiaDesocupado(index))
            {
                Dias[index] = dia;
                return true;
            }  
            return false;
        }

        public void TrocaDias(int dia1, int dia2)
        {
            var aux = Dias[dia1];
            Dias[dia1] = Dias[dia2];
            Dias[dia2] = aux;
        }
    }

    //ToDo: o que ele faz?
    enum Periodos
    {
        Primeiro,
        Segundo,
        Quarto,
        Quinto,
        Sexto
    }
}
