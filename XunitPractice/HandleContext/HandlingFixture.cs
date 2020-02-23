using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XunitPractice.HandleContext
{
    public class HandlingFixture : IDisposable
    {
        public HandlingFixture()
        {
            //... Constructor to begin each test
            Console.WriteLine("Before the test");
        }

        public void Dispose()
        {
            //...Method cleanup the test
            Console.WriteLine("After the test");
        }
    }
}
