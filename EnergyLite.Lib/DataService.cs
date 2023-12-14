using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLite.Lib
{
    public class DataService
    {
        public double Neft_Volume(double n_f, double N, double h, double m, double S_n, double p_h, double b_n)
        {
            double F = n_f * N;
            double Q_n = F * h * m * S_n * p_h * Math.Pow(10, -3) / b_n;
            return Math.Round(Q_n,3);
        }

        public double Neft_Debit(double k, double h, double m_n, double b_n, double R, double r_c, double dep)
        {
            double K_pr = ((2 * Math.PI * k* Math.Pow(10, -12) * h) / (m_n * Math.Pow(10, -3) * Math.Log(R / r_c))) * Math.Pow(10, 6) * 86400;
            double q_g = K_pr * dep;
            return Math.Round(q_g, 3);
        }
    }
}
