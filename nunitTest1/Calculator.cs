using System;

namespace nunitTest1
{
    public class Calculator
    {
        public int Addition(int first, int second)
        {
            return first + second;

        }

        public int Subtraction(int first, int second)
        {
            if (first < second)
                throw new ArgumentException($"{first} is less than {second}");
            
            return first - second;

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
