using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    class Weather
    {
    }

    public class Coord
    {
        public double lon { get; set; }
        public double lat { get; set; }
    }

    public class City
    {
        public string id { get; set; }
        public string name { get; set; }
        public Coord coord { get; set; }
        public string country { get; set; }
        public int population { get; set; }
    }

    public class Temp
    {
        public string day { get; set; }
        public string min { get; set; }
        public string max { get; set; }
        public string night { get; set; }
        public string eve { get; set; }
        public string morn { get; set; }
    }

    public class Weathers
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }

    public class List
    {
        public int dt { get; set; }
        public Temp temp { get; set; }
        public double pressure { get; set; }
        public int humidity { get; set; }
        public List<Weathers> weather1 { get; set; }
        public double speed { get; set; }
        public int deg { get; set; }
        public int clouds { get; set; }
    }

    public class RootObject
    {
        public string cod { get; set; }
        public double message { get; set; }
        public City city { get; set; }
        public int cnt { get; set; }
        public List<List> list { get; set; }
    }

    public class Day
    {
        public string [] morn = new string[3];
        public string [] eve= new string[3];
        public string [] night = new string[3];
    }
}
