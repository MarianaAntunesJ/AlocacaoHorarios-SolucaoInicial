namespace AlocacaoHorarios_SolucaoInicial.Entities
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
