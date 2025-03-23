using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MathService
{
    public class Math:IMath
    {
        public bool Prime(int value)
        {
            if (value < 2) return false; // Los números menores a 2 no son primos

            int divisores = 0;
            for (int i = 1; i <= value; i++) // Recorre desde 1 hasta value
            {
                if (value % i == 0)
                {
                    divisores++;
                }
            }
            if (divisores == 2) return true;
            else return false;

            
        }
        public Tuple SumTuple(Tuple tuple)
        {
            double sum=0;
            foreach (double t in tuple.Data)
            {
                sum = sum + t;
            }
            Tuple _tuple = new Tuple();
            _tuple.Name = "Suma";
            _tuple.Data = new double[] { sum };
            return _tuple ;
        }


    }
}


