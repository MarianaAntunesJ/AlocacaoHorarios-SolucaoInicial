namespace AlocacaoHorarios_SolucaoInicial.Entidades
{
    class Professor
    {
        public string Id { get; set; }
        public string Nome { get; set; }

        public Professor()
        {
        }

        public Professor(string id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
