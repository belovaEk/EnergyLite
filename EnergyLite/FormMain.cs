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

        // Обрабатываем выбор в комбобоксе и делаем видимыми панели для нефти или газа соответственно
        private void comboBoxChange_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxChange.SelectedIndex == 0)
            {
                // Единицы измерения запасов для газа
                labelZapasiTonns.Visible = false;
                labelZapasiM3.Visible = true;

                groupBoxGas_Debit.Visible = true;
                groupBoxGas_Volume.Visible = true;

                groupBoxNeft_Debit.Visible = false;
                groupBoxNeft_Volume.Visible = false;
            }

            if (comboBoxChange.SelectedIndex == 1)
            {
                // Единицы измерения запасов
                labelZapasiTonns.Visible = true;
                labelZapasiM3.Visible = false;

                groupBoxGas_Debit.Visible = false;
                groupBoxGas_Volume.Visible = false;

                groupBoxNeft_Debit.Visible = true;
                groupBoxNeft_Volume.Visible = true;
            }
        }

        private void textBoxQuestion_Enter(object sender, EventArgs e)
        {
            (sender as TextBox).SelectionStart = 0;
        }

        // Смотрим, выбран ли дебит (любой)
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

        // Смотрим, выбран ли объем (любой)
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

        // Обрабатываем события по нажатию кнопки
        private void buttonDo_Click(object sender, EventArgs e)
        {
            // В комбобоксе выбрана нефть
            if (comboBoxChange.SelectedIndex == 1)
            {
                if (checkBox_Volume.Checked == true)
                {
                    try
                    {
                        //  Нефть - Объем
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

                        pictureBoxGasReserves.Visible = false;
                        pictureBoxGasDebit.Visible = false;

                        pictureBoxOilReserves.Visible = true;
                        pictureBoxOilDebit.Visible = true;
                    }
                    catch
                    {
                        MessageBox.Show("Введены некоректные данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


                if (checkBox_Debit.Checked == true)
                {
                    try
                    {
                        // Нефть - Дебит
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

                        pictureBoxGasReserves.Visible = false;
                        pictureBoxGasDebit.Visible = false;

                        pictureBoxOilReserves.Visible = true;
                        pictureBoxOilDebit.Visible = true;
                    }
                    catch
                    {
                        MessageBox.Show("Введены некоректные данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            // В комбобоксе выбран газ
            if (comboBoxChange.SelectedIndex == 0)
            { 
                if (checkBox_Volume.Checked == true)
                {
                    try
                    {
                        // Газ - Объем
                        double F = Convert.ToDouble(textBox_F_Gasonostnosti_Gas_Volume.Text);
                        double h_Gas_Volume = Convert.ToDouble(textBox_h_Gas_Volume.Text);
                        double m_Gas_Volume = Convert.ToDouble(textBox_m_Gas_Volume.Text);
                        double S_g = Convert.ToDouble(textBox_S_g_SredGasPlast.Text);
                        double P_plast_Gas_Volume = Convert.ToDouble(textBox_P_pl_PlastovoeDavlenie_Volume.Text);
                        double T_plast_Gas_Volume = Convert.ToDouble(textBox_T_p_PlastovaTemp_Gas_Volume.Text);
                        double z_Gas_Volume = Convert.ToDouble(textBox_z_KofSverhSgim_Volume.Text);

                        double V_g = ds.Gas_Volume(F, h_Gas_Volume, m_Gas_Volume, S_g, P_plast_Gas_Volume, T_plast_Gas_Volume, z_Gas_Volume);

                        textBox_Res_Volume.Text = Convert.ToString(V_g);
                        textBox_Res_Volume.Enabled = true;

                        pictureBoxGasDebit.Visible = true;
                        pictureBoxGasReserves.Visible = true;

                        pictureBoxOilReserves.Visible = false;
                        pictureBoxOilDebit.Visible = false;
                    }
                    catch
                    {
                        MessageBox.Show("Введены некоректные данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

                if (checkBox_Debit.Checked == true)
                {
                    try
                    {
                        // Газ - Дебит
                        double k_Gas_Debit = Convert.ToDouble(textBox_k_kofPonicaemosti_Gas.Text);
                        double h_Gas_Debit = Convert.ToDouble(textBox_h_effectivGasonasTolshPlasta_Gas.Text);
                        double m_gas = Convert.ToDouble(textBox_μ_Γ_BaskosstiGasa.Text);
                        double T_plast = Convert.ToDouble(textBox_T_P_TempInPlast.Text);
                        double z = Convert.ToDouble(textBox_z_KofSverhSgim_Debit.Text);
                        double R_dren = Convert.ToDouble(textBox_R_RadiusZonaDrenirovania_Gas.Text);
                        double r_skvajina = Convert.ToDouble(textBox_r_c_RadiusSkvagina.Text);
                        double P_plast = Convert.ToDouble(textBox_P_pl_PlastovoeDavlenie_Debit.Text);
                        double P_depressia = Convert.ToDouble(textBox_Depressia_Gas.Text);

                        double debit_Gas = ds.CalcGasDebit(k_Gas_Debit, h_Gas_Debit, m_gas, T_plast, z, R_dren, r_skvajina, P_plast, P_depressia);

                        textBox_Res_Debit.Text = Convert.ToString(debit_Gas);
                        textBox_Res_Debit.Enabled = true;

                        pictureBoxGasDebit.Visible = true;
                        pictureBoxGasReserves.Visible = true;

                        pictureBoxOilReserves.Visible = false;
                        pictureBoxOilDebit.Visible = false;
                    }
                    catch
                    {
                        MessageBox.Show("Введены некоректные данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxEbanayaDepressia_Neft.Clear();
            textBox_b_nObKoffNefti_Debit.Clear();
            textBox_b_n_ObKoffNeftPriPlastYsl_Volume.Clear();
            textBox_Depressia_Gas.Clear();
            textBox_F_Gasonostnosti_Gas_Volume.Clear();
            textBox_h_effectivGasonasTolshPlasta_Gas.Clear();
            textBox_h_EffectivNeftTolshinaPlasta.Clear();
            textBox_h_Gas_Volume.Clear();
            textBox_h_SrednHeftTolshPlasta_Neft.Clear();
            textBox_k_kofPonicaemosti_Gas.Clear();
            textBox_k_kofPonicaemosti_Neft.Clear();
            textBox_m_Gas_Volume.Clear();
            textBox_m_SrKoffOtkrPoristHeftPorod.Clear();
            textBox_N_CenaDel.Clear();
            textBox_n_F_ChisloLinii.Clear();
            textBox_p_n_PlotnostHeftiInPlasYslovia.Clear();
            textBox_P_pl_PlastovoeDavlenie_Debit.Clear();
            textBox_P_pl_PlastovoeDavlenie_Volume.Clear();
            textBox_Res_Debit.Clear();
            textBox_Res_Volume.Clear();
            textBox_r_c_RadiusSkvagina.Clear();
            textBox_r_c_RadiusSkvagina_Neft.Clear();
            textBox_R_RadiusZonaDrenirovania_Gas.Clear();
            textBox_R_RadiusZonDrenirovania_Neft.Clear();
            textBox_S_g_SredGasPlast.Clear();
            textBox_S_n_SrHeftPlasta.Clear();
            textBox_T_p_PlastovaTemp_Gas_Volume.Clear();
            textBox_T_P_TempInPlast.Clear();
            textBox_V_g_BalansZapasGas.Clear();
            textBox_z_KofSverhSgim_Debit.Clear();
            textBox_z_KofSverhSgim_Volume.Clear();
            textBox_μ_n_VaskostNefti.Clear();
            textBox_μ_Γ_BaskosstiGasa.Clear();
        }
    }
}
