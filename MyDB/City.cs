using System;
using System.Collections.Generic;

namespace MyDB
{

   public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public static class CityList
    {
        public static List<string> List { get; set; } = new List<string>() {
        "Jerusalem", "Tel Aviv"

        };
    }
}
