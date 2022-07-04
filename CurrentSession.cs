using System;

namespace WebApi
{
    public class CurrentSession
    {
        static readonly Lazy<CurrentSession> _instance = new Lazy<CurrentSession>();

        public static CurrentSession Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        public string RawWeatherData { get; set; }
    }
}
