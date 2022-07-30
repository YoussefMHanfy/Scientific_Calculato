using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scientific_Calculato
{
    class circle:Shap
    {
        public circle(double R) : base(R)
        {

        }
        public override double action()
        {
            double area = r * r * pi;
            return area;
        }
    }
}
