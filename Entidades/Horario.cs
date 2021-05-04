namespace AlocacaoHorarios_SolucaoInicial.Entidades
{
    class Horario
    {
        public Periodos Periodo { get; private set; }
        private Dia[] _dias { get; set; }

        public Horario()
        {
            _dias = new Dia[5];
        }

        public Horario(Periodos periodo) : this()
        {
            Periodo = periodo;
        }

        public bool DiaOcupado(int index) => _dias[index] != null;

        public bool InsereNoDiaDesocupado(Dia dia, int index)
        {
            if (!DiaOcupado(index))
            {
                _dias[index] = dia;
                return true;
            }  
            return false;
        }

        public void TrocaDias(int dia1, int dia2)
        {
            var aux = _dias[dia1];
            _dias[dia1] = _dias[dia2];
            _dias[dia2] = aux;
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
