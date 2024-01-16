using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class DomacaZadaca
    {

        //Napisati metodu koja za dva primljena decimalna broja
        //vraća cijeli dio zbroja primljenih brojeva
       
        public static int CijeliDioZbroja(float Prvi, float Drugi)
        {
            //return (int)(Prvi + Drugi);
            return CijeliDioZbroja((double)Prvi, (double)Drugi);
        }

        //Method overloading
        //Potpis metode: naziv + lista parametara

        public static int CijeliDioZbroja(double Prvi, double Drugi)
        { 
            return (int) (Prvi + Drugi);    
        }
    }
}

