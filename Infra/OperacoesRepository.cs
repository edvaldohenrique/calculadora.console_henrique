﻿using Domain;

namespace Infra
{
    public class OperacoesRepository
    {
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
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Erro no EF", ex);
            }
        }
    }
}