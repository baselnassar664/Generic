using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNet6.Genric
{
    internal class Emp
    {

        public int Id { get; set; }
        public string Name{ get; set; }

        public override bool Equals(object? obj)
        {
            Emp emp = obj as Emp;
            return this.Id==emp.Id && this.Name==emp.Name;
        }
    }
}
