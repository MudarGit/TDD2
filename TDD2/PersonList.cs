using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace TDD2
{
    public class PersonList : SortedList
    {
        public void AddPerson(Person p)
        {
            var namedate = p.birthDay.Year.ToString();
            var key = p.LName + namedate;

            this.Add(key, p);
        }

    }
}
