using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scientific_Calculato
{
    class Sphare : Shap
    {
        public Sphare(double r) : base(r)
        {

        }
        public override double action()
        {
            double area = r * r * pi * 4;
            return area;

        }
    }
}
