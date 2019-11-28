using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplymentAppUsingClass
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] choice = { "New employee", "Display All", "Display by id", "Delete All", "Delete by id", "Delete by name", "Exit" };
            bool found = false;
            int cursor = 0;
            bool flag = true;
            Employee[] emp = new Employee[10];
            int index; //index from user
            int n;
            string name;


            do
            {
                Console.Clear();
                for (int i = 0; i < choice.Length; i++)
                {

                    if (i == cursor)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;

                    }

                    Console.SetCursorPosition(20, 10 + i * 2);
                    Console.WriteLine(choice[i]);

                }

                var pressed = Console.ReadKey().Key;
                switch (pressed)
                {
                    case ConsoleKey.UpArrow:
                        cursor--;
                        if (cursor < 0)
                        {
                            cursor = 6;
                        }
                        break;

                    case ConsoleKey.DownArrow:
                    case ConsoleKey.Tab:
                        cursor++;
                        if (cursor > 6)
                        {
                            cursor = 0;
                        }
                        break;

                    case ConsoleKey.Enter: //Our work goes here
                        Console.Clear();
                        switch (cursor)
                        {
                            case 0: //getting proper index from user
                                do
                                {
                                    Console.WriteLine("Enter index of Employee");
                                    index = int.Parse(Console.ReadLine());

                                } while (index < 0 || index > 9);

                                emp[index] = new Employee();

                                Console.Clear();

                                //Show 
                                Console.SetCursorPosition(10, 5);
                                Console.WriteLine("id:");

                                Console.SetCursorPosition(10, 10);
                                Console.WriteLine("age:");

                                Console.SetCursorPosition(30, 5);
                                Console.WriteLine("name:");

                                Console.SetCursorPosition(30, 10);
                                Console.WriteLine("salary:");

                                //Insert
                                Console.SetCursorPosition(13, 5);
                                emp[index].Id = int.Parse(Console.ReadLine());

                                Console.SetCursorPosition(15, 10);
                                emp[index].Age = int.Parse(Console.ReadLine());

                                Console.SetCursorPosition(35, 5);
                                emp[index].Name = (Console.ReadLine());
                                Console.SetCursorPosition(37, 10);
                                emp[index].Salary = int.Parse(Console.ReadLine());

                                Console.Clear();
                                Console.ReadLine();
                                break;

                            case 1://Display All
                                found = false;
                                for (int i = 0; i < emp.Length; i++)
                                {
                                    if (emp[i] != null)
                                    {
                                        Console.WriteLine($"Employee Id: {emp[i].Id}");
                                        Console.WriteLine($"name: {emp[i].Name}");
                                        Console.WriteLine($"Salary: {emp[i].Salary}");
                                        Console.WriteLine($"Employee age: {emp[i].Age} years");
                                        flag = true;
                                    }

                                }
                                if (flag == false)
                                {
                                    Console.WriteLine("There is no elements to Display");
                                }

                                Console.ReadLine();
                                break;

                            case 2://Display by Id
                                found = false;
                                Console.WriteLine("Enter Id of Employee");
                                n = int.Parse(Console.ReadLine());

                                for (int i = 0; i < emp.Length; i++)
                                {
                                    if (emp[i] != null && emp[i].Id == n)
                                    {
                                        Console.WriteLine($"name: {emp[i].Name}");
                                        Console.WriteLine($"Salary: {emp[i].Salary}");
                                        Console.WriteLine($"Employee age: {emp[i].Age} years");
                                        found = true;
                                    }
                                }
                                if (found == false)
                                {
                                    Console.WriteLine("Employee Not Found");
                                }


                                Console.ReadLine();
                                break;


                            case 3://Delete all
                                for (int i = 0; i < emp.Length; i++)
                                {
                                    emp[i] = null;
                                }

                                Console.ReadLine();
                                break;
                            case 4://Delete by Id
                                found = false;
                                Console.WriteLine("Enter Id of Employee you want to Delete");
                                n = int.Parse(Console.ReadLine());

                                for (int i = 0; i < emp.Length; i++)
                                {
                                    if (emp[i] != null && emp[i].Id == n)
                                    {
                                        emp[n] = null;
                                        Console.WriteLine("Employee is Deleted");
                                        found = true;

                                    }
                                }

                                if (found == false)
                                {
                                    Console.WriteLine("Employee Not Found!");
                                }

                                Console.ReadLine();
                                break;
                            case 5:
                                //Delete by name
                                found = false;
                                Console.WriteLine("Enter name of Employee you want to Delete");
                                name = (Console.ReadLine());

                                for (int i = 0; i < emp.Length; i++)
                                {
                                    if (emp[i] != null && emp[i].Name == name)
                                    {
                                        emp[i] = null;
                                        found = true;
                                    }
                                }
                                if (found == false)
                                {
                                    Console.WriteLine("Employee Not Found!");

                                }


                                break;
                            case 6://Exit
                                flag = false;
                                break;
                        }
                        break;
                    case ConsoleKey.Escape:
                        flag = false;
                        break;
                    case ConsoleKey.Home:
                        cursor = 0;
                        break;
                    case ConsoleKey.End:
                        cursor = 6;
                        break;
                }

            } while (flag);




        }
    }
}
