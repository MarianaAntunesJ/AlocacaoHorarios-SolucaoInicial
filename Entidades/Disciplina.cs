namespace AlocacaoHorarios_SolucaoInicial.Entidades
{
    class Disciplina
    {
        public string Nome { get; set; }
        public int CargaHorariaSemanal { get; set; }
        public int Periodo { get; set; }
        public bool SalaPratica { get; set; }
        public Professor Professor { get; set; }
    }
}
