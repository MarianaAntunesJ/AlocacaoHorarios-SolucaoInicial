using AlocacaoHorarios_SolucaoInicial.DAL;
using AlocacaoHorarios_SolucaoInicial.Helpers;
using AlocacaoHorarios_SolucaoInicial.View;

namespace AlocacaoHorarios_SolucaoInicial
{
    class Program
    {
        static void Main()
        {
            var popula = new Seed();

            var restricoes = new Restricoes();

            var exibicao = new Exibicao(popula.Semana);

            exibicao.ExibirSemana();

            exibicao._semana = restricoes.A(popula.Semana);

            exibicao.ExibirSemana();
        }
    }
}
