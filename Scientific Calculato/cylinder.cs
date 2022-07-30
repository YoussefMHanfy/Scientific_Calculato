using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scientific_Calculato
{
    class cylinder : Shap
    {
        double high;
        public cylinder(double r, double h) : base(r)
        {
            high = h;
        }

        public override  double action()
        {
            double area = (r * r * pi * 2) + (2 * pi * r * high);
            return area;


        }
    }

}
