using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> cities = new MyDictionary<string, string>();

            cities.Add("06", "Ankara");
            cities.Add("35", "Izmir");
            cities.Add("34", "Istanbul");
            cities.Add("07", "Antalya");
            cities.Add("33", "Mersin");

            cities.GetAll();
        }
    }
}