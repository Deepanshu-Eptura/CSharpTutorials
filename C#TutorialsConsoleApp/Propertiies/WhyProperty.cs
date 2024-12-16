using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialsConsoleApp.Propertiies
{
    public class Student
    {
        private int _id;
        private string _Name;
        private int _passMark = 35;
        public int GetPassMark()
        {
            return this._passMark;
        }
        public void SetName(string Name)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new Exception("Name cannot be null or empty");
            }
            this._Name = Name;
        }
        public string GetName()
        {
            return string.IsNullOrEmpty(this._Name) ? "No Name" : this._Name;
        }
        public void SetId(int Id)
        {
            if (Id <= 0)
            {
                throw new Exception("Student Id cannot be negative");
            }
            this._id = Id;
        }
        public int GetId()
        {
            return this._id;
        }
    }
    internal class WhyProperty
    {
        public static void Main()
        {
            Student C1 = new Student();
            C1.SetId(101);
            C1.SetName("Mark");
            Console.WriteLine("Student Id = {0}", C1.GetId());
            Console.WriteLine("Student Name = {0}", C1.GetName());
            Console.WriteLine("PassMark = {0}", C1.GetPassMark());
        }
    }
}
