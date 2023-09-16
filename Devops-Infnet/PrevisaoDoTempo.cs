namespace Devops_Infnet
{
    public class PrevisaoDoTempo
    {
        public DateTime Data { get; set; }

        public int TemperaturaC { get; set; }

        public int TemperaturaF => 32 + (int)(TemperaturaC / 0.5556);

        public string? Resumo { get; set; }
    }
}