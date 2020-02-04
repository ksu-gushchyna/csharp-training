using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public class GetSetClass
    {
        private int a;
        private int b;

        public int A {
            get { return a; }
            set { if (value < 0)
                throw new ArgumentOutOfRangeException();
                else a = value; 
            } 
        }
        public int B
        {
            get { return b; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();
                else b = value;
            }
        }

        public GetSetClass(int width, int height) {
            A = width;
            B = height;
        }

        public GetSetClass() { }
       

        public double GetSquare() { 
            return A*B;
        }

        public double GetSquare(int a, int b)
        {
            return a * b;
        }
    }
}
