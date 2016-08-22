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
        public string getWeather;
        public string currentWeather;
        public int getTemperature;
        public int currentTemperature;
        public string tomorrowsWeather;
        public int tomorrowsTemperature;
        Random randomWeather = new Random();
        public Weather()
        {
            getWeather = SetWeather();
            currentWeather = getWeather;
            getTemperature = SetTemperature();
            currentTemperature = getTemperature;
            //Thread.Sleep(500);
            tomorrowsWeather = SetWeather();
            tomorrowsTemperature = SetTemperature();
        }
        public string SetWeather()
        {
            int weather = randomWeather.Next(1, 4);
            switch (weather)
            {
                case 1:
                    getWeather = "Sunny";
                    break;
                case 2:
                    getWeather = "Rainy";
                    break;
                default:
                    getWeather = "Cloudy";
                    break;
            }
            return getWeather;
        }
        public int SetTemperature()
        {
            Random randomTemperature = new Random();
            getTemperature = randomTemperature.Next(50, 101);

            return getTemperature;
        }
        public int ChangeWeather()
        {
            if (getWeather == "Rainy")
            {
                currentTemperature = currentTemperature - 10;
                return currentTemperature;
            }
            else if (getWeather == "Cloudy")
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
