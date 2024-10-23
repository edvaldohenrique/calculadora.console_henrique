using Domain;

namespace Infra
{
    public class OperacoesRepository
    {
        private LogRepository logRepository { get; set; }

        public OperacoesRepository()
        {
            this.logRepository = new LogRepository();
        }

        public async Task Insert(Operacao operacao)
        {
            try
            {
                using (var _dbConnection = new SqlServerContext())
                {
                    if (operacao != null)
                    {
                        await _dbConnection.Operacoes.AddAsync(operacao);
                        await _dbConnection.SaveChangesAsync();
                    }

                    await logRepository.Logar(operacao.Nome, operacao.Data, operacao.Valor);
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Erro no EF", ex);
            }
        }
    }
}
