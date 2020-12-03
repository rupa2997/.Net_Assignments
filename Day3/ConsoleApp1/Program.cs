using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager m1 = new Manager();
            Manager m2 = new Manager("rupali",2,300000,"CEO");
            Console.WriteLine(m2.empNo);
            Console.WriteLine(m2.empName);
            Console.WriteLine(m2.deptNo);
            Console.WriteLine(m2.Basic);
            Console.WriteLine(m2.CalcNetSalary());
            Console.WriteLine("==============================");
            Console.WriteLine("GM");
            GeneralManager g1=new GeneralManager("sonali",3,400000,"CMO","dddd");
            Console.WriteLine(g1.empName);
            Console.WriteLine(g1.deptNo);
            Console.WriteLine(g1.Basic);
            Console.WriteLine(g1.CalcNetSalary());
            Console.WriteLine("===ceo===============");
            CEO c1=new CEO("Pallavi",6,80000);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
    public abstract class employee {
        public employee() {
            count++;
            empNo = count;
            empName = "rupali";
            deptNo = 1;
            Basic = 20000;

        }
                public employee(string empName, short deptNo, decimal Basic) {
            Console.WriteLine("employee 3 para cons");
            count++;
            empNo = count;
            this.empName = empName;
            this.deptNo = deptNo;
            this.Basic = Basic;

        }

        public static int count = 0;
        public int empNo;
        public int emp_No {
            set; get;
        }
        public string empName;
        public string emp_Name{
            set {
                if (value == "")
                    Console.WriteLine("invalid name");
                else
                    empName = value;
            }
            get {
                return empName;
            }

        }

        public short deptNo;
        public short dept_No {
            set {
                if (value > 0)
                    deptNo = value;
                else
                    Console.WriteLine("invalid dept number");
            }
            get {
                return deptNo;
            }
        }

        public  decimal Basic;
        public abstract decimal BasicS {
            set;get;
        }

        public int calnetsalary;
        public abstract decimal CalcNetSalary();

    }
    public class Manager : employee {

        public  Manager()
        {
            Console.WriteLine("manager 0 para");
            count++;
            empNo = count;
            empName = "rupali";
            deptNo = 1;
            Basic = 20000;
            designation="CMO";
        }
        public Manager(string empName,short deptNo, decimal Basic,string  designation):base(empName, deptNo, Basic)
        {
            Console.WriteLine("Manager 3 para");
            //count++;
            //empNo = count;
            //this.empName = empName;
            //this.deptNo = deptNo;
            //this.Basic = Basic;
            this.designation=designation;
        }
        public string designation;
        public string Designation {

            set {
                if (value == "")
                {
                    Console.WriteLine("invalid designation");
                }
                else {
                    designation = value;
                }
            }
            get
            {
                return designation;
            }
        }

        public override decimal BasicS
        {
            set {
                if (value > 50000)
                    Basic = value;
            }
            get {

                return Basic;
            }
        }
        public  override decimal CalcNetSalary() {
            
            
            return (Basic-((15*Basic)/100));
        }
    }
    public class GeneralManager : Manager {
        public GeneralManager()
        {
            Console.WriteLine("General 0 para cons");
        }
        public GeneralManager( string empName, short deptNo, decimal Basic,string  designation,string perks):base(empName, deptNo, Basic, designation)
        {
            Console.WriteLine("general 4 para cons");
            this.perks = perks;
        }
        public string perks;
        public string Perks
        {
            set {
                perks = value;
            }
            get
            {
                return perks;
            }
        }
         public  override decimal CalcNetSalary() {
            return  (Basic-((15*Basic)/100));
        }
    }
    public class  CEO : employee
    {
        public CEO(string empName, short deptNo, decimal Basic):base(empName, deptNo, Basic)
        {
            Console.WriteLine("ceo 4 para cons");
            
        }
        public override decimal BasicS
        {
            set
            {
                if (value > 50000)
                    Basic = value;
            }
            get
            {

                return Basic;
            }
        }

        public sealed override decimal CalcNetSalary()
        {
            return (Basic-((30*Basic)/100));
        }

    }
}
