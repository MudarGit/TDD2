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
       public string NameTest()
        {
            var p = new Person();
            var answer = p.Name("Nick Mudar");
            Assert.Equal("Nick Mudar", answer);       
        }

    }
}
