namespace Devops_Infnet
{
    public class PrevisaoDoTempo
    {
        private const int ConstTemperaturaMinimaF = 32;  
        public DateTime Data { get; set; }

        public int TemperaturaC { get; set; }

        public int TemperaturaF { get { return CaculoTemperaturaF(TemperaturaC);} }

        public string? Resumo { get; set; }

        public int CaculoTemperaturaF(int temperaturaC)
        {
            return ConstTemperaturaMinimaF + (int)(temperaturaC / 0.5556);
        }

    }
}