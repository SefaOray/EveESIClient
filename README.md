# EveESIClient
Rest client for Eve online ESI API.

.Net Core client library to help you to send requests to [Eve Online ESI API](https://esi.tech.ccp.is/ui/#/). 

# Usage


    using System;
    using EveESIClient;
    
    namespace ConsoleApp5
    {
        class Program
        {
            static void Main(string[] args)
            {
                var esiClient = new ESIClient();
                var serverStatus = esiClient.Status.GetStatus();
                Console.WriteLine($"Currently {serverStatus.Data.Players} pilots online.");
            }
        }
    }
    

# Configuring the client

This library offers a method, which allows you to configure various variables.

Call `ESIClient.Configure`  method and return a `ClientConfiguration` object, which will be used by the client. 

    ESIClient.Configure(() =>
     {
         var conf = new ClientConfiguration();
         conf.DataSource = ClientTarget.Tranquility;
         conf.XUserAgent = "MyUserAgent";
         return conf;
     });
     
Configuration is global and will be applied to all requests. 

# Missing data or exceptions? 

Response models are hard-coded in the project and they need to be maintained as CCP updates their responses.

When API response is updated but the client is not, you will start seeing missing data or deserialization exceptions. You have two options;

* Fork the project, update the model and create a pull request
* Create an issue on github and I'll update the model

