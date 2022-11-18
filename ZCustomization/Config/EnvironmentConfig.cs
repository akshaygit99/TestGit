using System;
using Microsoft.Extensions.Configuration;

namespace ZCustomization.Config
{

    public class EnvironmentConfig
    {
        public static string getEnvironment()
        {
            var testEnvironment = Environment.GetEnvironmentVariable("Environment");
            if(testEnvironment == null){
                var testConfig = new ConfigurationBuilder().AddJsonFile("clientSecrets.json").Build();
            return  testConfig["Environment"];
            } else
            return  testEnvironment;
        }

    }


}