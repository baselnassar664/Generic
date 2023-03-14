using DemoNet6.Genric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNet6.Helper
{
    internal class Poi
    {
       

        public int X { get; set; }
        public int Y{ get; set; }

       
        public override string ToString()
        {
            return $"{X},{Y}";
        }

        public override bool Equals(object? obj)
        {
            Poi poi = obj as Poi;
            return this.X == poi.X && this.Y == poi.Y;
        }
    }
}
