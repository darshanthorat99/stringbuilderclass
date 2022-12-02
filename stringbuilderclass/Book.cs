using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringbuilderclass
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public double Price { get; set; }

    }
    public class Course
    {
        public int Id;
        public string Name;
        public double Fee;

        public Course(int Id,string Name,double Fee)
        {
            this.Id = Id;
            this.Name = Name;
            this.Fee = Fee; 
         
        }
        public override string ToString()
        {
            return $"{Id}   {Name}   {Fee}";
        }

    }
}
