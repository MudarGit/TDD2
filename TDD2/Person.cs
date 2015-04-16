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
            var Age = this.getAge();
            var vote = "no";
            if (Age >= 18)
            {
               vote = "yes";
            }
            return vote;
        }

        public string getNameFL()
        {
            var nameFL = FName + LName;

            return nameFL;
        }

        public string getNameLF()
        {
            throw new NotImplementedException();
        }
    }
}