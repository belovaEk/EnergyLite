using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using EnergyLite.Lib;

namespace EnergyLite
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void textBoxQuestion_Enter(object sender, EventArgs e)
        {
            (sender as TextBox).SelectionStart = 0;
        }


        private void buttonGas_Click(object sender, EventArgs e)
        {
            pictureBoxGasDebit.Visible = true;
            pictureBoxGasReserves.Visible = true;

            pictureBoxOilReserves.Visible = false;
            pictureBoxOilDebit.Visible = false;

            groupBoxGas_Debit.Visible = true;
            groupBoxGas_Volume.Visible = true;

            groupBoxNeft_Debit.Visible = false;
            groupBoxNeft_Volume.Visible = false;
        }

        private void buttonNeft_Click(object sender, EventArgs e)
        {
            groupBoxGas_Debit.Visible = false;
            groupBoxGas_Volume.Visible = false;
            
            pictureBoxGasReserves.Visible = false;
            pictureBoxGasDebit.Visible = false;


            pictureBoxOilReserves.Visible = true;
            pictureBoxOilDebit.Visible = true;

            groupBoxNeft_Debit.Visible = true;
            groupBoxNeft_Volume.Visible = true;
        }

        private void checkBox_Debit_CheckedChanged(object sender, EventArgs e)
        {
            
            
            if (checkBox_Debit.Checked == true)
            {
                groupBoxNeft_Debit.Enabled = true;
                groupBoxGas_Debit.Enabled = true;
                pictureBoxGasDebit.Enabled = true;
                
            }

            if (checkBox_Debit.Checked == false)
            {
                groupBoxNeft_Debit.Enabled = false;
                groupBoxGas_Debit.Enabled = false;
                pictureBoxGasDebit.Enabled = false;

            }
        }

        private void checkBox_Volume_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Volume.Checked == true)
            {
                groupBoxNeft_Volume.Enabled = true;
                groupBoxGas_Volume.Enabled = true;
                
            }

            if (checkBox_Volume.Checked == false)
            {
                groupBoxNeft_Volume.Enabled = false;
                groupBoxGas_Volume.Enabled = false;
            }
        }

        private void buttonDo_Click(object sender, EventArgs e)
        {
            /*
            double n_f = Convert.ToDouble(textBox_n_F_ChisloLinii.Text);
            double N = Convert.ToDouble(textBox_N_CenaDel.Text);
            double h_Volume = Convert.ToDouble(textBox_h_SrednHeftTolshPlasta_Neft.Text);
            double m = Convert.ToDouble(textBox_m_SrKoffOtkrPoristHeftPorod.Text);
            double S_n = Convert.ToDouble(textBox_S_n_SrHeftPlasta.Text);
            double p_h = Convert.ToDouble(textBox_p_n_PlotnostHeftiInPlasYslovia.Text);
            double b_n_Volume = Convert.ToDouble(textBox_b_n_ObKoffNeftPriPlastYsl_Volume.Text);
            double Q_n = ds.Neft_Volume(n_f, N, h_Volume, m, S_n, p_h, b_n_Volume);

            textBox_Res_Volume.Text = Convert.ToString(Q_n);
            textBox_Res_Volume.Enabled = true;
            */
           

            double k = Convert.ToDouble(textBox_k_kofPonicaemosti_Neft.Text);
            double h_Debit = Convert.ToDouble(textBox_h_EffectivNeftTolshinaPlasta.Text);
            double m_n = Convert.ToDouble(textBox_μ_n_VaskostNefti.Text);
            double b_n_Debit = Convert.ToDouble(textBox_b_nObKoffNefti_Debit.Text);
            double R = Convert.ToDouble(textBox_R_RadiusZonDrenirovania_Neft.Text);
            double r_c = Convert.ToDouble(textBox_r_c_RadiusSkvagina_Neft.Text);
            double dep = Convert.ToDouble(textBoxEbanayaDepressia_Neft.Text);
            double q_g = ds.Neft_Debit(k, h_Debit, m_n, b_n_Debit, R, r_c, dep);

            textBox_Res_Debit.Text = Convert.ToString(q_g);
            textBox_Res_Debit.Enabled = true;
        }

      
    }
}
