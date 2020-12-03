using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("sonali",20000,1);
            Employee e2 = new Employee("rajesh", 2000);
            Employee e3 = new Employee("pallavi");
            Employee e4 = new Employee();

            Console.WriteLine(e1.Emp_No);
            Console.WriteLine(e1.Emp_Name);
            Console.WriteLine(e1.empSalary);
            Console.WriteLine(e1.dept_no);
            e1.netSalary();
            Console.WriteLine(e1.Emp_No);
            Console.WriteLine(e2.Emp_No);
            Console.WriteLine(e3.Emp_No);
            Console.WriteLine(e4.Emp_No);
            Console.WriteLine(e3.Emp_No);
            Console.WriteLine(e2.Emp_No);
            Console.WriteLine(e1.Emp_No);
        }
    }
    class Employee
    {
        public Employee(){

            count++;
            Emp_No = count;
            Emp_Name = "Rupali";
            empSalary = 20000;
            dept_no = 1;

        }
        public Employee(string Emp_Name,int empSalary,int dept_no)
        {
            count++;
            Emp_No = count;
            this.Emp_Name = Emp_Name;
            this.empSalary = empSalary;
            this.dept_no = dept_no;

        }
        public Employee(string Emp_Name, int empSalary)
        {
            count++;
            Emp_No = count;
            this.Emp_Name = Emp_Name;
            this.empSalary = empSalary;
           

        }

        public Employee(string Emp_Name)
        {
            count++;
            Emp_No = count;
            this.Emp_Name = Emp_Name;
          
        }
        private int emp_No;
        public int Emp_No {
            set;
            get;
        }
        public static int count = 0;
        private string empName;
        public string Emp_Name {
            set {
                if (value == "") {
                    Console.WriteLine("Name cannot Be blank");
                }
                else
                {
                    empName = value;
                }
            }
            get {
                return empName;
            }
        }
        
        private int salary;
        public int empSalary {
            set {
                if (value > 10000 && value < 100000)
                {
                    salary = value;
                }
                else {
                    Console.WriteLine("Invalid Salary");
                }
            }
            get {
                return salary;
            }
        }
        private int deptNo;
        public int dept_no {
            set {
                if (value > 0)
                {
                    deptNo = value;
                }
                else {
                    Console.WriteLine("Invalid Department Number");
                }
            }
            get {
                return deptNo;
            }
        }
       
        public void netSalary() {
            Console.WriteLine("Net Salary Is"+(empSalary-((10/100)*empSalary)));
        }
    }
}
