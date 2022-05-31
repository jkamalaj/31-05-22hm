using System;
using System.Collections.Generic;
using System.Text;

namespace _31_05_2022hm.cs
{
    internal class Employee:Human
    {
        public Employee (string name):base (name)
        {

        }
        public double Salary;
        public string Position;
        

        public void ShowInfor()
        {
            Console.WriteLine($"Name:{this.Name} - Surname:{this.SurName} - Age:{this.Age} - Positon:{this.Position} - Salary:{this.Salary}");
        }

    }
}
