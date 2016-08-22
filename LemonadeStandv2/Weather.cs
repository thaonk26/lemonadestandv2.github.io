using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LemonadeStandv2
{
    class Weather
    {
        Random randomWeather = new Random();
        public string currentWeather;
        public int currentTemperature;
        public string tomorrowsWeather;
        public int tomorrowsTemperature;
        public Weather()
        {
            currentWeather = SetWeather();
            currentTemperature = SetTemperature();
            Thread.Sleep(500);
            tomorrowsWeather = SetWeather();
            tomorrowsTemperature = SetTemperature();
        }
        public string SetWeather()
        {
            int weather = randomWeather.Next(1, 4);
            switch (weather)
            {
                case 1:
                    currentWeather = "Sunny";
                    break;
                case 2:
                    currentWeather = "Rainy";
                    break;
                default:
                    currentWeather = "Cloudy";
                    break;
            }
            return currentWeather;
        }
        public int SetTemperature()
        {
            currentTemperature = randomWeather.Next(50, 101);

            return currentTemperature;
        }
        public int ChangeWeather()
        {
            if (currentWeather == "Rainy")
            {
                currentTemperature = currentTemperature - 10;
                return currentTemperature;
            }
            else if (currentWeather == "Cloudy")
            {
                currentTemperature = currentTemperature - 5;
                return currentTemperature;
            }
            else
            {
                currentTemperature = currentTemperature + 5;
                return currentTemperature;
            }
        }
        public void SetCurrentWeather()
        {
            currentWeather = tomorrowsWeather;
            currentTemperature = tomorrowsTemperature;
            tomorrowsWeather = SetWeather();
            tomorrowsTemperature = SetTemperature();
        }
    }
}
