using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{

    [Serializable]
    public class MyDivideException : Exception
    {
        public MyDivideException() { }
        public MyDivideException(string message) : base(message) { }
        public MyDivideException(string message, Exception inner) : base(message, inner) { }
        protected MyDivideException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    public class MyCalc
    {
        public static double Divide(double a, double b)
        {
           /* if (b == 0)
                throw new MyDivideException("Деление на 0");*/

            return a / b;
        }

        public static double Sum(double a, double b)
        {
            return a + b +1;
        }

    }
}
