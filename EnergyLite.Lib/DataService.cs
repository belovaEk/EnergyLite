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

        public double CalcGasDebit(double k, double h, double m_gas, double T_plast, double z, double R_dren, double r_skvajina, double P_plast, double P_depressia)
        {
            // Найдем коэффициент продуктивности
            double K_prod = (Math.PI * k * Math.Pow(10, -12) * h * 293) / (z * m_gas * Math.Pow(10, -3) * (273 + T_plast) * 0.1 * Math.Log(R_dren / r_skvajina)) * Math.Pow(10, 6) * 86400 / 1000;

            //double K_prod = (3.14 * 0.5 * Math.Pow(10, -12) * 5 * 293) / (0.8 * 0.02 * Math.Pow(10, -3) * (273 + 33) * 0.1 * Math.Log(500 / 0.1)) * Math.Pow(10, 6) * 86400 / 1000;

            // Забойное давление 
            double P_zaboi = P_plast - P_depressia;

            // Дельта P^2
            double delta_P_square = Math.Pow(P_plast, 2) - Math.Pow(P_zaboi, 2);

            // Дебит газа
            double debit_Gas = K_prod * delta_P_square;

            return debit_Gas;
        }

        public double Gas_Volume(double F, double h, double m, double S_g, double P_plast, double T_plast, double z)
        {
            double p_0 = 0.1 * Math.Pow(10, 6);
            double T_ct = 293;
            double V_g = F * h * m * S_g * (P_plast * T_ct) / (p_0 * T_plast * z);

            return Math.Round(V_g, 3);
        }
    }
}
