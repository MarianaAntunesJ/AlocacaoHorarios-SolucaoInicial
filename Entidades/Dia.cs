namespace AlocacaoHorarios_SolucaoInicial.Entidades
{
    class Dia
    {        
        public Aula[] Aulas { get; private set; }

        public Dia()
        {
            Aulas = new Aula[2];
        }

        public bool AulaDesocupada(int index) => Aulas[index] == null;

        public bool InsereNaAulaDesocupada(Aula aula, int index)
        {
            if (AulaDesocupada(index))
            {
                Aulas[index] = aula;
                return true;
            }
            return false;
        }

        public void TrocaDias(int aula1, int aula2)
        {
            var aux = Aulas[aula1];
            Aulas[aula1] = Aulas[aula2];
            Aulas[aula2] = aux;
        }
    }
}
