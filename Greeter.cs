using System;

namespace SampleASPCore
{
    public class Greeter : IGreeter
    {
        public string GreetingMessageOfTheDay()
        {
            string dayName = DateTime.Now.ToString("dddd");
            return "Hello Today is " + dayName;
        }
    }
}