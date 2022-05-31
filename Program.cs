using System;

namespace _31_05_2022hm.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employeelerin sayini daxil edin:");
            string countStr = Console.ReadLine();
            int count = Convert.ToInt32(countStr);

            Employee[] employees = new Employee[count];
            for (int i = 0; i < count; i++)
            {

                Console.WriteLine($"{i + 1}. employeenin name:");
                var name = Console.ReadLine();
                employees[i] = new Employee(name);

                Console.WriteLine($"{i + 1}. employeenin surname:");
                employees[i].SurName = Console.ReadLine();

                Console.WriteLine($"{i + 1}. employeenin age:");
                string ageStr = Console.ReadLine();
                employees[i].Age = Convert.ToByte(ageStr);

                //Console.WriteLine($"{i + 1}. employeenin position:");
                //employees[i].Position = Console.ReadLine();

                //Console.WriteLine($"{i + 1}. employeenin salary:");
                //string salaryStr = Console.ReadLine();
                //employees[i].Salary = Convert.ToByte(salaryStr);


            }

            Employee[] employess = new Employee[4];

            employees[0] = new Employee("Kamala")
           
               { 
                   
                    SurName = "Jamalova",
                    Age = 21,
                    Salary = 3200,
                    Position = "Software development",

                };

            employees[1] = new Employee("Nargiz")
            {
               
                SurName = "Amirova",
                Age = 22,
                Salary = 2400,
                Position = "Qrafik Dizayner",

            };

            employees[2] = new Employee("Naile")
            {
               
                SurName = "Bunyatova",
                Age = 23,
                Salary = 2350,
                Position = "UX/UI Dizayner",
            };
            employees[3] = new Employee("Abbas")
            {
               
                SurName = "Abbasov",
                Age = 27,
                Salary = 3800,
                Position = "Sistem Administrator",
            };
        


            Console.WriteLine("MinSalary deyerini daxil edin:");
            string minSalaryStr = Console.ReadLine();
            double minSalary = Convert.ToDouble(minSalaryStr);

            Console.WriteLine("MaxSalary deyerini daxil edin:");
            string maxSalaryStr = Console.ReadLine();
            double maxSalary = Convert.ToDouble(maxSalaryStr);

            foreach (var employee in employees)
            {
                if (employee.Salary <= minSalary && employee.Salary >= maxSalary)
                    employee.ShowInfor();
            }




            


        }
    }
}
