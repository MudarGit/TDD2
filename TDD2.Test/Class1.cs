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
            p.birthDay = 06/18/1955;
            var answer = p.birthDate;
            Assert.Equal(answer, 06 / 18 / 1955);
        }
    }
}
