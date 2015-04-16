using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD2
{
    public class Person
    {
        public String FName
        { get; set; }

        public String LName
        { get; set; }

        public DateTime birthDay
        { get; set; }


        public String SS
        { get; set; }


        public int getAge()
        {
           var CDate = System.DateTime.Today;
           var Age = CDate.Year - birthDay.Year;

           return Age;           
        }
        public string Vote()
        {
            var p = new Person();
            var Age = p.getAge();
            string vote = "no";
            if (Age >= 18)
            {
               vote = "yes";
            }
            return vote;
        }
    }
}