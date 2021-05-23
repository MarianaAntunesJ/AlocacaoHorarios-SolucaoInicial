using AlocacaoHorarios_SolucaoInicial.DAL;
using AlocacaoHorarios_SolucaoInicial.View;

namespace AlocacaoHorarios_SolucaoInicial
{
    class Program
    {
        static void Main()
        {
            Seed popula = new Seed();

            Exibicao exibicao = new Exibicao(popula.Semana);

            exibicao.ExibirSemana();
        }
    }
}
