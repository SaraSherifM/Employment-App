using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplymentAppUsingClass
{
    class Employee
    {
        int id;
        string name;
        int age;
        int salary;
        #region Setters&Getters
        public void setId(int i)
        {
            id = i;

        }
        public void setAge(int i)
        {
            age = i;
        }
        public void setSalary(int i)
        {
            salary = i;
        }
        public void setName(string i)
        {
            name = i;
        }
        public int getId()
        {
            return id ;
        }
        public int getSalary()
        {
            return salary;
        }
        public int getAge()
        {
            return age;
        }
        public string getName()
        {
            return name;
        }
        #endregion

        #region Properties
        public int Id
        {
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        public int Age
        {
            set
            {
                age = value;
            }
            get
            {
                return age;
            }
        }
        public int Salary
        {
            set
            {
                salary = value;
            }
            get
            {
                return salary;
            }
        }
        #endregion

        #region Constructors
        public Employee()
        {
            id = 1;
            age = 15;
            salary = 8;
            name = "sara";
        }
        public Employee(int i=1,int d=5,int s=6,string n="sara")
        {

        }
        #endregion
        public void Print()
        {
            Console.WriteLine($"id: {id}");
            Console.WriteLine($"name: {name}");
            Console.WriteLine($"age: {age} years");
            Console.WriteLine($"salary: {salary}");


        }
    }
}
