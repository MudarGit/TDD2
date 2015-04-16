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
            var time = new DateTime(1955, 06, 08);
            p.birthDay = time;
            var answer = p.birthDay;
            Assert.Equal(answer, time);
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
            p.birthDay = new DateTime(1990, 01, 01);
            Assert.Equal(p.getAge(), 25);
        }
        [Fact]
        public void VoteTest()
        {
            var p = new Person();
            p.birthDay = new DateTime(1990, 01, 01);
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

            var p = new Person;
            p.FName = "Mark";
            p.LName="Jensen";
            p.birthDay = new DateTime(1990, 01, 01);
            pList.Add(p);

            Assert.Equal(pList.Count, 1);
        }
    
    }
}
