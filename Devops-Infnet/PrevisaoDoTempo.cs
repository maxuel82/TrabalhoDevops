namespace Devops_Infnet
{
    public class PrevisaoDoTempo
    {
        private const int _constTemperaturaMinimaF = 32;
        
        public DateTime Data { get; set; }

        public int TemperaturaC { get; set; }

        public string? Resumo { get; set; }

        public int CaculoTemperaturaF(int temperaturaC)
        {
            return _constTemperaturaMinimaF + (int)(temperaturaC / 0.5556);
        }

    }
}