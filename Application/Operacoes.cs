using Domain;
using Infra;

namespace Application
{
    public class Operacoes
    {
        public async static Task<float> Somar(float n1, float n2)
        {
            var operacoesRepository = new OperacoesRepository();
            var resultado = n1 + n2;
            var operacao = new Operacao("Soma", resultado, DateTime.Now);
            await operacoesRepository.Insert(operacao);

            return resultado;
        }

        public async static Task<float> Subtrair(float n1, float n2)
        {
            var operacoesRepository = new OperacoesRepository();
            var resultado = n1 - n2;
            var operacao = new Operacao("Subtração", resultado, DateTime.Now);
            await operacoesRepository.Insert(operacao);

            return resultado;
        }

        public async static Task<float> Multiplicar(float n1, float n2)
        {
            var operacoesRepository = new OperacoesRepository();
            var resultado = n1 * n2;
            var operacao = new Operacao("Multiplicação", resultado, DateTime.Now);
            await operacoesRepository.Insert(operacao);

            return resultado;
        }

        public async static Task<float> Dividir(float n1, float n2)
        {
            var operacoesRepository = new OperacoesRepository();
            var resultado = n1 / n2;
            var operacao = new Operacao("Divisão", resultado, DateTime.Now);
            await operacoesRepository.Insert(operacao);

            return resultado;
        }
    }
}