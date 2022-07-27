using System;

namespace hirerical_inheritance
{
    class Employee
    {
        public int EmpNo;

        public void Show()
        {
            Console.WriteLine("EmpNo="+EmpNo);
        }
    }

    class Student : Employee
    {
        public int Fees;

        public void MyMethod()
        {
            Console.WriteLine("Fees="+Fees);
        }
    }

    class Demo : Employee
    {
        public string EmpName;

        public void Add()
        {
            Console.WriteLine("EmpName="+EmpName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Demo d = new Demo();
            d.EmpNo = 12;
            d.EmpName = "sonu kuamr";
            Student s = new Student();
            s.Fees = 1000;
            d.Show();
            s.MyMethod();
            d.Add();
            Console.ReadLine();

            
        }
    }
}
