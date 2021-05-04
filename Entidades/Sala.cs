﻿namespace AlocacaoHorarios_SolucaoInicial.Entidades
{
    class Sala
    {
        public int Id { get; set; }
        public bool SalaPratica { get; set; }
        public int Capacidade { get; set; }

        public Sala()
        {
        }

        public Sala(int id, bool salaPratica, int capacidade)
        {
            Id = id;
            SalaPratica = salaPratica;
            Capacidade = capacidade;
        }
    }
}
