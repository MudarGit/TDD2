using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD2
{
    public class Person : IComparable<Person>
    {
        public String FName
        { get; set; }

        public String LName
        { get; set; }

        public DateTime birthDay
        { get;  private set; }

        public bool SetBirthDay(String bDate)
        {
            var theDay = new DateTime();
            if (DateTime.TryParse(bDate, out theDay))
            {
                this.birthDay = theDay;
                return true;
            }
            else
                return false;
        }


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
            var nameFL = FName + ' ' + LName;

            return nameFL;
        }

        public string getNameLF()
        {
            var nameLF = LName + ", " + FName;

            return nameLF;
        }

        public int CompareTo(Person p)
        {
            var namedate = p.birthDay.Year.ToString();
            var pkey = p.LName + p.FName + namedate; 

            namedate = this.birthDay.Year.ToString();
            var tkey = this.LName + this.FName + namedate;

            return tkey.CompareTo(pkey);
            
        }
    }
}