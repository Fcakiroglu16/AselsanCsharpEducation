using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestExample
{
    public class Calculate
    {
        public int Divide(int a, int b)
        {
            if (a < b)
            {
                throw new Exception("a, b'den büyük olmalıdır");
            }

            if (b == 0)
            {
                throw new Exception("b değeri 0 olamaz");
            }

            return a / b;
        }
    }
}