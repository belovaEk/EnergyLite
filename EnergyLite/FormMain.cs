using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnergyLite
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

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

 
    }
}
