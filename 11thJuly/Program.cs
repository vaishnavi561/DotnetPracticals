using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Transactions;

class Program
{
    static void Main()
    {
        List<Employee> employees =new List<Employee>();
        List<manager> managers =new List<manager>();


        while (true)
        {
            Console.WriteLine("welcome to emp System ");
            Console.WriteLine("1. addd employee");
            Console.WriteLine("2. add managers ");
            Console.WriteLine("3. view employee");
            Console.WriteLine("4. view manager");

            Console.WriteLine("enter choice 1-4");



            try
            {
                int choice=Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                          Console.Write("Enter id:");
                          int id=Convert.ToInt32(Console.ReadLine());
                          bool exists=false;
                          foreach(Employee emp in employees)
                          {
                            if (emp.Id == id)
                            {
                                exists=true;
                                break;

                            }
                            if (exists)
                            {
                                Console.WriteLine("employee alredy exists");
                                break;
                            }
                            Console.Write("enter Name: ");
                            string name=Console.ReadLine();
                            Console.Write("Enter Salary");
                            double Salary=Convert.ToDouble(Console.ReadLine());
                            Employee employee=new Employee(id,name,salary);

                            employees.Add(employee);
                            Console.WriteLine("employee added ");
                            break;

                        
                          } 
                          case 2:
                              Console.Write("enter manaer ID: ");
                            int mid=Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter name");
                            double Salary=Convert.ToDouble(Console.ReadLine());
                            Employee employee=new Employee(id,name,salary);

                            employees.Add(employee);
                            Console.WriteLine("employee added ");
                            break;

                        
                          } 
                            

         



                         case 3:
                            Console.WriteLine("emp id");
                            int searchId=Convert.ToInt32(Console.ReadLine());
                            bool found=false








                          case 4:
                             return;
                          default:
                            Console.WriteLine("Invalid Choice");
                            break;


                       
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("please enter number only");
            }
            catch( Exception e)
            {
                Console.WriteLine(e.message);
            }
            }
        }
    }
}