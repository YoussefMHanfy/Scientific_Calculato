using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scientific_Calculato
{
    abstract class Shap
    {
        protected const double pi = Math.PI;
        protected double r;
        public Shap(double r1)
        {

            r = r1;
        }
        
        public abstract Double action();

    }
}
