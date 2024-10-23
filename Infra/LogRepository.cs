namespace Infra
{
    public class LogRepository
    {
        private string path = Directory.GetCurrentDirectory() + "/ultimo_comando.txt";
        public LogRepository() { }


        public async Task Logar(string operacao, DateTime data, float resultado)
        {
            var log = string.Format("Data: {0} | Operação: {1} | Resultado: {2}", data, operacao, resultado);

            if(!File.Exists(path))
            {
                File.Create(path);
            }

            using var arquivo = File.AppendText(path);
            await arquivo.WriteLineAsync(log);
            arquivo.Close();
        }
    }
}
