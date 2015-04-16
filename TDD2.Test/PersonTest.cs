using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using TDD2;

namespace TDD2.Test
{
    public class PersonTest
    {
        [Fact]
       public void FirstNameTest()
        {
            var pf = new Person();
            pf.FName = "Nick";
            var answer = pf.FName;
            Assert.Equal("Nick", answer);       
        }
        [Fact]
        public void LastNameTest()
        {
            var pl = new Person();
            pl.LName = "Mudar";
            var answer = pl.LName;
            Assert.Equal("Mudar", answer);
        }

        [Fact]
        public void BirthdayTest()
        {
            var p = new Person();
            p.SetBirthDay("06/08/1955");
            var answer = p.birthDay;
            var indate = new DateTime(1955, 06, 08);
            Assert.Equal(answer, indate);
        }
        [Fact]
        public void SSTest()
        {
            var p = new Person();
            p.SS = "999-86-3258";
            var answer = p.SS;
            Assert.Equal(p.SS, answer);
        }

        [Fact]
        public void AgeTest()
        {
            var p = new Person();
            p.SetBirthDay("01/01/1990");
            Assert.Equal(p.getAge(), 25);
        }
        [Fact]
        public void VoteTest()
        {
            var p = new Person();
            p.SetBirthDay("01/01/1990");
            Assert.Equal(p.Vote(), "yes");
        }
        [Fact]
        public void NameChangeTest()
        {
            var p = new Person();
            p.FName = "Mark";
            p.LName = "Jensen";
            p.FName = "Nick";
            Assert.Equal(p.FName, "Nick");
        }

        [Fact]
        public void TestGetNameFL()
        {
            var p = new Person();
            p.FName = "Mark";
            p.LName = "Jensen";
            Assert.Equal(p.getNameFL(), "Mark Jensen");
        }
        [Fact]
        public void TestGetNameLF()
        {
            var p = new Person();
            p.FName = "Mark";
            p.LName = "Jensen";
            Assert.Equal(p.getNameLF(), "Jensen, Mark");
        }

        // create a list of people in alpha order
        [Fact]
        public void TestPersonList()
        {
            var pList = new PersonList();

            var p = new Person();
            var c = new Person();
            c.FName = "Nick";
            c.LName = "Mudar";
            p.FName = "Mark";
            p.LName="Jensen";
            p.SetBirthDay("01/01/1990");
            c.SetBirthDay("01/01/1890");
            pList.AddPerson(c);
            pList.AddPerson(p);
            Assert.Equal(pList.Count, 2);
        }
        
        // creating and checking a list of people in alpha order
        [Fact]
        public void TestPersonList2()
        {
            var pList = new PersonList();

            var p = new Person();
            var c = new Person();
            c.FName = "Nick";
            c.LName = "Mudar";
            p.FName = "Mark";
            p.LName = "Jensen";
            p.SetBirthDay("01/01/1990");
            c.SetBirthDay("01/01/1890");
            pList.AddPerson(c);
            pList.AddPerson(p);
            Assert.Equal(pList.GetByIndex(0), p);
        }

        // creating and checking a list of people in alpha order
        [Fact]
        public void TestPersonList3()
        {
            var pList = new PersonList();

            var p = new Person();
            var c = new Person();
            c.FName = "Nick";
            c.LName = "Mudar";
            p.FName = "Mark";
            p.LName = "Jensen";
            p.SetBirthDay("01/01/1990");
            c.SetBirthDay("01/01/1890");
            pList.AddPerson(c);
            pList.AddPerson(p);
            Assert.Equal(pList.GetByIndex(1), c);
        }

        // creating and checking a list of people in alpha order
        [Fact]
        public void TestPersonList5()
        {
            var pList = new PersonList();

            var p = new Person();
            var c = new Person();
            c.FName = "Nick";
            c.LName = "Mudar";
            p.FName = "Mark";
            p.LName = "Jensen";
            p.SetBirthDay("01/01/1990");
            c.SetBirthDay("01/01/1890");
            
            Assert.Equal(c.CompareTo(p), 1);
        }

        // creating and checking a list of people in alpha order
        [Fact]
        public void TestPersonList6()
        {
            var pList = new PersonList();

            var p = new Person();
            var c = new Person();
            c.FName = "Nick";
            c.LName = "Mudar";
            p.FName = "Mark";
            p.LName = "Jensen";
            p.SetBirthDay("01/01/1990");
            c.SetBirthDay("01/01/1890");

            Assert.Equal(p.CompareTo(c), -1);
        }

        // creating and checking a list of people in alpha order
        [Fact]
        public void TestPersonList7()
        {
            var pList = new PersonList();

            var p = new Person();
            var c = new Person();
            c.FName = "Nick";
            c.LName = "Mudar";
            p.FName = "Nick";
            p.LName = "Mudar";
            p.SetBirthDay("01/01/1890");
            c.SetBirthDay("01/01/1890");

            Assert.Equal(p.CompareTo(c), 0);
        }

        // creating and checking a list of people in alpha order
        [Fact]
        public void TestPersonList8()
        {
            var pList = new PersonList();

            var p = new Person();
            var c = new Person();
            c.FName = "Nick";
            c.LName = "Mudar";
            p.FName = "Nick";
            p.LName = "Mudar";
            p.SetBirthDay("01/01/1990");
            c.SetBirthDay("01/01/1890");

            Assert.Equal(p.CompareTo(c), 1);
        }
        [Fact]
        public void SadBirthdayTest()
        {
            var p = new Person();
            var ok =  p.SetBirthDay("13/13/1955");
            Assert.Equal(ok, false);
        }
    
    }
}
