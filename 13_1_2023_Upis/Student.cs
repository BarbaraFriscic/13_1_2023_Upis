using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_1_2023_Upis
{
    internal class Student
    {
        public bool Ponavljac { get; set; }
        public string Ime { get; set; }
        private int brECTS;

        public int BrECTS
        {
            get { return brECTS; }
            set 
            {
                if (value >= 1 && value <= 75)
                    brECTS = value;
                else
                    brECTS = 75;
            }
        }
        public double Skolarina()
        {
            if (Ponavljac == true)
                return (113.75 * brECTS) / 2;
            else
                return 113.75 * brECTS;
        }
    }
}
