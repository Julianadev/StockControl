namespace ControleEstoque_BackEnd
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int Entrada { get; set; }

        public int Saida => 32 + (int)(Entrada / 0.5556);

        public string? Summary { get; set; }
    }
}