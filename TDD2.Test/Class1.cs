using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using TDD2;

namespace TDD2.Test
{
    public class Class1
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
            var p = new Person;
            p.birthDay = new DateTime(1990, 01, 01);
            var answer = p.birthDay - DateTime.Today;
            Assert.Equal(answer, 25);
        }
    }
}
