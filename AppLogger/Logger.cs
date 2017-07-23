using System;
namespace AppLogger
{
    //https://docs.microsoft.com/en-us/nuget/create-packages/publish-a-package
    //https://docs.microsoft.com/en-us/nuget/guides/create-net-standard-packages-vs2017
    public class Logger
    {
        public void Log(string text)
        {
            Console.WriteLine(text);
        }
    }
}