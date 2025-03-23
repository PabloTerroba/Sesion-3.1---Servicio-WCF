﻿using System.ServiceModel;
using System;
using MathService;


namespace MathServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(MathService.Math)))
            {
                host.Open();

                Console.WriteLine("Servicio ejecutándose. Pulsa <enter- para terminar");
                Console.ReadLine();

                host.Close();
            }
        }
    }
}
