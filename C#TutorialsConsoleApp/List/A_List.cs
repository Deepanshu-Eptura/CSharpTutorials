using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_TutorialsConsoleApp.AccessModifier;

namespace C_TutorialsConsoleApp.List
{
    public class Customr
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
    internal class A_List

    {
        public static void Main()
        {
            
                Customr customer1 = new Customr()
                {
                    ID = 101,
                    Name = "Sam",
                    Salary = 5000
                };
                Customr customer2 = new Customr()

                {
                    ID = 110,
                    Name = "Ram",
                    Salary = 6500
                };
                Customr customer3 = new Customr()
                {
                    ID = 119,
                    Name = "Kavi",
                    Salary = 3500
                };
            List<Customr> customers = new List<Customr>(2);
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);
            foreach (Customr C in customers)
            {
                
            Console.WriteLine("ID = {0}, Name = {1), Salary = {2}", C.ID, C.Name, C.Salary);

            }

        } 
    }
    }
