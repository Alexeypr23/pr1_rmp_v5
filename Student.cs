using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract11_Соколов_ПР_23
{
    public class Student
    {
        public string name;
        public int rost;
        public double ves;

        public void SetEat(double vs)
        {
            ves += vs;
        }

        public double GetEat(double vs)
        {
            double tempVes = vs;
            return tempVes;
        }
    }

    
}

