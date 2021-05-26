namespace WeatherTempProvider
{
    internal class TempInF : IWeatherTemp
    {
        public float Temp { get; set; }
        public string City { get; set; }

        public TempInF(float temp, string city)
        {
            Temp = temp;
            City = city;
        }
    }

}
