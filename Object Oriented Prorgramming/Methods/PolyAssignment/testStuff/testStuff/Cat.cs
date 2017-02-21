using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testStuff
{
    class Cat
    {
        int age;
        int livesRemaining;

        private Cat()
        {
            age = 0;
            livesRemaining = 9;
        }
        private void birthday(Cat cat)
        {
            cat.age++;
        }
        private int death(Cat cat)
        {
            return cat.livesRemaining;
        }
    }
}
