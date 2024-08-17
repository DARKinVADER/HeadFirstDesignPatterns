namespace Observer.Subject
{
    public record State
    {
        public decimal Temperature { get; internal set; }
        public decimal Humidity { get; internal set; }
        public decimal Pressure { get; internal set; }
    }
}